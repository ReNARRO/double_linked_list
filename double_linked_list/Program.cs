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
            Node previous, current;
            for (current = previous = START; current != null && rollNo >= current.rollNumber; previous = current, current = current.next)
            {
                if (rollNo == current.rollNumber)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                    return ;
                }

            }
            //On the execution of the above for loop, prev and
            //current will point to those nodes
            //between which the new node is to be inserted
            newNode.next = current;
            newNode.prev = previous;

            //If the node is to be inserted at the end of the list.
            if(current == null)
            {
                newNode.next = null;
                previous.next = newNode;
                return ;
            }
            current.prev = newNode;
            previous.next = newNode;
        }
        //Checks wheteher the specified node is present
        public bool Search(int rollNo, ref Node previous, ref Node current)
        {
            for (previous = current = START; current != null && rollNo != current.rollNumber; previous = current, current = current.next) 
            { }
            //The above for loop tranverse the list. If the specified node
            //is found then the function returns true, otherwise false.
            return (current != null);
        }
        //Deletes the specified node
        public bool delNode(int rollNo)
        {
            Node previous, current;
            previous = current = null;
            if (Search(rollNo, ref previous, ref current) == false)
                return false;
            //If the first node is to be deleted
            if (current == START)
            {
                START = START.next;
                if (START != null)
                    START.prev = null;
                return true;
            }
            //If the last node is to be deleted
            if (current.next == null)
            {
                previous.next = null;
                return true;
            }
            //If the node to be deleted is in between the list then the
            //following lines of code is executed.           
            previous.next = current.next;
            current.next.prev = previous;
            return true;
        }
        //Tranverse the list
        public void traverse()
        {
            if (listEmpty())
            {
                Console.WriteLine("\nList is empty");
            }
            else
            {
                Console.WriteLine("\nRecords in the ascending order of" + 
                    "roll numbers are: \n");
                Node currentNode;
                for (currentNode = START; currentNode != null;
                    currentNode = currentNode.next)
                    Console.Write(currentNode.rollNumber + ""
                        + currentNode.name + "\n");
            }
        }
        //Tranverses the list in the reverse direction
        public void revtraverse()
        {
            if (listEmpty())
                Console.WriteLine("\nList in empty");
            else
            {
                Console.WriteLine("\nRecords in the descending order of" +
                    "roll numbers are: \n");
                Node currentNode;
                for (currentNode = START; currentNode.next != null;
                    currentNode = currentNode.next) 
                { }
                while (currentNode != null)
                {
                    Console.Write(currentNode.rollNumber + "" 
                        + currentNode.name + "\n");
                    currentNode = currentNode.prev;
                }
            }
        }
        public bool listEmpty()
        {
            if(START == null)
                return true;
            else
                return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
