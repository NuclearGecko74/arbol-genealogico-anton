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

        public bool AddFather(string childName, string fatherName)
        {
            Node child = FindPerson(root, childName);
            if (child == null) return false;

            if (child.Father != null) return false; // Father already exists

            child.Father = new Node(fatherName);
            return true;
        }

        public bool AddMother(string childName, string motherName)
        {
            Node child = FindPerson(root, childName);
            if (child == null) return false;

            if (child.Mother != null) return false; // Mother already exists

            child.Mother = new Node(motherName);
            return true;
        }

        public (string fatherName, string motherName) GetParents(string childName)
        {
            Node childNode = FindPerson(root, childName);
            if(childNode == null)
            {
                return (null, null);
            }
            string father = childNode.Father?.Name;
            string mother = childNode.Mother?.Name;

            return (father, mother);
        }

        public void PreOrder(Node currentNode)
        {
            Console.WriteLine(currentNode.Name);

            if(currentNode.Father != null)
            {
                PreOrder(currentNode.Father);
            }

            if(currentNode.Mother != null)
            {
                PreOrder(currentNode.Mother);
            }
        }

        public void PreOrder() 
        {
            PreOrder(root);
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
