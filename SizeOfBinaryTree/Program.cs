using System;

namespace SizeOfBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node tree = new Node(20);
            tree.left = new Node(15);
            tree.left.left = new Node(10);
            tree.left.right = new Node(17);
            tree.right = new Node(30);

            Size s = new Size();
            Console.WriteLine(s.SizeOfTree(tree));
            Console.ReadLine();
        }
    }
}
