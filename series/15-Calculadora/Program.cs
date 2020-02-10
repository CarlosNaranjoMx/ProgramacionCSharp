using System;
using Functions; //Nos ayudara al manejo de exepciones
namespace _15_Calculadora{

    static class Calculadora{
        //Definicion de los 4 metodos de la calculadora
        public static void suma(){
            double n1 = Read.ReadNegativeDouble("Ingrese el valor del primer dato:");
            double n2 = Read.ReadNegativeDouble("Ingrese el valor del segundo dato:");
            Console.WriteLine($"El resultado es {n1+n2}");
        }
        public static void resta(){
            double n1 = Read.ReadNegativeDouble("Ingrese el valor del primer dato:");
            double n2 = Read.ReadNegativeDouble("Ingrese el valor del segundo dato:");
            Console.WriteLine($"El resultado es {n1-n2}");
        }
        public static void multiplicacion(){
            double n1 = Read.ReadNegativeDouble("Ingrese el valor del primer dato:");
            double n2 = Read.ReadNegativeDouble("Ingrese el valor del segundo dato:");
            Console.WriteLine($"El resultado es {n1*n2}");
        }
        public static void division(){
            double n1 = Read.ReadNegativeDouble("Ingrese el valor del primer dato:");
            double n2 = Read.ReadNegativeDouble("Ingrese el valor del segundo dato:");
            try{
                if(n2==0) throw new NoDivisionCeroException();
            }catch(NoDivisionCeroException){
                Print.RedPrint("No se puede dividir entre Cero");
                division();
            }
            Console.WriteLine($"El resultado es {n1/n2}");
        }
    }
    class Program{
        static void Main(string[] args){
            //Definicion del menu
            while(true){
                switch(
                    Read.ReadString(
                    "-------MENU-------",
                    "suma             s",
                    "resta............r",
                    "multiplicacion   m",
                    "division.........d",
                    "salir            e"
                    )[0]
                ){
                    case 'S':
                    case 's': Calculadora.suma(); break;
                    case 'R':
                    case 'r': Calculadora.resta(); break;
                    case 'M':
                    case 'm': Calculadora.multiplicacion(); break;
                    case 'D':
                    case 'd': Calculadora.division(); break;
                    case 'E':
                    case 'e':goto End;
                    default: Print.RedPrint("Opcion no soportada"); break;
                }
            } End:;
        }
    }
}
