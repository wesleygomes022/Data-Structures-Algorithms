using System;
using System.Collections.Generic;

namespace HashTable
{
    public class HashTable
    {
        LinkedList<Data>[] _arr;
        public int Count { get; private set; }

        public HashTable(int size)
        {
            _arr = new LinkedList<Data>[size];
        }

        public int Hash(string key)
        {
            int hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                int temp = (int)key[i];
                hash = (hash + temp * i) % _arr.Length;
            }

            return hash;
        }

        public void Add(string key, string value)
        {
            Data kv = new Data(key, value);
            int hash = Hash(key);
            if (ContainsKey(key))
            {
                throw new InvalidOperationException("Key already exists.");
            }
            else if(_arr[hash] == null)
            {
                _arr[hash] = new LinkedList<Data>();
                _arr[hash].AddLast(kv);
                Count++;
            }
            else
            {
                _arr[hash].AddLast(kv);
                Count++;
            }            
        }

        public bool ContainsKey(string key)
        {
            int hash = Hash(key);
            if (_arr[hash] == null) return false;

            foreach (Data el in _arr[hash])
            {
                if (el.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }

        public string Remove(string key)
        {
            int hash = Hash(key);
            if (_arr[hash] == null) throw new InvalidOperationException("Key doesn't exists.");

            foreach (Data el in _arr[hash])
            {
                if (el.Equals(key))
                {
                    string temp = el.Key;
                    _arr[hash].Remove(el);
                    Count--;
                    return temp;
                }
            }

            throw new InvalidOperationException("Key doesn't exists.");
        }

        public string GetValue(string key)
        {
            int hash = Hash(key);

            if (_arr[hash] != null)
            {
                foreach (Data el in _arr[hash])
                {
                    if(el.Equals(key))
                    {
                        return el.Value;
                    }
                }
            }

            throw new InvalidOperationException("Key doesn't exists.");
        }
    }
}
