namespace RecursiveBSTreeDepthCalculator
{
    internal class Branch
    {
        public List<Branch> Branches { get; set; }

        public int Node { get; set; }

        /// <summary>
        /// Gets or sets the left branch.
        /// </summary>
        public Branch? Left
        {
            get
            {
                if (Branches.Count > 0)
                {
                    return Branches[0];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (Branches.Count > 0)
                {
                    Branches[0] = value!;
                }
                else
                {
                    Branches.Add(value!);
                }
            }
        }

        /// <summary>
        /// Gets or sets the right branch.
        /// </summary>
        public Branch? Right
        {
            get
            {
                if (Branches.Count > 1)
                {
                    return Branches[1];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (Branches.Count > 1)
                {
                    Branches[1] = value!;
                }
                else
                {
                    Branches.Add(value!);
                }
            }
        }

        public Branch()
        {
            Branches = new List<Branch>();
        }

        public Branch(int node)
        {
            Node = node;
            Branches = new List<Branch>();
        }
    }
}
