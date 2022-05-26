using System;

namespace Treversals
{
    class Program
    {
      class Node 
        {
            public Node Left {get;set;}
            public Node Right {get;set;}
            public int Data {get;set;}
            
        }
        class BinaryTree {

            public static void preOrderTreversal(Node root)
            {
                if(root == null){
                    return;
                }

                Console.Write(root.Data+" ");
                preOrderTreversal(root.Left);
                preOrderTreversal(root.Right);
            }

             public static void inOrderTreversal(Node root)
            {
                if(root == null){
                    return;
                }

                inOrderTreversal(root.Left);
                Console.Write(root.Data+" ");
                inOrderTreversal(root.Right);
            }
             public static void postOrderTreversal(Node root)
            {
                if(root == null){
                    return;
                }

                postOrderTreversal(root.Left);
                postOrderTreversal(root.Right);
                 Console.Write(root.Data+" ");
            }
        }
        static void Main(string[] args)
        {
                Node rootNode = new Node();
                rootNode.Data =4;

                
                Node nodeOne = new Node();
                nodeOne.Data =1;
                
                Node nodeThree = new Node();
                nodeThree.Data =3;
                
                Node nodeEight = new Node();
                nodeEight.Data =8;

                
                Node nodeNine = new Node();
                nodeNine.Data =9;

                Node nodeSix = new Node();
                nodeSix.Data =6;

                rootNode.Left=nodeOne;
                rootNode.Right=nodeThree;
                nodeOne.Left=nodeEight;
                nodeOne.Right=nodeNine;
                nodeThree.Left=nodeSix;

                BinaryTree.preOrderTreversal(rootNode);
                Console.WriteLine();
                BinaryTree.postOrderTreversal(rootNode);
                Console.WriteLine();
                BinaryTree.inOrderTreversal(rootNode);
                Console.WriteLine();
        }
    }
}
