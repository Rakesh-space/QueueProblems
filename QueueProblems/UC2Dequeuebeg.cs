using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueProblems
{
    class UC2Dequeuebeg
    {

        internal Node front;  //declare the Node type variable front
        internal Node rear;   //declare the Node type variable rear

        public UC2Dequeuebeg()
        {
            this.front = null;  //initilize the front value is null
            this.rear = null;   //initilize the rear value is null
        }

        internal void Enqueue(int data) //inserting element from begining
        {
            Node newNode = new Node(data);

            // If queue is empty, then new node is front and rear both  
            if (this.rear == null)
            {
                this.front = this.rear = newNode;
            }
            else
            {
                // Add the new node at the end of queue and change rear  
                this.rear.next = newNode;
                this.rear = newNode;
            }
            Console.WriteLine("{0} inserted into Queue", data);
        }
        internal void Dequeue() //deleting element from begining
        {
            if (this.front == null) //Checking the queue of front in empty or not
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            Node temp = this.front; //front variable assgined to the Node type of temp variable
            this.front = this.front.next; //increment the front variable possition

            if (this.front == null)  //Checking the queue of front in empty or not
            {
                this.rear = null;  //initialize the rear also null
            }

            Console.WriteLine("Item deleted is {0}", temp.data); //display the deleted value front of queue
        }
        internal void display()  //display the element of queue
        {
            if ((front == null) && (rear == null)) //checking the front and rear is null or not
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (front != rear) //untill fornt and rear not equal then pro
            {
                Console.WriteLine("\n{0} front of data in queue", front.data);
                front = front.next;
            }
            if (front == rear) //if front and rear is same possition the display here
            {
                Console.WriteLine("\n{0} front of data queue in same possition ", front.data);
            }

        }
    }
}
