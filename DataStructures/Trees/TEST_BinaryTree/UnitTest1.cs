using NUnit.Framework;
using BinaryTree;
using System;

namespace TEST_BinaryTree
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Count1()
        {
            BinarySearchTree bst = new BinarySearchTree(5);

            Assert.AreEqual(bst.Count, 0);
        }

        [Test]
        public void Lookup()
        {
            BinarySearchTree bst = new BinarySearchTree(5);
            bst.Insert(10);
            bst.Insert(15);
            bst.Insert(20);
            bst.Insert(25);

            Node temp = bst.Lookup(20);
            Assert.AreEqual(20, temp.Data);
        }

        [Test]
        public void Count2()
        {
            BinarySearchTree bst = new BinarySearchTree(5);
            bst.Insert(10);
            bst.Insert(15);
            bst.Insert(20);
            bst.Insert(25);

            Assert.AreEqual(4, bst.Count);
        }

        [Test]
        public void Null()
        {
            BinarySearchTree bst = new BinarySearchTree(20);
            bst.Insert(10);
            bst.Insert(5);
            bst.Insert(22);
            bst.Insert(25);

            bst.Remove(22);
            Node temp = bst.Lookup(22);
            Assert.AreEqual(null, temp);
        }

        [Test]
        public void Remove()
        {
            BinarySearchTree bst = new BinarySearchTree(80);
            bst.Insert(66);
            bst.Insert(83);
            bst.Insert(81);
            bst.Insert(82);
            bst.Insert(99);
            bst.Insert(95);
            bst.Insert(87);
            bst.Insert(84);

            bst.Remove(80);

            Assert.AreEqual(81, bst.Root.Data);
        }

        [Test]
        public void Remove2()
        {
            BinarySearchTree bst = new BinarySearchTree(80);
            bst.Insert(66);
            bst.Insert(83);
            bst.Insert(81);
            bst.Insert(82);
            bst.Insert(99);
            bst.Insert(95);
            bst.Insert(87);
            bst.Insert(84);

            bst.Remove(87);

            Assert.AreEqual(80, bst.Root.Data);
        }

        [Test]
        public void Remove3()
        {
            BinarySearchTree bst = new BinarySearchTree(80);
            bst.Insert(66);
            bst.Insert(83);
            bst.Insert(81);
            bst.Insert(82);
            bst.Insert(99);
            bst.Insert(95);
            bst.Insert(87);
            bst.Insert(84);

            var temp = bst.Remove(87);

            Assert.True(temp);
        }
    }
}