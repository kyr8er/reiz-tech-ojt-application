namespace RecursiveBSTreeDepthCalculator
{
    internal class Branch
    {
        public List<Branch> Branches { get; set; }
        public int Node { get; set; }

        public Branch()
        {
            Branches = new List<Branch>();
        }

        private Branch(int node)
        {
            Node = node;
            Branches = new List<Branch>();
        }

        public void Add(int Node)
        {
            if(Node < this.Node)
            {
                if(Branches.Any())
                {
                    Branches[0].Add(Node);
                }
                else
                {
                    Branches.Add(new Branch(Node));
                }
            }
            else
            {
                if(Branches.Count > 1)
                {
                    Branches[1].Add(Node);
                }
                else
                {
                    Branches.Add(new Branch(Node));
                }
            }
        }

        public int Depth()
        {
            if(!Branches.Any())
            {
                return 1;
            }
            else
            {
                return 1 + Branches.Max(b => b.Depth());
            }
        }

        public void PrintTree(string prefix = "")
        {
            Console.WriteLine($"{prefix}{Node}");

            for (int i = 0; i < Branches.Count; i++)
            {
                if (i == 0)
                {
                    Branches[i].PrintTree(prefix + "|-- ");
                }
                else
                {
                    Branches[i].PrintTree(prefix + "└-- ");
                }
            }
        }
    }
}
