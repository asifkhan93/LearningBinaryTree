using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
     class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(int data)
        {
            Node newNode = new Node(data);

            if (Root == null) 
            {
                Root = newNode;
                return;
            }

            Node current = Root;
            Node parent = null;

            while (current != null)
            {
                parent = current;

                if (data < current.Data)
                {
                    current = current.Left;
                }
                else if (data > current.Data)
                {
                    current = current.Right;
                }
                else
                {
                    return;
                }
            }
            if (data < parent.Data)
            {
                parent.Left = newNode;

            }
            else 
            {
                parent.Right = newNode;
            }
        }
        // Recursive method to insert a new node
        //private Node InsertRec(Node root, int data)
        //{
        //    if (root == null)
        //    {
        //        root = new Node(data);
        //        return root;
        //    }

        //    if (data < root.Data)
        //    {
        //        root.Left = InsertRec(root.Left, data);
        //    }
        //    else if (data > root.Data)
        //    {
        //        root.Right = InsertRec(root.Right, data);
        //    }

        //    return root;
        //}
        public void Remove(int data) { }

        public void InOrderTraversal(Node root)
        {
            if (root != null)
            {
                InOrderTraversal(root.Left);
                Console.Write(root.Data + " ");
                InOrderTraversal(root.Right);
            }
        }
    }
}
