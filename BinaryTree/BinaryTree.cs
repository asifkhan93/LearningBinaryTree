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

        //public void Insert(int data)
        //{
        //    Node newNode = new Node(data);

        //    if (Root == null) 
        //    {
        //        Root = newNode;
        //        return;
        //    }

        //    Node current = Root;
        //    Node parent = null;

        //    while (current != null)
        //    {
        //        parent = current;

        //        if (data < current.Data)
        //        {
        //            current = current.Left;
        //        }
        //        else if (data > current.Data)
        //        {
        //            current = current.Right;
        //        }
        //        else
        //        {
        //            return;
        //        }
        //    }
        //    if (data < parent.Data)
        //    {
        //        parent.Left = newNode;

        //    }
        //    else 
        //    {
        //        parent.Right = newNode;
        //    }
        //}


        //Recursive method to insert a new node
        public void Insert(int data)
        {
            Root = InsertRec(Root, data);
        }
        private Node InsertRec(Node root, int data)
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
        //104. Maximum Depth of Binary Tree
        //A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.

        public int MaxDepth(Node root)
        {
            if (root == null)
                return 0;

            int left = MaxDepth(root.Left);
            int right = MaxDepth(root.Right);
            return Math.Max(left, right) + 1;
        }
        public Node InvertTree(Node root)
        {
            if (root != null)
            {
                var temp = root.Left;
                root.Left = root.Right;
                root.Right = InvertTree(temp);
            }
            return root;
        }



 
        public void Remove(int data) 
        {
            //Root = RemoveRec(Root, data);
        }

        public void InOrderTraversal(Node root)
        {
            if (root != null)
            {
                InOrderTraversal(root.Left);
                Console.Write(root.Data + " ");
                InOrderTraversal(root.Right);
            }
        }
        int max = 0;

        //leetCode543 : Diameter of Binary Tree
        //The diameter of a binary tree is the length of the longest path between any two nodes in a tree.
        //This path may or may not pass through the root.
        public int DiameterOfBinaryTree(Node root) 
        {
            this.Helper(root);
            return max;
        }
        public int Helper(Node root)
        {
            if (root == null)
                return 0;

            int left = this.Helper(root.Left);
            int right = this.Helper(root.Right);
            max = Math.Max(max, left + right);
            return Math.Max(left, right) + 1;
        }

        // leetCode 110: determine if it is height-balanced
        //public bool IsBalanced(Node root)
        //{
        //    if (root == null)
        //    {
        //        return true;
        //    }
        //    if (Math.Abs(height(root.Left) - height(root.Right)) > 1)
        //    {
        //        return false;
        //    }

        //    return IsBalanced(root.Left) && IsBalanced(root.Right);

        //}

        //public int height(Node node)
        //{
        //    if (node == null)
        //        return 0;

        //    return 1 + Math.Max(height(node.Left), height(node.Right));
        //}

        //optimal solution (DFS method) 
        public bool IsBalanced(Node root)
        {
            if (root == null)
            {
                return true;
            }
            return height(root) != -1;
        }
        public int height(Node node)
        {
            if (node == null)
                return 0;

            int left = height(node.Left);
            int right = height(node.Right);

            int balacedFactor = Math.Abs(left - right);

            if (balacedFactor > 1 || left == -1 || right == -1)
            {
                return -1;
            }

            return 1 + Math.Max(left, right);

        }
    }
}
