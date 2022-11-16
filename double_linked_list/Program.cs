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

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
