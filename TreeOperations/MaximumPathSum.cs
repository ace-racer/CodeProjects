using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProjects.TreeOperations
{
    public class MaximumPathSum : BaseTreeOperations
    {
        public MaximumPathSum() : base()
        {

        }

        public int GetMaximumPathSum()
        {
            return this.GetMaximumPathSumHelper(this.treeRoot);
        }

        private int GetMaximumPathSumHelper(TreeNode treeNode)
        {
            if(treeNode == null)
            {
                return 0;
            }

            // get the max sum of the left sub tree
            var leftTreeMaximumSum = this.GetMaximumPathSumHelper(treeNode.LeftNode);

            // get the max sum of the right sub tree
            var rightTreeMaximumSum = this.GetMaximumPathSumHelper(treeNode.RightNode);

            var maximumSumOfChildren = Math.Max(leftTreeMaximumSum, rightTreeMaximumSum);

            return maximumSumOfChildren + treeNode.Value;
        }
    }

}
