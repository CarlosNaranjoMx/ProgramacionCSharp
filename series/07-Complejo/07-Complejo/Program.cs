using System;
using Functions;
namespace _07_Complejo{
    class Complejo{
        //definicion de atributos
        int Real {get; set;}
        int Imaginaria {get; set;}

        public Complejo(int real, int imaginaria){
            Real = real;
            Imaginaria = imaginaria;
        }
        //sobrecarga de la suma
        public static Complejo operator +(Complejo c1,Complejo c2){
            return new Complejo(c1.Real+c2.Real,c1.Imaginaria+c2.Imaginaria);
        }

        public override string ToString(){
            string complejo;
            if(Imaginaria==0){
                complejo = $"Complejo({Real})";
            }else if(Imaginaria>0){
                complejo = $"Complejo({Real}+{Imaginaria}i)";
            }else{
                complejo = $"Complejo({Real}-{Imaginaria}i)";
            }return complejo;
        }

        public void imprimir(){
            Console.WriteLine(this);
        }
    }
    class Program{
        static void Main(string[] args){
            //creamos 2 complejos de prueba
            Complejo c1 = new Complejo(1,2);
            Complejo c2 = new Complejo(3,4);
            //Probamos el metodo suma que definimos
            Console.WriteLine($"la suma de los complejos es {c1+c2}");
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
