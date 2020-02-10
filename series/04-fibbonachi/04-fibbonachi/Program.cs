using System;
using Functions;
namespace _04_fibbonachi{
    class Program{
        static void fibonacci_print(int n){
            //calculamos fibonacci con variables
            //en cuestion de espacio es constante
            int anterior=0;
            int actual=1;
            int tmp;
            for (int i = 0; i < n; i++){
                Console.WriteLine(anterior);
                tmp = actual;
                actual=actual+anterior;
                anterior=tmp;
            }
        }
        static void Main(string[] args){
            int numero = Read.ReadInt("Ingrese el no. de fibonacci hasta el que desea imprimir:");
            fibonacci_print(numero);//calcula e imprime fibonacci
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
