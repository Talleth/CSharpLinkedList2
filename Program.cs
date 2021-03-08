using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project
{
    class Program
    {
        public static void Main(string[] pArguments)
        {
            LinkedList linkedList = new LinkedList();
            
            linkedList.InsertNodeAtEnd(new Node("Jane"));
            linkedList.InsertNodeAtEnd(new Node("George"));
            linkedList.InsertNodeAtEnd(new Node("Fred"));

            linkedList.InsertNodeAtBeginning(new Node("John"));
        }
    }

    public class LinkedList
    {
        private Node m_head;

        public LinkedList() { }

        public void InsertNodeAtBeginning(Node newNode)
        {
            newNode.Next = this.m_head;

            if (this.m_head != null)
            {
                this.m_head.Previous = newNode;
            }
            this.m_head = newNode;
        }

        public void InsertNodeAtEnd(Node newNode)
        {
            if (this.m_head == null)
            {
                this.m_head = newNode;
            }
            else
            {
                Node tempNode = this.m_head;

                while (tempNode.Next != null)
                    tempNode = tempNode.Next;

                tempNode.Next           = newNode;
                tempNode.Next.Previous  = tempNode;
            }
        }

        public Node Head
        {
            get { return this.m_head; }
        }
    }

    public class Node
    {
        private object  m_data;
        private Node    m_next;
        private Node    m_previous;

        public Node(object data)
        {
            this.m_data     = data;
            this.m_next     = null;
            this.m_previous = null;
        }

        public Node Next
        {
            get { return this.m_next; }
            set { this.m_next = value; }
        }

        public Node Previous
        {
            get { return this.m_previous; }
            set { this.m_previous = value; }
        }
    }
}
