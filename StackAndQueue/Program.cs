using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackDemo();
            QueueDemo();
        }
        static void StackDemo()
        {
            Stack<int> s = new Stack<int>(); //LIFO

            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.Push(40);
            s.Push(50);

            Console.WriteLine("Pop:" + s.Pop());
            Console.WriteLine("Pop:" + s.Pop());
            Console.WriteLine("Peek:" + s.Peek());
            Console.WriteLine("Pop:" + s.Pop());
            Console.WriteLine("Peek:" + s.Peek());
            Console.WriteLine("Pop:" + s.Pop());
            Console.WriteLine("Pop:" + s.Pop());


            int len = s.Count;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Pop:" + s.Pop());
            }


            if (s.Count > 0)
            {
                //Console.WriteLine("Pop:" + s.Pop());
            }
            else
            {
                Console.WriteLine("Stack is EMPTY!");
            }
        }
        static void QueueDemo()
        {
            Queue<int> q = new Queue<int>(); //FIFO
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            q.Enqueue(50);


            Console.WriteLine("Dequeue:"+q.Dequeue());
            Console.WriteLine("Peek:" + q.Peek());
            Console.WriteLine("Dequeue:" + q.Dequeue());



            int len =q.Count;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Dequeue:" + q.Dequeue());
            }


            if(q.Count > 0)
            {
                Console.WriteLine("Dequeue:" + q.Dequeue());
            }
            else
            {
                Console.WriteLine("QUEUE is Empty!");
            }
           
        }
    }
}
