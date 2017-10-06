using System;

public class LinkedList 
{
	class Node 
	{ 
		internal int value; 
		internal Node next; 
		public Node( int v, Node n) 
		{ 
			value = v; 
			next = n; 
		}
		public Node(int v) 
		{
			value = v; 
			next = null; 
		} 
	}
	
	private Node head; 
	private int count = 0;
	// Other Methods. 
	public int size() 
	{ 
		return count; 
	}

	public bool Empty 
	{ 
		get { return count == 0; } 
	}

	public void addHead(int value) 
	{ 
		head = new Node(value, head); 
		count++; 
	}

	public void addTail(int value) 
	{ 
		Node newNode = new Node(value, null); 
		Node curr = head;
		if (head==null) 
			head = newNode; 
		while (curr.next != null) 
			curr = curr.next; 

		curr.next = newNode; 
		count++; 
	}

	public void print() 
	{ 
		Node temp = head; 
		while (temp != null) 
		{ 
			Console.Write( temp.value + " "); 
			temp = temp.next; 
		} 
	}

}

public class Program
{
	public static void Main(string[] args) 
	{ 
		LinkedList ll = new LinkedList(); 
		ll.addHead(1); 
		ll.addHead(2); 
		ll.addHead(3); 
		ll.print(); 
	}
}