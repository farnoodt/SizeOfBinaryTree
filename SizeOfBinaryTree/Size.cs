using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SizeOfBinaryTree
{
    class Size
    {
        public int SizeOfTree(Node root)
        {
            int right = 0;
            int left = 0;
            if (root == null)
                return 0;
            left = SizeOfTree(root.left);
            right = SizeOfTree(root.right);

            return left + right + 1;
        }
    }
}
