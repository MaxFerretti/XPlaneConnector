using System;
using System.Collections.Generic;

namespace XPlaneConnector
{
    public class XPDatagram
    {
        public List<byte> Bytes { get; set; }

        public XPDatagram()
        {
            Bytes = new List<byte>();
        }

        public byte[] Get()
        {
            return Bytes.ToArray();
        }

        public void Add(byte value)
        {
            Bytes.Add(value);
        }

        public void Add(int value)
        {
            var bElement = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian)
            {
                Bytes.Add(bElement[0]);
                Bytes.Add(bElement[1]);
                Bytes.Add(bElement[2]);
                Bytes.Add(bElement[3]);
            }
            else
            {
                Bytes.Add(bElement[3]);
                Bytes.Add(bElement[2]);
                Bytes.Add(bElement[1]);
                Bytes.Add(bElement[0]);
            }
        }
        public void Add(float value)
        {
            var bElement = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian)
            {
                Bytes.Add(bElement[0]);
                Bytes.Add(bElement[1]);
                Bytes.Add(bElement[2]);
                Bytes.Add(bElement[3]);
            }
            else
            {
                Bytes.Add(bElement[3]);
                Bytes.Add(bElement[2]);
                Bytes.Add(bElement[1]);
                Bytes.Add(bElement[0]);
            }
        }
        public void Add(string value)
        {
            foreach (var character in value)
                Bytes.Add((byte)character);
            Bytes.Add(0x00);
        }

        public void FillTo(int count, byte filler = 0x00)
        {
            for (var i = Bytes.Count; i < count; i++)
                Bytes.Add(filler);
        }

        public int Len
        {
            get
            {
                return Bytes.Count;
            }
        }
    }
}


