using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
     class BinarySearchTree
    {
        public Node Root;

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(int data)
        {
            Root = InsertRec(Root, data);
        }

        private Node InsertRec (Node root, int data)
        {
            if (root == null) 
            {
                root = new Node(data);
                return root;
            }
            if (data < root.Data)
            {
                root.Left = InsertRec(root.Left, data);
            }
            else if (data > root.Data)
            {
                root.Right = InsertRec(root.Right, data);
            }
            return root;
        }

        public void Remove(int data) 
        {
            Root = RemoveRec(Root, data);
        }

        private Node RemoveRec(Node root, int data) 
        {
            if(root == null) 
            {
                return root;
            }
            if (data < root.Data)
            {
                root.Left = RemoveRec(root.Left, data);
            }

            else if (data > root.Data)
            {
                root.Right = RemoveRec(root.Right, data);
            }
            else
            {
                if (root.Left != null)
                {
                    return root.Right;
                }
                else if (root.Right == null)
                {
                    root.Data = MinValue(root.Right);
                    root.Right = RemoveRec(root.Right, root.Data);
                }
            }
            return root;

        }
        private int MinValue(Node root) 
        {
            int minValue = root.Data;
            while(root.Left != null) 
            {
                minValue = root.Left.Data;
                root = root.Left;
            }
            return minValue;
        }

        public bool Search(int data)
        {
            return SearchRec(Root, data);
        }

        private bool SearchRec(Node root, int data)
        {
            if (root == null)
            {

                 return false;

            }
            if (data == root.Data)
            {
                
            return true;

            }
            if(data < root.Data) 
            {
                return SearchRec(root.Left, data);  
            }
            return SearchRec(root.Right, data);
        }
        public void InOrderTraversal()
        {
            InOrderTraversalRec(Root);
            Console.WriteLine();
        }
        public void InOrderTraversalRec(Node root)
        {
            if(root != null) 
            {
                InOrderTraversalRec(root.Left);
                Console.WriteLine(root.Data + " ");
                InOrderTraversalRec(root.Right);
            }
        }
        public void PreOrderTraversal()
        {
            PreOrderTraversal(Root);
            Console.WriteLine();
        }
        public void PreOrderTraversal(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.Data + " ");
                PreOrderTraversal(root.Left);
                PreOrderTraversal(root.Right);
            }
        }
        public void PostOrderTraversal()
        {
            PostOrderTraversal(Root);
            Console.WriteLine();
        }
        public void PostOrderTraversal(Node root)
        {
            if (root != null)
            {
                PostOrderTraversal(root.Left);
                PostOrderTraversal(root.Right);
                Console.WriteLine(root.Data + " ");
            }
        }

    }
}
