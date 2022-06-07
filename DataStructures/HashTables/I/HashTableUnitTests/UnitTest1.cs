using NUnit.Framework;
using System;

namespace HashTable
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCountElem()
        {
            HashTable hs = new HashTable(10);
            hs.Add("Wesley");
            hs.Add("Vilma");
            hs.Add("Felipe");
            hs.Add("Luis");

            Assert.IsTrue(hs.Count == 4);
        }

        [Test]
        public void TestSameValue()
        {
            HashTable hs = new HashTable(10);
            hs.Add("Wesley");
            hs.Add("Vilma");
            hs.Add("Felipe");            

            Assert.Throws<InvalidOperationException>(() => hs.Add("Wesley"));
        }

        [Test]
        public void TestSameValue_II()
        {
            HashTable hs = new HashTable(10);
            hs.Add("Wesley");
            hs.Add("Vilma");
            hs.Add("Felipe");

            Assert.DoesNotThrow(() => hs.Add("WEsley"));
        }

        [Test]
        public void Collision()
        {
            HashTable hs = new HashTable(2);
            hs.Add("Wesley");
            hs.Add("Vilma");
            hs.Add("Felipe");
            hs.Add("Luis");
            Assert.IsTrue(hs.Count == 4);
        }

        [Test]
        public void RemoveFromEmptyHash()
        {
            HashTable hs = new HashTable(5);

            Assert.Throws<InvalidOperationException>(() => hs.Remove("Wesley"));
        }

        [Test]
        public void RemoveNoExistingKey()
        {
            HashTable hs = new HashTable(4);
            hs.Add("Wesley");
            hs.Add("Vilma");
            hs.Add("Felipe");
            hs.Add("Luis");

            Assert.Throws<InvalidOperationException>(() => hs.Remove("Teoi"));
        }

        [Test]
        public void Contain()
        {
            HashTable hs = new HashTable(2);
            hs.Add("Wesley");
            hs.Add("Vilma");
            hs.Add("Felipe");
            hs.Add("Luis");
            hs.Add("Teoi");

            Assert.IsTrue(hs.Contains("Teoi"));
        }

        [Test]
        public void Contain_II()
        {
            HashTable hs = new HashTable(2);
            hs.Add("Wesley");
            hs.Add("Vilma");
            hs.Add("Felipe");
            hs.Add("Luis");
            hs.Add("Teoi");

            Assert.IsFalse(hs.Contains("banana"));
        }
    }
}