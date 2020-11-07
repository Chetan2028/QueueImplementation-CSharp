using System;

namespace QueueImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Queue Implementation");
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Display();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
            linkedListQueue.Dequeue();
            Console.WriteLine();
            linkedListQueue.Display();
        }
    }
}
