using System;
using System.Reflection;
//Investigacion
//Abs - calcula el valor absoluto
//Cos,Sin,Tan - calcula funciones trigonometricas
//Pow - eleva un numero a un exponente
//Floor - obtiene el piso de un decimal
//Log10 - obtiene el logaritmo base 10 de un numero
//Min - obtiene el minimo entre 2 numeros
//Max - obtiene el maximo entre 2 numeros
//Round - obtiene solo el numero de digitos que se le indica

namespace _09_Math{

    class Circulo{
        //Declaracion de atributos
        double Radio { get; set; }
        double Diametro {get; set;}
        double Perimetro {get; set;}
        double Area {get; set;}
        public Circulo(double radio){
            Radio = radio;
            //Uso de la funcion sin y la funcion asin
            //para que ambas funciones se canclen a si mismas
            Diametro = Math.Asin(Math.Sin(2 * Radio));
            Perimetro = Math.PI * Diametro;
            //Uso de la funcion Pow
            Area = Math.Pow(Radio,2)*Math.PI;
        }

    }

    class Triangulo{
        double Base { get; set; }
        double Altura { get; set;  }
        double Area;

        public Triangulo(double @base, double altura){
            Base = @base;
            Altura = altura;
            //ahora usamos cos y acos de Math
            Area = Math.Acos(Math.Cos(@base*altura));
        }

    }
    class Program{
        static void Main(string[] args){
        
        }
    }
}
