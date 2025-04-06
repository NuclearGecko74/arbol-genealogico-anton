using EP2ArbolGenealogico.src.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP2ArbolGenealogico.src
{
    internal class Menu
    {
        private FamilyTree familyTree;

        public Menu()
        {
            Console.Write("Ingrese el nombre de la raíz: ");
            string rootName = Console.ReadLine();
            familyTree = new FamilyTree(rootName);
            Console.WriteLine("Árbol Genealógico creado con la raíz: " + rootName);
        }

        public void Start()
        {
            bool exit = false;
            while (!exit)
            {
                PrintMenu();
                string option = Console.ReadLine();
                exit = ProcessOption(option);
                Console.WriteLine();
            }
        }

        private void PrintMenu()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("         ÁRBOL GENEALÓGICO         ");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Agregar padre");
            Console.WriteLine("2. Agregar madre");
            Console.WriteLine("3. Obtener padres");
            Console.WriteLine("4. Mostrar árbol");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
        }

        private bool ProcessOption(string option)
        {
            switch (option)
            {
                case "1":
                    AddFather();
                    break;
                case "2":
                    AddMother();
                    break;
                case "3":
                    ShowParents();
                    break;
                case "4":
                    DisplayPreOrder();
                    break;
                case "5":
                    return true;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
            return false;
        }

        private void AddFather()
        {
            Console.Write("Ingrese el nombre del hijo: ");
            string childName = Console.ReadLine();
            Console.Write("Ingrese el nombre del padre: ");
            string fatherName = Console.ReadLine();
            bool success = familyTree.AddFather(childName, fatherName);
            Console.WriteLine(success ? "Padre agregado correctamente." : "Error al agregar el padre.");
        }

        private void AddMother()
        {
            Console.Write("Ingrese el nombre del hijo: ");
            string childName = Console.ReadLine();
            Console.Write("Ingrese el nombre de la madre: ");
            string motherName = Console.ReadLine();
            bool success = familyTree.AddMother(childName, motherName);
            Console.WriteLine(success ? "Madre agregada correctamente." : "Error al agregar la madre.");
        }

        private void ShowParents()
        {
            Console.Write("Ingrese el nombre del hijo: ");
            string childName = Console.ReadLine();
            var parents = familyTree.GetParents(childName);
            if (parents.fatherName != null || parents.motherName != null)
            {
                Console.WriteLine("Padre: " + parents.fatherName);
                Console.WriteLine("Madre: " + parents.motherName);
            }
            else
            {
                Console.WriteLine("No se encontraron padres.");
            }
        }

        private void DisplayPreOrder()
        {
            Console.WriteLine("Recorrido en Pre Orden:");
            familyTree.PreOrder();
        }
    }
}
