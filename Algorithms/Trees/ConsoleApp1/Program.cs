// See https://aka.ms/new-console-template for more information

using System.Transactions;
using Trees;

var node = new Node(1);
Node.Insert(5, node);
Node.Insert(4, node);
Node.Insert(0, node);
Node.Insert(10, node);
Node.Insert(6, node);

//Node.Traverse(node, n => Console.WriteLine(n.Value));


// Binary search tree validation

//     7
//  /     \
//  5      10
// / \     / \
// 4  6   8   11

var brokenBinaryTree = new Node(7);
brokenBinaryTree.Left = new Node(5);
brokenBinaryTree.Left.Left = new Node(4);
brokenBinaryTree.Left.Right = new Node(6);

brokenBinaryTree.Right = new Node(10);
brokenBinaryTree.Right.Left = new Node(8);
brokenBinaryTree.Right.Right = new Node(11);

// this makes the binary tree invalid
//brokenBinaryTree.Right.Left.Left = new Node(1);


Console.WriteLine(Node.ValidateTree(brokenBinaryTree, int.MinValue, int.MaxValue));
