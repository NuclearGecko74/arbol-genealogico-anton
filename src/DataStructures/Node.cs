using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP2ArbolGenealogico.src.DataStructures
{
    class Node
    {
        private string name;
        private Node dad, mom;

        public Node(string name)
        {
            this.name = name;
            this.dad = null;
            this.mom = null;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Node Father
        {
            get { return dad; }
            set { dad = value; }
        }

        public Node Mother
        {
            get { return mom; }
            set { mom = value; }
        }
    }
}
