using RecursiveBSTreeDepthCalculator;

var root = new Branch();

while(true)
{
    Console.WriteLine("Enter a number to add to the tree or 'q' to quit");
    string input = Console.ReadLine()!;
    if(input == "q")
    {
        break;
    }
    else
    {
        int node = int.Parse(input);
        root.Add(node);
    }
}

Console.WriteLine($"Depth of tree is {root.Depth()}");
root.PrintTree();