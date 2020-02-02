using System;

namespace XPlaneConnector
{
    public class DataRefElement
    {
        private static object lockElement = new object();
        private static int current_id = 0;

        public int Id { get; set; }
        public string DataRef { get; set; }
        public int Frequency { get; set; }
        public bool IsInitialized { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Units { get; set; }
        public string Description { get; set; }
        public float Value { get; set; }

        public delegate void NotifyChangeHandler(DataRefElement sender, float newValue);
        public event NotifyChangeHandler OnValueChange;

        public DataRefElement()
        {
            lock (lockElement)
            {
                Id = ++current_id;
            }
            IsInitialized = false;
            LastUpdate = DateTime.MinValue;
            Value = float.MinValue;
        }

        public TimeSpan Age
        {
            get
            {
                return DateTime.Now - LastUpdate;
            }
        }

        public bool Update(int id, float value)
        {
            if (id == Id)
            {
                LastUpdate = DateTime.Now;

                if (value != Value)
                {
                    Value = value;
                    IsInitialized = true;
                    OnValueChange?.Invoke(this, Value);
                    return true;
                }
            }

            return false;
        }
    }

    public class StringDataRefElement
    {
        private static readonly object lockElement = new object();
        public string DataRef { get; set; }
        public int Frequency { get; set; }
        public int StringLenght { get; set; }
        public string Value { get; set; }

        private int CharactersInitialized;

        public bool IsCompletelyInitialized
        {
            get
            {
                return CharactersInitialized >= StringLenght;
            }
        }

        public delegate void NotifyChangeHandler(StringDataRefElement sender, string newValue);
        public event NotifyChangeHandler OnValueChange;

        public void Update(int index, char character)
        {
            lock (lockElement)
            {
                var fireEvent = !IsCompletelyInitialized;

                if (!IsCompletelyInitialized)
                    CharactersInitialized++;

                if (character > 0)
                {
                    if (Value.Length <= index)
                        Value = Value.PadRight(index + 1, ' ');

                    var current = Value[index];
                    if (current != character)
                    {
                        Value = Value.Remove(index, 1).Insert(index, character.ToString());
                        fireEvent = true;
                    }
                }

                if (IsCompletelyInitialized && fireEvent)
                    OnValueChange?.Invoke(this, Value);
            }
        }

        public StringDataRefElement()
        {
            CharactersInitialized = 0;
            Value = "";
        }
    }
}
