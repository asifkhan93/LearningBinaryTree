namespace BinaryTree 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();

           // Insert some data
            bst.Insert(4);
            bst.Insert(2);
            bst.Insert(7);
            bst.Insert(1);
            bst.Insert(3);
            bst.Insert(6);
            bst.Insert(9);


           // Display the tree
            Console.WriteLine("Pre-Order Traversal:");
            bst.PreOrderTraversal();
            Console.WriteLine("In-Order Traversal:");
            bst.InOrderTraversal();
            Console.WriteLine("Post-Order Traversal:");
            bst.PostOrderTraversal();

           // Search for a value

            int searchValue = 40;
            Console.WriteLine($"Search for {searchValue}: {bst.Search(searchValue)}");

            //Remove a value
            int removeValue = 30;
            bst.Remove(removeValue);
            Console.WriteLine($"In-Order Traversal after removing {removeValue}:");
            bst.InOrderTraversal();

            bst.InvertTree(bst.Root);
            Console.WriteLine("In-Order Traversal inverted:");
            bst.InOrderTraversal();

            Console.Write("Maximum Depth of Binary Tree: ");
            Console.WriteLine(bst.MaxDepth(bst.Root));

            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(30);
            binaryTree.Insert(50);
            binaryTree.Insert(20);
            binaryTree.Insert(90);
            binaryTree.Insert(70);
            binaryTree.Insert(60);
            binaryTree.Insert(10);
            binaryTree.Insert(80);
            binaryTree.Insert(35);

            Console.WriteLine("In-Order Traversal of Binary Tree: ");
            binaryTree.InOrderTraversal(binaryTree.Root);

            Console.Write("\nDiameter of Binary Tree: ");
            Console.WriteLine(binaryTree.DiameterOfBinaryTree(binaryTree.Root));


            Console.Write("\nIs this a Balanced Binary Tree? : ");
            Console.WriteLine(binaryTree.IsBalanced(binaryTree.Root));

            //binaryTree.InvertTree(binaryTree.Root);
            //Console.WriteLine("In-Order Traversal inverted:");
            //binaryTree.InOrderTraversal(binaryTree.Root);

            //Console.Write("Maximum Depth of Binary Tree: ");
            //Console.WriteLine(binaryTree.MaxDepth(binaryTree.Root));

        }
    }
}