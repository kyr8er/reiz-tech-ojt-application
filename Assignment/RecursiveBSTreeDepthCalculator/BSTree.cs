namespace RecursiveBSTreeDepthCalculator
{
    internal class BSTree
    {
        public Branch Root { get; set; }

        public BSTree()
        {
            Root = new Branch();
        }

        public BSTree(int rootVal)
        {
            Root = new Branch(rootVal);
        }

        /// <summary>
        /// Adds a node to the tree.
        /// </summary>
        /// <param name="node">The node to add.</param>
        public void Add(int node)
        {
            Add(node, Root);
        }

        /// <summary>
        /// The private recursive add method.
        /// </summary>
        /// <param name="node">The node to add.</param>
        /// <param name="branch">The children branches.</param>
        private void Add(int node, Branch branch)
        {
            if (node < branch.Node)
            {
                if (branch.Left == null)
                {
                    branch.Left = new Branch(node);
                }
                else
                {
                    Add(node, branch.Left);
                }
            }
            else
            {
                if (branch.Right == null)
                {
                    branch.Right = new Branch(node);
                }
                else
                {
                    Add(node, branch.Right);
                }
            }
        }

        /// <summary>
        /// Gets the depth of the tree.
        /// </summary>
        /// <returns>Depth of the tree as an integer.</returns>
        public int GetDepth()
        {
            return GetDepth(Root);
        }

        /// <summary>
        /// The private recursive get depth method for each children branch.
        /// </summary>
        /// <param name="branch">The branch to get depth from.</param>
        /// <returns></returns>
        private int GetDepth(Branch branch)
        {
            if (branch == null)
            {
                return 0;
            }
            else
            {
                return 1 + Math.Max(GetDepth(branch.Left!), GetDepth(branch.Right!));
            }
        }

        /// <summary>
        /// Prints the tree in-order traversal.
        /// </summary>
        public void PrintInOrder()
        {
            PrintInOrder(Root);
        }

        /// <summary>
        /// The private recursive print in-order method.
        /// </summary>
        /// <param name="branch">The branch to print from.</param>
        private void PrintInOrder(Branch branch)
        {
            if (branch != null)
            {
                PrintInOrder(branch.Left);
                Console.Write(branch.Node + ", ");
                PrintInOrder(branch.Right);
            }
        }

    }
}
