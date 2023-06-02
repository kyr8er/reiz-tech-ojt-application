using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Add(int node)
        {
            Add(node, Root);
        }

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

        public int GetDepth()
        {
            return GetDepth(Root);
        }

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

        public void PrintTree()
        {
            PrintTree(Root, 0);
        }

        private void PrintTree(Branch branch, int level)
        {
            if (branch == null)
            {
                return;
            }

            PrintTree(branch.Right!, level + 1);

            for (int i = 0; i < level; i++)
            {
                Console.Write("    ");
            }

            Console.WriteLine(branch.Node);

            PrintTree(branch.Left!, level + 1);
        }

    }
}
