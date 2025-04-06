using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP2ArbolGenealogico.src.DataStructures
{
    class FamilyTree
    {
        private Node root;

        public FamilyTree()
        {
            root = null;
        }

        public FamilyTree(string name)
        {
            root = new Node(name);
        }

        private Node FindPerson(Node current, string name)
        {
            if (current == null) return null;
            if (current.Name == name)
                return current;

            Node found = FindPerson(current.Father, name);
            if (found != null) return found;

            return FindPerson(current.Mother, name);
        }
    }
}
