using System;
using System.Collections.Generic;

namespace Complete_Binary_Tree_Construct
{
    class Program
    {
        public class Node
        {
            public int data;
            public Node left;
            public Node right;
            public Node(int value)
            {
                data = value;
                left = null;
                right = null;
            }
        }
        public class CompleteBinaryTree
        {
            Node root;
            Queue<Node> nodes = new Queue<Node>();
            public CompleteBinaryTree()
            {
                root = null;
               
            }
            public void Insert(int value)
            {
                Node newNode = new Node(value);
                nodes.Enqueue(newNode);
                nodes.Enqueue(newNode);

                if (root == null)
                {
                    root = newNode;
                    return;
                }
                   
                Node tempNode = nodes.Dequeue();
                if (tempNode.left == null)
                {
                    tempNode.left = newNode;
                    return;
                }
                else
                {
                    tempNode.right = newNode;
                    return;
                }
            }
            public void Print()
            {
                //BFS algorithm

                if(root == null)
                {
                    Console.WriteLine("Empty.");
                }
                else
                {
                    Queue<Node> inputNode = new Queue<Node>();
                    inputNode.Enqueue(root);

                    while (inputNode.Count > 0)
                    {
                        Node outputNode = inputNode.Dequeue();
                        Console.WriteLine(outputNode.data);

                        if (outputNode.left != null)
                        {
                            inputNode.Enqueue(outputNode.left);
                        }
                        if (outputNode.right != null)
                        {
                            inputNode.Enqueue(outputNode.right);
                        }

                    }


                }
            }
        }
        static void Main(string[] args)
        {
            CompleteBinaryTree cbt = new CompleteBinaryTree();
            cbt.Insert(100);
            cbt.Insert(2);
            cbt.Insert(3);
            cbt.Insert(4);
            cbt.Print();
            Console.ReadKey();

        }
    }
}
