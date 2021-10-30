using System;

namespace QueueProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n UC1QueueProblem :");
            UC1CreateQueue queueProblem = new UC1CreateQueue();
            queueProblem.Enqueue(56);
            queueProblem.Enqueue(30);
            queueProblem.Enqueue(70);
            queueProblem.display();
        }
    }
}
