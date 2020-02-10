using System;
using Functions; //Funciones de entrada/salida que manejan exepciones
namespace _01_NaturalSum{
    class Program{
        //usamos la formula de la suma de los primeros numeros
        static int naturalsum(int n) {return ((n * (n + 1)) / 2);}
        static void Main(string[] args){
            int num = Read.ReadInt("Ingrese un numero natural n: ");
            Console.WriteLine($"La suma es {naturalsum(num)}");
            Console.WriteLine("Presione cualquier tecla para salir..."); 
            Console.ReadKey(true);
        }
    }
}
