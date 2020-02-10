using System;
using Functions;
//El programa elegira una computadora random
//con ayuda de la interfaz el programa decidira como
//comportarse de acuerdo al tipo de computadora que le toque
namespace _14_Interfaz{
    interface Computer{
        public void write() { }
        public void encender() { }
        public void cargar() { }
    }
    //Implementando Computadora
    class Laptop : Computer {}
    class Desktop : Computer{}
    class Analog : Computer{}
    class Program{
        static void Main(string[] args){
            //creacion de los objetos de prueba
            Laptop laptop = new Laptop();
            Desktop desktop = new Desktop();
            Analog analog = new Analog();
            Computer[] computers = new Computer[3];
            computers[0] = laptop;
            computers[1] = desktop;
            computers[2] = analog;
            Random random = new Random();
            //Darle un trato diferente dependiendo de con que computadora estes trabajando
            switch (computers[random.Next(3)]){
                case Laptop lap: Console.WriteLine("Trabajando con laptop...");
                    break;
                case Desktop des: Console.WriteLine("Trabajando con computadora de escritorio...");
                    break;
                case Analog an: Console.WriteLine("Trabajando con computadora analogica..."); 
                    break;
            }
            Console.WriteLine("Presione cualquier tecla para salir.....");
            Console.ReadKey();
        }
    }
}
