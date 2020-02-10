using System;
using Functions;
using System.Collections.Generic;
//Ejemplo de las 4 propiedades de la programacion oo
//Se implementara la clase directorio, con 2 tipos de directorio
//al final se recorreran todos los directorios
//deacuerdo al directorio que toque se mostrara una informacion diferente
//Abstraccion: Decimos que los entes que guardan informacion y otros directorios son directorios
//Polimorfismo: De acuerdo al tipo de directorio se mostrara diferente informacion
//Herencia: Los tipos raiz y hoja son una clase de directorio
//Encapsulamiento: Modelar directorios como clases
namespace _17_Libre{
    //creacion de la clase abstracta directorio
    public abstract class Directory{
        public string Info ;
        public Directory[] Dir;
    }
    //implementacion de la clase abstracta directorio
    class Root:Directory{}
    class Leaf:Directory{}
    class Program{
        static void Main(string[] args){
            //creacion de la lista de directorios
            List<Directory> ld = new List<Directory>();
            //creacion del directorio raiz
            Directory root = new Root();
            ld.Add(root);
            root.Dir = new Directory[10];
            //llenado de la lista y de los hijos del directorio como ejemplo
            for (int i = 0; i < 10; i++){
                Directory leaf= new Leaf();
                leaf.Info = $"{i}";
                root.Dir[i] = leaf;
                ld.Add(leaf);
            }
            //recorrido de todos los directorios de la lista
            while (ld.Count > 0){
                switch(ld[0]){
                    //cada directorio toma acciones diferentes
                    case Leaf l:
                        Console.WriteLine("Directorio de tipo Hoja");
                        Console.WriteLine($"Numero de hoja {l.Info}");
                        break;
                    case Root r:
                        Console.WriteLine("Directorio de tipo Raiz");
                        break;
                }
                ld.RemoveAt(0);
            }
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        
        }
    }
}
