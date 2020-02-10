using System;
using Functions;
namespace _02_multiplos{
    class Program{

        static bool contains(int numero, int n1, int n2){
            int modulo;
            //log10+1 nos da el numero de digitos de un numero
            for (int i = 0; i < Math.Log10(n1)+1; i++){
                modulo = numero%10;
                numero = numero/10;
                if(n1==modulo || n2==modulo) return true;
            }return false;
        }
        static void Main(string[] args){
            int tmp_n1 = Read.ReadInt("Ingrese el Numero 1: ");
            int tmp_n2 = Read.ReadInt("Ingrese el numero 2:");
            for (int i = 0; i < 100; i++){
                //verificamos las 3 condiciones que se nos piden
                if(i%tmp_n1==0 || i%tmp_n2==0 || contains(i,tmp_n1,tmp_n2)){
                    Console.WriteLine("clap");
                }else{
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Presione cualquier tecla para salir..."); 
            Console.ReadKey(true);
        }
    }
}
