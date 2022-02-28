using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class LinkedListIterator
    {
        private Node currentNode;

        internal LinkedListIterator(Node startNode)
        {
            currentNode = startNode;
        }

        public Boolean hasNext()
        {
            return currentNode != null;
        }

        public String next()
        {
            String data = currentNode.data;

            currentNode = currentNode.next;

            return data;
        }
    }
}
