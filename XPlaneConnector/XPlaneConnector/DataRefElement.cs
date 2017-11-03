using System;

namespace XPlaneConnector
{
    public class DataRefElement
    {
        public int Id { get; set; }
        public string DataRef { get; set; }
        public int Frequency { get; set; }
        public float CurrentValue { get; set; }
        public bool IsInitialized { get; set; }
        public DateTime LastUpdate { get; set; }
        public DataRefElement()
        {
            IsInitialized = false;
            LastUpdate = DateTime.MinValue;
            CurrentValue = float.MinValue;
        }

        public TimeSpan Age
        {
            get
            {
                return DateTime.Now - LastUpdate;
            }
        }

        public delegate void NotifyChangeHandler(DataRefElement element, float newValue);
        public event NotifyChangeHandler OnValueChange;

        public bool Update(float new_value)
        {
            LastUpdate = DateTime.Now;

            if (new_value != CurrentValue)
            {
                IsInitialized = true;
                CurrentValue = new_value;
                OnValueChange?.Invoke(this, new_value);
                return true;
            }

            return false;
        }
    }

}
