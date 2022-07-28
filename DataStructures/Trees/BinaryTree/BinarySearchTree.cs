using System;

namespace BinaryTree
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }
        public int Count { get; set; }

        public BinarySearchTree(int data)
        {
            Root = new Node(data);
        }

        public Node Lookup(int data)
        {
            return Lookup(data, Root);
        }

        public Node Lookup(int data, Node node)
        {
            if (node != null)
            {
                if (data == node.Data)
                {
                    return node;
                }
                else if (data < node.Data)
                {
                    return Lookup(data, node.Left);
                }
                else
                {
                    return Lookup(data, node.Right);
                }
            }

            return null;
        }

        public bool Insert(int data)
        {
            Node before = null, after = Root;
            while (after != null)
            {
                before = after;
                if (data < after.Data)
                {
                    after = after.Left;
                }
                else if (data > after.Data)
                {
                    after = after.Right;
                }
                else
                {
                    throw new InvalidOperationException("Number already exists in tree.");
                }
            }
            Node newNode = new Node(data);

            if (data < before.Data)
            {
                before.Left = newNode;
            }
            else
            {
                before.Right = newNode;
            }
            Count++;
            return true;
        }

        private int MinValue(Node node)
        {
            int minv = node.Data;

            while (node.Left != null)
            {
                minv = node.Left.Data;
                node = node.Left;
            }

            return minv;
        }

        public void Remove(int value)
        {
            Root = Remove(Root, value);
        }

        private Node Remove(Node parent, int key)
        {
            if (parent == null) return parent;
            if (key < parent.Data) parent.Left = Remove(parent.Left, key);
            else if (key > parent.Data) parent.Right = Remove(parent.Right, key);

            else
            {
                if (parent.Left == null) return parent.Right;
                else if (parent.Right == null) return parent.Left;

                parent.Data = MinValue(parent.Right);
                parent.Right = Remove(parent.Right, parent.Data);
            }
            return parent;
        }
    }
}
