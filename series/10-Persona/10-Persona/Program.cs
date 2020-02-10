using System;
using Functions;

namespace _10_Persona{
    /*(1) Realiza Una clase persona con los atributos, nombre, edad,estatura y peso*/

    class Persona{
        public string Nombre {get; set;}
        public int Edad {get; set;}
        public decimal Estatura {get; set;}
        public decimal Peso {get; set;}

        public Persona(string nombre, int edad, decimal estatura, decimal peso){
            Nombre = nombre;
            Edad = edad;
            Estatura = estatura;
            Peso = peso;
        }
        /*(3) Crea algunos metodos */
        public void crecer(){
            Edad++;
            Estatura+=0.10m;
        }
        public void engordar(){Peso+=5m;}
        public void adelgazar(){
            Peso-=5m;
            Peso=Peso<0?0:Peso;
        }
    }

    class Program{
        static void Main(string[] args){
            /*(2) El usuario ingresara los datos de la persona */
            string nombre = Read.ReadString("Ingrese el nombre de la persona: ");
            int edad = Read.ReadInt("Ingrese la edad de la persona: ");
            decimal estatura = Read.ReadDecimal("Ingrese la estatura de la persona (m): ");
            decimal peso = Read.ReadDecimal("Ingrese el peso de la Persona: (Kg) ");
            Persona persona = new Persona(nombre,edad,estatura,peso);
            /*(4) Manda a llamar los metodos en una clase principal */
            Console.WriteLine($"Llamando al metodo crecer()..."); persona.crecer();
            Console.WriteLine($"Ahora la edad de la persona es '{persona.Edad}'");
            Console.WriteLine($"Ahora la estatura de la persona es {persona.Estatura}m");
            Console.WriteLine($"Llamando al metodo engordar()..."); persona.engordar();
            Console.WriteLine($"La persona '{persona.Nombre}' ahora pesa {persona.Peso} kg");
            Console.WriteLine($"Llamando al metodo adelgazar()..."); persona.adelgazar();
            Console.WriteLine($"Ahora la persona pesa {persona.Peso} kg");
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey(); 
        }
    }
}
