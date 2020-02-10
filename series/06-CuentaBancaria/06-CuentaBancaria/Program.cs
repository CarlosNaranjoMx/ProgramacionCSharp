using System;
using Functions; 

namespace _06_CuentaBancaria
{
    public class CuentaBancaria{
        int Saldo {get; set;}
        string Nombre {get; set;}
        public CuentaBancaria(string nombre, int saldo){
            Nombre = nombre;
            Saldo = saldo;
            Console.WriteLine($"La cuenta {nombre} tiene {Saldo}");
        }
        //definicion de los 3 metodos
        public void mostrarInformacion(){
            Console.WriteLine($"El nombre de la cuenta es {Nombre} y el saldo de la cuenta es {Saldo}");
        }
        public void deposito(int cantidad){
            Console.WriteLine($"se agregara ${cantidad} a la cuenta");
            Saldo += cantidad;
            Console.WriteLine($"el saldo final es {Saldo}");
        }
        //definicion del metodo retiro
        public void retiro(int cantidad){
            if(cantidad > Saldo){
                Console.WriteLine("La cantidad a retirar es mayor que el saldo, intente con otra cantidad");
            }else{
                Saldo -= cantidad;
                Console.WriteLine($"El saldo despues del retiro es {Saldo}");
            }
        }        
    }
    class Program{
        static void Main(string[] args){ 
            //Creacion de 2 objetos
            CuentaBancaria cuenta01 = new CuentaBancaria("cuenta01",200);
            CuentaBancaria cuenta02 = new CuentaBancaria("cuenta02",500);
            //llamado de sus metodos
            Console.WriteLine("Llamando al metodo deposito(30) del primer objeto");
            cuenta01.deposito(30);
            Console.WriteLine("Llamando al metodo retiro(30) del segundo objeto");
            cuenta02.retiro(30);
            Console.WriteLine("Llamando al metodo mostrarInformacion() de los dos");
            cuenta01.mostrarInformacion();
            cuenta02.mostrarInformacion();
            Console.ReadKey(true);
        }
    }
}
