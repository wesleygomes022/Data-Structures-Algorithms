using System;
using System.Collections.Generic;

namespace HashTable
{
    public class HashTable
    {
        LinkedList<string>[] _arr;
        public int Count { get; private set; }

        public HashTable(int size)
        {
            _arr = new LinkedList<string>[size];
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

        public void Add(string key)
        {

            int hash = Hash(key);
            if (Contains(key))
            {
                throw new InvalidOperationException("Key already exists.");
            }
            else if(_arr[hash] == null)
            {
                _arr[hash] = new LinkedList<string>();
                _arr[hash].AddLast(key);
                Count++;
            }
            else
            {
                _arr[hash].AddLast(key);
                Count++;
            }            
        }

        public bool Contains(string key)
        {
            int hash = Hash(key);
            if (_arr[hash] == null) return false;

            foreach (string el in _arr[hash])
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

            foreach (string el in _arr[hash])
            {
                if (el.Equals(key))
                {
                    string temp = el;
                    _arr[hash].Remove(el);
                    Count--;
                    return temp;
                }
            }

            throw new InvalidOperationException("Key doesn't exists.");
        }
    }
}
