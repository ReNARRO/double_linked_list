using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_linked_list
{
    class Node
    {
        /*Node class represents the node of doubly linked list.
         It consist of the information part and links to
         its succeefing and preceeding nodes 
         in terms of next and previous nodes.*/
        public int rollNumber;
        public string name;
        // point to the succeding node
        public Node next;
        //point to the precceding node
        public Node prev;
    }
    class DoubleLinkedList
    {
        Node START;
        public DoubleLinkedList()
        {
            START = null;
        }
        public void addNode() //Adds a new node
        {
            int rollNo;
            string nm;
            Console.WriteLine("\nEnter the roll number of the student: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the name of the student: ");
            nm = Console.ReadLine();
            Node newNode = new Node();
            newNode.rollNumber = rollNo;
            newNode.name = nm;

            //Check if the list empty
            if (START == null || rollNo <= START.rollNumber)
            {
                if ((START != null) && (rollNo == START.rollNumber))
                {
                    Console.WriteLine("\nDulpicate number not allowed");
                    return;
                }
                newNode.next = START;
                if (START != null)
                    START.prev = newNode;
                newNode.prev = null;
                START = newNode;
                return;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
