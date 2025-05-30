using System;
using System.Diagnostics;

namespace XPlaneConnector
{
    public class DataRefElement
    {
        private static int current_id = 0;

        public int Id { get; set; }
        public string DataRef { get; set; }
        public int Frequency { get; set; }
        public bool IsInitialized { get; set; }
        private readonly Stopwatch sw = new Stopwatch();
        public string Units { get; set; }
        public string Description { get; set; }
        public float Value { get; set; }

        public delegate void NotifyChangeHandler(DataRefElement sender, float newValue);
        public event NotifyChangeHandler? OnValueChange = null;

        public DataRefElement(string dataref, string units, string description)
        {
            Id = Interlocked.Increment(ref current_id);  
            IsInitialized = false;
            DataRef = dataref;
            Description = description;
            Units = units;
            Value = float.MinValue;
        }

        public TimeSpan Age
        {
            get
            {
                return sw.Elapsed;
            }
        }

        public bool Update(int id, float value)
        {
            if (id == Id)
            {
                sw.Restart();

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
}
