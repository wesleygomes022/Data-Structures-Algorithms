using System;
using System.Collections.Generic;

namespace HashTable
{
    public class Data
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public Data(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public override bool Equals(object obj)
        {
            string key = obj as string;
            return Key.Equals(key);
        }

        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }
    }
}
