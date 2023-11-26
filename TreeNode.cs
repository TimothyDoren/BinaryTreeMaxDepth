using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeMaxDepth
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public int MaxDepth(TreeNode root)
        {
            int depth = 0;
            if (root == null)
            {
                depth = 0;
            }
            if (root != null)
            {
                int leftDepth = MaxDepth(root.left);
                int rightDepth = MaxDepth(root.right);

                depth = Math.Max(leftDepth, rightDepth) + 1;
            }

            return depth;
        }
    }
}
