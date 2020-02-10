using System;
using Functions;
namespace _08_Auto{
    class Auto{
        //Creacion al menos 3 tipos diferentes de atributos
        //Metodos getters y setters para encapsulamiento
        public string Nombre {get; set;}
        public string Marca {get; set;}
        public string Color {get; set;}
        // Creacion del constructor por defecto
        public Auto(){
            Nombre = "Default";
            Marca = "Default";
            Color = "Default";
        }
        //Sobrecarga del constructor
        public Auto(string nombre, string marca, string color){
            Nombre = nombre;
            Marca = marca;
            Color = color;
        }

        public void correr() { 
            Random random = new Random();
            Console.WriteLine(
                "{0,-18} {1:N3} km",
                "El auto recorrio",
                random.NextDouble()
            );
        }
        public void recarga() {
            Random random = new Random();
            Console.WriteLine(
                "{0,-18} {1:N3} litros", 
                "el auto recargo",
                random.NextDouble());
        }
        public void limpieza() {
            Console.WriteLine($"El auto {Nombre} ahora esta limpio");

        }
    }
    class Program{
        static void Main(string[] args){
            //Instanciacion de 3 objetos
            Auto auto01 = new Auto("GLC","Mercedes-Benz","Plata");
            Auto auto02 = new Auto("A1","Audi","Amarillo");
            Auto auto03 = new Auto("Gol","volkswagen","Rojo");
            //Llamando a cada uno de los metodos realizados
            auto01.correr();
            auto02.recarga();
            auto03.limpieza();
            //Uso de los metodos getters y setters
            Console.WriteLine($"El nombre del auto es {auto01.Nombre}");
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey(true);
        }
    }
}
