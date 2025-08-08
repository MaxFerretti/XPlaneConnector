using System.Diagnostics;

namespace XPlaneConnectorCore
{
    public class StringDataRefElement
    {
        private readonly char[] _characters;
        private readonly bool[] _received;
        
        public string DataRef { get; set; }
        public int Frequency { get; set; }
        public int StringLength { get; set; }
        public string Value { get; private set; } = "";

        private readonly Stopwatch sw = new Stopwatch();
        private TimeSpan MaxAge = TimeSpan.FromSeconds(5);

        public bool IsCompletelyInitialized
        {
            get
            {
                return _received.All(x => x);
            }
        }

        public event Action<StringDataRefElement, string> OnValueChange;

        public TimeSpan Age { get
            {
                return sw.Elapsed;
            } 
        }

        public StringDataRefElement(string dataRef, int length)
        {
            if (length <= 0)
                throw new ArgumentOutOfRangeException("length");

            DataRef = dataRef;
            StringLength = length;
            _characters = new char[length];
            _received = new bool[length];

            sw.Start();
        }

        public void Update(int index, char character)
        {
            if (index < 0 || index >= StringLength)
                return;

            if (Age > MaxAge)
                Reset();

            sw.Restart();

            bool changed = false;

            if (!_received[index] || _characters[index] != character)
            {
                _characters[index] = character;
                _received[index] = true;
                changed = true;
            }

            if(IsCompletelyInitialized && changed)
            {
                var newValue = new string(_characters).TrimEnd('\0');
                if(newValue != Value)
                {
                    Value = newValue;
                    OnValueChange?.Invoke(this, Value);
                }

                Reset();
            }
        }

        private void Reset()
        {
            Array.Clear(_characters, 0, _characters.Length);
            Array.Clear(_received, 0, _received.Length);
            Value = "";
            sw.Restart();
        }
    }
}
