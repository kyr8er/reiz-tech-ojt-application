namespace RecursiveBSTreeDepthCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter root value of tree: ");
            int root = int.Parse(Console.ReadLine()!);
            var tree = new BSTree(root);
            while(true)
            {
                Console.Write("Enter a number to add to the tree (or 'q' to quit): ");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                else
                {
                    if (int.TryParse(input, out var node))
                    {
                        tree.Add(node);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                }
            }

            Console.WriteLine($"Depth: {tree.GetDepth()}");
            tree.PrintTree();
        }
    }
}