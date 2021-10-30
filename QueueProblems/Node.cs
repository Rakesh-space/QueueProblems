using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueProblems
{
    class Node
    {
        internal int data;
        internal Node next;
        internal Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
}
