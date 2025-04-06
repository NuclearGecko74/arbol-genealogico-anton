using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP2ArbolGenealogico.src.DataStructures
{
    class FamilyTree
    {
        private Node root; // Raíz del árbol genealógico

        public FamilyTree()
        {
            // Constructor vacío: no se inicializa ningún nodo raíz.
            root = null;
        }

        public FamilyTree(string name)
        {
            // Constructor que crea el árbol con un nodo raíz con el nombre dado.
            root = new Node(name);
        }

        public bool AddFather(string childName, string fatherName)
        {
            // Busca el nodo del hijo para asignarle un padre.
            Node child = FindPerson(root, childName);
            if (child == null) return false;  // El hijo no existe en el árbol.

            if (child.Father != null) return false;  // El nodo ya tiene padre asignado.

            child.Father = new Node(fatherName);
            return true;
        }

        public bool AddMother(string childName, string motherName)
        {
            // Busca el nodo del hijo para asignarle una madre.
            Node child = FindPerson(root, childName);
            if (child == null) return false;  // El hijo no existe en el árbol.

            if (child.Mother != null) return false;  // El nodo ya tiene madre asignada.

            child.Mother = new Node(motherName);
            return true;
        }

        public (string fatherName, string motherName) GetParents(string childName)
        {
            // Obtiene los nombres de los padres del nodo identificado por childName.
            Node childNode = FindPerson(root, childName);
            if (childNode == null)
            {
                return (null, null); // No se encontró el nodo.
            }
            // Se usan operadores null-conditional para acceder a los nombres sin errores.
            string father = childNode.Father?.Name;
            string mother = childNode.Mother?.Name;

            return (father, mother);
        }

        public void PreOrder(Node currentNode)
        {
            // Muestra el nombre del nodo actual.
            Console.WriteLine(currentNode.Name);

            // Recorre recursivamente el subárbol del padre, si existe.
            if (currentNode.Father != null)
            {
                PreOrder(currentNode.Father);
            }

            // Recorre recursivamente el subárbol de la madre, si existe.
            if (currentNode.Mother != null)
            {
                PreOrder(currentNode.Mother);
            }
        }

        public void PreOrder()
        {
            // Inicia el recorrido en preorden desde la raíz.
            PreOrder(root);
        }

        private Node FindPerson(Node current, string name)
        {
            // Busca recursivamente un nodo con el nombre especificado.
            if (current == null) return null;
            if (current.Name == name)
                return current;

            Node found = FindPerson(current.Father, name);
            if (found != null) return found;

            return FindPerson(current.Mother, name);
        }
    }
}

