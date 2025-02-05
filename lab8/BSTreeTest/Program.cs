﻿using System;
using System.Collections.Generic;
using BinaryTreeLib;
using System.Text;

namespace BSTreeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BST bstree = new BST();
            bstree.Clear();
            bstree.Add(5);
            bstree.Add(7);
            bstree.Add(2);
            bstree.Add(10);
            bstree.Add(21);
            bstree.Add(4);
            bstree.Add(9);
            bstree.Add(15);

            Console.WriteLine("Number of members = {0}", bstree.Count(bstree.Root));
            Console.WriteLine();

            Console.WriteLine("Inorder travel 1st \n");
            InorderTraversal(bstree.Root);
            Console.WriteLine();

            //delete value 
            Console.WriteLine("Inorder travel 2nd >> delete 4 \n");
            bstree.Delete(5);
            InorderTraversal(bstree.Root);
            Console.WriteLine();

            //add value
            Console.WriteLine("Inorder travel 3rd >> add 10 \n");
            bstree.Add(10);
            InorderTraversal(bstree.Root);

            Console.WriteLine("\n");

            if (bstree.Search(10) != null)
                Console.WriteLine("Founded 10 in BST");
            else
                Console.WriteLine("Not Founded 10 in BST");

            Console.WriteLine();

            
            LeftMostTree(bstree.Root);
            RightMostTree(bstree.Root);
            
            Console.ReadLine();
        }
        static void InorderTraversal(Node current)
        {
            if (current != null)
            {
                InorderTraversal(current.Left);
                Console.WriteLine("{0} ", current.Value.ToString());
                InorderTraversal(current.Right);
            }
        }

        static void LeftMostTree(Node current)
        {
            while(current.Left!=null)
                current = current.Left;
            Console.WriteLine("Min: "+current.Value);
        }

        static void RightMostTree(Node current)
        {
            while (current.Right != null)
                current = current.Right;
            Console.WriteLine("Max: " + current.Value);
        }
    }
}
