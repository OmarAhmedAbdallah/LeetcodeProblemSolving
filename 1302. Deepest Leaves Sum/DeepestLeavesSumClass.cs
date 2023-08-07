using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._1302._Deepest_Leaves_Sum
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

        public TreeNode initialTree()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right.left = null;
            root.right.right = new TreeNode(6);
            root.left.left.left = new TreeNode(7);
            root.left.left.right = null;
            root.left.right.left = null;
            root.left.right.right = null;
            root.right.right.left = null;
            root.right.right.right = new TreeNode(8);

            return root;
        }
    }

    internal class DeepestLeavesSumClass
    {
        public int DeepestLeavesSum(TreeNode root)
        {
            int res = 0;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                int size = q.Count;
                res = 0;

                for (int i = size - 1; i >= 0; --i)
                {
                    TreeNode node = q.Dequeue();
                    res += node.val;

                    if (node.right != null)
                        q.Enqueue(node.right);
                    if (node.left != null)
                        q.Enqueue(node.left);
                }
            }

            return res;
        }
    }
}
