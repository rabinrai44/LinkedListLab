using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    //Non-Generic LinkedList
   public class LinkedList
    {
        public LinkedList()
        {
            Head = new Node();
            Current = Head;
        }

        public Node Head;
        public Node Current;
        public int Count = 0;

        public void AddAtStart(object value)
        {
            var newNode = new Node()
            {
                Value = value
            };
            newNode.Next = Head.Next;
            Head.Next = newNode;
            ++Count;
        }

        public void RemoveFromStart()
        {
            if (Count <= 0)
            {
                throw new Exception("There are no elements to remove");
            }

            Head.Next = Head.Next.Next;
            --Count;
        }

        //Method that remove the Node if user give any specific index value
        public bool RemoveAt(int index)
        {
            List<LinkedList> list = new List<LinkedList>();

            if (list.Count < index && list.Count > index)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public void PrintAllNodes()
        {
            Console.Write("Head -> ");
            Node curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value); //If using a reference type (any class/interface), you will need to override ToString for this to work.
                Console.Write(" -> ");
            }
            Console.Write("NULL");
            Console.WriteLine();
        }

        //ReverseAllNode
        public void PrintReverse(LinkedList linkedList)
        {
            LinkedListNode start = linkedList.Head;
            LinkedListNode temp = null;
            Console.Write("Head -> ");
            Node curr = Head;
            while (start != null)
            {
                temp = start.Next;
                start.Next = start.Previous;
                start.Previous = temp;

                if (start.Previous == null)
                {
                    linkedList.Head = start;
                }

                start = start.Previous;
                Console.Write(curr.Value); //If using a reference type (any class/interface), you will need to override ToString for this to work.
                Console.Write(" -> ");
            }
            Console.Write("NULL");
            Console.WriteLine();
        }


    }

    //Linked List using Generics
    class LinkedList<T> where T : class
    {
        public LinkedList()
        {
            Head = new Node<T>();
            Current = Head;
        }
        public Node<T> Head;
        public Node<T> Current;
        public int Count = 0;

        public void AddAtStart(T value)
        {
            var newNode = new Node<T>()
            {
                Value = value
            };
            newNode.Next = Head.Next;
            Head.Next = newNode;
            ++Count;
        }

        public void RemoveFromStart()
        {
            if (Count <= 0)
            {
                throw new Exception("There are no elements to remove");
            }

            Head.Next = Head.Next.Next;
            --Count;
        }

        //Method that remove the Node if user give any specific index value
        public bool RemoveAt(int index)
        {
            List<LinkedList> list = new List<LinkedList>();
            
            if (list.Count < index && list.Count > index)
            {
                return false;
            }
            else
            {
                return true;
            }
             
        }

        //Method that insert the Node if user give a specific index value
        //public bool InsertAt(int index, object o, Node start)
        //{
        //   Node current = start;
        //    for(int i = 0; i < index; i++)
        //    {
        //        current = current.Next;
        //    }

        //    Node next = current.Next;

        //    current.Next = new Node() { }

        //}


        public void PrintAllNodes()
        {
            Console.Write("Head -> ");
            Node<T> curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write(" -> ");
            }
            Console.Write("NULL");
            Console.WriteLine();
        }
    }

    
    
}
