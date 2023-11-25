namespace BinaryTree 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();

            // Insert some data
            bst.Insert(50);
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(20);
            bst.Insert(40);
            bst.Insert(60);
            bst.Insert(80);

            // Display the tree
            Console.WriteLine("In-Order Traversal:");
            bst.InOrderTraversal();

            // Search for a value
            int searchValue = 40;
            Console.WriteLine($"Search for {searchValue}: {bst.Search(searchValue)}");

            // Remove a value
            int removeValue = 30;
            bst.Remove(removeValue);
            Console.WriteLine($"In-Order Traversal after removing {removeValue}:");
            bst.InOrderTraversal();

            //BinaryTree binaryTree = new BinaryTree();

            //binaryTree.Insert(30);
            //binaryTree.Insert(50);
            //binaryTree.Insert(20);
            //binaryTree.Insert(90);
            //binaryTree.Insert(70);
            //binaryTree.Insert(60);
            //binaryTree.Insert(10);
            //binaryTree.Insert(80);
            //binaryTree.Insert(35);

            //Console.WriteLine("In-Order Traversal: ");
            //binaryTree.InOrderTraversal(binaryTree.Root);

        }
    }
}