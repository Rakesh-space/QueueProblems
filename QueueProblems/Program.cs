using System;

namespace QueueProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n UC2QueueProblem :");
            UC2Dequeuebeg queueProblem = new UC2Dequeuebeg();
            queueProblem.Enqueue(56);
            queueProblem.Enqueue(30);
            queueProblem.Enqueue(70);
            queueProblem.Dequeue();
            queueProblem.display();
        }
    }
}
