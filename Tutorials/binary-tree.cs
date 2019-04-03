//Binary tree implementation

using System;

public class Node
{
	public int data;
	public Node leftNode;
	public Node rightNode;

	public Node(int val)
	{
		data = val;
		leftNode = null;
		rightNode = null;
	}

}

public class Tree
{
	public void insertNode(ref Node node, int val)
	{
		if(node == null)
		{
		    node = new Node(val);
		}
		else
		{
		    if(val < node.data)
				insertNode(ref node.leftNode, val);
			else if(val > node.data)
				insertNode(ref node.rightNode, val);
		}
	}
	
	public void displayTree(Node node)
	{
		if(node == null)
		{
		    return;
		}
		
		Console.WriteLine(node.data);
		displayTree(node.leftNode);
		displayTree(node.rightNode);
	}
}

public class DefaultClass
{
	
	public static void Main()
	{
	    Node RootNode = null;
	    Tree tr = new Tree();
	    
		tr.insertNode(ref RootNode, 2);
		tr.insertNode(ref RootNode, 1);
		tr.insertNode(ref RootNode, 3);
		tr.insertNode(ref RootNode, 4);
		tr.insertNode(ref RootNode, 5);
		
		
		tr.displayTree(RootNode);
		Console.ReadLine();
	}
}
