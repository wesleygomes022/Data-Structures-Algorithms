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

    }
}
