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
}
