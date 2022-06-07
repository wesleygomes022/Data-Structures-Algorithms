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
            hs.Add("t-wdepaiva", "Wesley Gomes de Paiva");
            hs.Add("ateoi", "Alexandre Teoi");
            hs.Add("rafaelt", "Rafael Teixeira");
            hs.Add("leadro", "Leandro Prado");

            Assert.IsTrue(hs.Count == 4);
        }

        [Test]
        public void TestSameValue()
        {
            HashTable hs = new HashTable(10);
            hs.Add("t-wdepaiva", "Wesley Gomes de Paiva");
            hs.Add("ateoi", "Alexandre Teoi");
            hs.Add("rafaelt", "Rafael Teixeira");
            hs.Add("leadro", "Leandro Prado");

            Assert.Throws<InvalidOperationException>(() => hs.Add("t-wdepaiva", "Wesley de Paiva"));
        }

        [Test]
        public void TestSameValue_II()
        {
            HashTable hs = new HashTable(10);
            hs.Add("t-wdepaiva", "Wesley Gomes de Paiva");
            hs.Add("ateoi", "Alexandre Teoi");
            hs.Add("rafaelt", "Rafael Teixeira");
            hs.Add("leadro", "Leandro Prado");

            Assert.DoesNotThrow(() => hs.Add("WEsley", "Wesley Gomes de Paiva"));
        }

        [Test]
        public void Collision()
        {
            HashTable hs = new HashTable(2);
            hs.Add("t-wdepaiva", "Wesley Gomes de Paiva");
            hs.Add("ateoi", "Alexandre Teoi");
            hs.Add("rafaelt", "Rafael Teixeira");
            hs.Add("leadro", "Leandro Prado");
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
            hs.Add("t-wdepaiva", "Wesley Gomes de Paiva");
            hs.Add("ateoi", "Alexandre Teoi");
            hs.Add("rafaelt", "Rafael Teixeira");
            hs.Add("leadro", "Leandro Prado");

            Assert.Throws<InvalidOperationException>(() => hs.Remove("Teoi"));
        }

        [Test]
        public void Contain()
        {
            HashTable hs = new HashTable(2);
            hs.Add("t-wdepaiva", "Wesley Gomes de Paiva");
            hs.Add("ateoi", "Alexandre Teoi");
            hs.Add("rafaelt", "Rafael Teixeira");
            hs.Add("leadro", "Leandro Prado");

            Assert.IsTrue(hs.ContainsKey("ateoi"));
        }

        [Test]
        public void Contain_II()
        {
            HashTable hs = new HashTable(2);
            hs.Add("t-wdepaiva", "Wesley Gomes de Paiva");
            hs.Add("ateoi", "Alexandre Teoi");
            hs.Add("rafaelt", "Rafael Teixeira");
            hs.Add("leadro", "Leandro Prado");

            Assert.IsFalse(hs.ContainsKey("banana"));
        }

        [Test]
        public void MatchKeyValue()
        {
            HashTable hs = new HashTable(2);
            hs.Add("t-wdepaiva", "Wesley Gomes de Paiva");
            hs.Add("ateoi", "Alexandre Teoi");
            hs.Add("rafaelt", "Rafael Teixeira");
            hs.Add("leadro", "Leandro Prado");

            Assert.AreEqual("Alexandre Teoi", hs.GetValue("ateoi"));
        }
    }
}