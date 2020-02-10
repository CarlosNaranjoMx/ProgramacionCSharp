using System;
using System.Text.RegularExpressions;
using Functions; // Manejador de exepciones evita que el programa se muera
namespace _03_Vocales{
    class Program{

        static bool compare(char car){
            //utilizamos una expresion regular para validar si es vocal
            Regex regex = new Regex("[aeiouAEIOU]");
            return regex.IsMatch(Convert.ToString(car));
        }
        static void Main(string[] args){
            string text =Read.ReadString("Ingrese el texto:");
            string result = "";
            foreach (char item in text){
                if(compare(item)){//validamos si es vocal con ese metodo
                    result += 'f';
                }result+= item;
            }
            Console.WriteLine("Su texto procesado es: ");
            Console.WriteLine(result);
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey(true);

        }
    }
}
