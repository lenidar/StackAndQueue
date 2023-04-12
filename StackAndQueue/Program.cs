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
            Stack<int> numStack = new Stack<int>();
            Queue<int> numQueue= new Queue<int>();
            int temp = 0;
            Random rnd = new Random();

            for(int x = 0; x < 5; x++)
            {
                temp = rnd.Next(100);
                numStack.Push(temp);
                numQueue.Enqueue(temp);

                Console.WriteLine("The stack has {0} things...", numStack.Count());
                Console.WriteLine("The queue has {0} things...", numQueue.Count());

                Console.WriteLine("The top of the stack is {0}...", numStack.Peek());
                Console.WriteLine("The front of the queue is {0}...", numQueue.Peek());
            }

            Console.WriteLine("\n\n");

            while (numStack.Count() > 0)
            {
                Console.WriteLine("The top of the stack is {0}...", numStack.Peek());
                Console.WriteLine("The front of the queue is {0}...", numQueue.Peek());

                Console.WriteLine("Removed from the stack is {0}...", numStack.Pop());
                Console.WriteLine("Removed from the queue is {0}...", numQueue.Dequeue());

                Console.WriteLine("The stack has {0} things...", numStack.Count());
                Console.WriteLine("The queue has {0} things...", numQueue.Count());
            }

            Console.ReadKey();
        }
    }
}
