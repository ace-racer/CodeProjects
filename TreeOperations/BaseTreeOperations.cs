using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProjects.TreeOperations
{
    public class BaseTreeOperations
    {
        protected TreeNode treeRoot;

        public BaseTreeOperations()
        {
            treeRoot = null;
        }

        public void CreateTree(int[] vals)
        {
            if(vals != null && vals.Any())
            {
                this.treeRoot = CreateTree(vals, 0, vals.Length - 1);
            }
        }

        private TreeNode CreateTree(int[] vals, int start, int end)
        {
            if(start > end)
            {
                return null;
            }

            int mid = start + (end - start) / 2;
            var middleNode = new TreeNode(vals[mid]);
            middleNode.LeftNode = CreateTree(vals, start, mid - 1);
            middleNode.RightNode = CreateTree(vals, mid + 1, end);
            return middleNode;
        }

        public void PrintTreeInorder()
        {
            this.PrintTreeInorderHelper(this.treeRoot);
        }

        private void PrintTreeInorderHelper(TreeNode treeNode)
        {
            if(treeNode != null)
            {
                PrintTreeInorderHelper(treeNode.LeftNode);
                Console.WriteLine(treeNode.Value);
                PrintTreeInorderHelper(treeNode.RightNode);
            }
        }
    }
}
