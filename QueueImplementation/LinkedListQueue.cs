using System;
using System.Collections.Generic;
using System.Text;

namespace QueueImplementation
{
    class LinkedListQueue
    {
        //Rear is used to enqueue and front is to dequeue
        Node front;
        Node rear;

        /// <summary>
        /// Prevents a default instance of the <see cref="LinkedListQueue"/> class from being created.
        /// </summary>
        public LinkedListQueue()
        {
            this.front = null;
            this.rear = null;
        }
        /// <summary>
        /// Enqueues the specified new data.
        /// </summary>
        /// <param name="newData">The new data.</param>
        public void Enqueue(int newData)
        {
            Node newNode = new Node(newData);
            // If queue is empty, then new node is front and rear both
            if (rear == null)
            {
                this.front = this.rear = newNode;
                return;
            }

            // Add the new node at the end of queue and change rear
            this.rear.next = newNode;
            this.rear = newNode;
        }
        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            if (this.front == null && this.rear == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Node temp = front;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
