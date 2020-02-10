using System;
using System.Collections.Generic;
using Functions;
using System.Linq;
namespace _12_BecarioMart{
    // Simula el carrito de compras de un Becario
    class BecarioMart{
        /*(1) Crear 2 listas, con nombres y los precios  */
        public List<string> nombres = new List<string>();
        public List<double> precios = new List<double>();
        public double Suma {get; set;}
        public void insert(){
            string nombre = Read.ReadString("Ingrese el nombre del producto:");
            double precio = Read.ReadDouble("Ingrece el precio:");
            nombres.Add(nombre);
            precios.Add(precio);
        }
        //definicion metodo pagar
        public void pagar() {
            double sum = 0;
            Console.WriteLine("\n\n");
            Console.WriteLine("{0,-20} {1,-7}","PRODUCTOS","PRECIOS");
            Console.WriteLine("----------------------------");
            foreach (var producto in nombres.Zip(precios,Tuple.Create)) {
                Console.WriteLine("{0,-20} {1,7}", producto.Item1, $"${producto.Item2}");
                sum += producto.Item2;
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("{0,-20} {1,7}","TOTAL",$"${sum}");
            Console.WriteLine("\n\n");
            Suma = sum;

            switch (Read.ReadString(
                    "-------MENU-------",
                    "comprar..........c",
                    "dejar productos  d")[0])
            {
                case 'c':
                    comprar();
                    break;
                case 'd':
                    dejarproductos();
                    break;
                default:
                    Print.RedPrint("Opcion no soportada");
                    break;
            }
        }
        //definicion metodo comprar
        public void comprar(){
            if(Suma<=500) {Print.BluePrint("Gracias por su compra");}
            else{
                Print.RedPrint("Dinero insuficiente deje productos");
                dejarproductos();
            }    
        }
        //definicion metodo dejarproductos
        public void dejarproductos(){
            Console.WriteLine("--------DEJAR PRODUCTOS--------");
            int i=1;
            foreach (var producto in nombres.Zip(precios,Tuple.Create)) {
                Console.WriteLine("{0,-3} {1,-20} {2,7}",i, producto.Item1, $"${producto.Item2}");
                i++;
            }
            int indice = Read.ReadInt("Ingrese el indice del producto a dejar:");
            if (indice > nombres.Count){
                Print.RedPrint("El indice no existe");
                dejarproductos();
            }else{
                nombres.RemoveAt(indice-1);
                precios.RemoveAt(indice-1);
            }

            pagar();
        }

    }
    class Program{

        static void Main(string[] args){
            BecarioMart carrito = new BecarioMart();
            //definicion del menu
            while (true){
                Print.ArgsPrint(
                    "---------MENU---------",
                    "Llevar producto......i",
                    "pagar                p",
                    "salir................s"
                );

                switch (Read.ReadString()[0]){
                    case 'i': carrito.insert(); break;
                    case 'p': carrito.pagar(); goto End1; 
                    case 's': goto End2;
                    default: Print.RedPrint("Opcion no soportada"); break;
                }
            }
            End1:
            Console.WriteLine("Presione Cualquier tecla para salir");
            Console.ReadKey();
            End2:;
        }
    }
}
