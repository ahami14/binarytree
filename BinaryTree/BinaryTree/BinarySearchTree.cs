using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinarySearchTree
    {
        //member variables
        

        //constructor
        Node root = null;

        //member methods
        public void Add(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
            }
        }

        private void AddRec(Node root, int data, Node newNode)
        {
            if(root == null)
            {
                root = newNode;
            }
            if(newNode.data < root.data)
            {
                if (root.left == null)
                {
                    root.left = newNode;
                }
                else
                {
                    AddRec(root.left, data, newNode);
                }
            }
            else
            {
                if(root.right == null)
                {
                    root.right = newNode;
                }
                else
                {
                    AddRec(root.right, data, newNode);
                }
            }
        }

        public void Search(Node root)
        {
            if(root == null)
            {
                return;
            }
            Search(root.right);
            Search(root.left);
        }
    }
}
