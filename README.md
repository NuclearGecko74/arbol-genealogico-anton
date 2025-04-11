# Árbol Genealógico en C#

Este proyecto es una implementación en C# de un árbol genealógico, que permite crear nodos con un nombre, asignar padres (padre y madre) y recorrer el árbol en preorden. El proyecto se organiza en varias clases que cumplen diferentes funciones:

- **Node**: Representa cada nodo del árbol y almacena el nombre, el padre y la madre.
- **FamilyTree**: Administra la estructura del árbol, permitiendo agregar padres y obtener información del árbol.
- **Menu**: Proporciona una interfaz de línea de comandos para interactuar con el árbol genealógico.
- **Program**: Contiene el método `Main` que inicia la ejecución del programa.

## Contenido del Proyecto

- **EP2ArbolGenealogico.src.DataStructures**
  - `Node.cs`: Clase que define la estructura de un nodo del árbol.
  - `FamilyTree.cs`: Clase que maneja la lógica de creación y manipulación del árbol genealógico.
- **EP2ArbolGenealogico.src**
  - `Menu.cs`: Interfaz interactiva (por consola) para el usuario.
- **EP2ArbolGenealogico**
  - `Program.cs`: Punto de entrada de la aplicación.

## Características

- Creación dinámica de un árbol genealógico a partir de una raíz.
- Adición de un padre y una madre para un nodo específico.
- Obtención de los nombres de los padres de un nodo.
- Recorrido en preorden para mostrar la estructura del árbol.

## Requisitos Previos

- [.NET Framework](https://dotnet.microsoft.com/) o [.NET Core](https://dotnet.microsoft.com/download) instalado en tu máquina.
- Conocimientos básicos de programación en C#.

## Uso
Al iniciar la aplicación, se te pedirá que ingreses el nombre de la raíz del árbol. Posteriormente, se desplegará un menú interactivo con las siguientes opciones:

- Agregar padre: Ingresa el nombre del hijo y el nombre del padre que se asociará.
- Agregar madre: Ingresa el nombre del hijo y el nombre de la madre que se asociará.
- Obtener padres: Proporciona el nombre del hijo y se mostrarán los nombres de sus padres (si han sido asignados).
- Mostrar árbol: Se realiza un recorrido en preorden para mostrar los nombres de todos los nodos.
- Salir: Finaliza la ejecución del programa.
