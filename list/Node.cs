using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class Node 
    {
        internal String data;
        internal Node next;
        internal Node previous;
        
        internal Node(String data)
        {
            this.data = data;
        }
    }
}
