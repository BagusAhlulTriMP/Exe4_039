using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Node
    {
        public int info;
        public Node next;
        public Node(int i, Node n)
        {
            info = i;
            next = n;
        }
    }

    class Stacks
    {
        Node top;

        public Stacks()
        {
            top = null;
        }
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }

        public void pop()
        {
            Console.WriteLine("\nThe popped element is: " + top.info);
            top = top.next; //Make top point to the next node in sequence
        }

        public void push(int element)
        {
            Node fresh;
            fresh = new Node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + " pushed. ");
        }

        public void display()
        {
            Node tmp;
            if (empty()) //if stack is empty
                Console.WriteLine("\nBagus");
            else
            {
                //Traverse the list from begginning till end
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
                Console.WriteLine();
            }
        }
    }
}
