using System;
using System.IO;
//Parseo de una tabla desde un archivo de texto
//leemos una tabla desde un archivo de texto y escribimos su salida
//en terminal y en otro archivo de texto (salida)
//uso del manejo de cadenas con split
namespace _18_Archivos{

    class Tabla{
        public string[][] matriz { get; set; }
        public int N;
        public int M;
        public Tabla(string[][] tabla,int n, int m)
        {
            matriz = tabla;
            N = n;
            M = m;
        }
        //formato de impresion de la tabla
        public override string ToString(){
            string result = "";
            for (int i = 0; i < N; i++) {
                result += "[";
                for (int j = 0; j < M; j++){
                    if (j < M-1 ) result += $"{matriz[i][j]},";
                    else result += $"{matriz[i][j]}";
                }result+="]\n";
            }return result;
        }
    }
    class Program{
        static void Main(string[] args){
            //lectura del archivo
            string text = File.ReadAllText("tabla.csv");
            string[] lineas = text.Split("\n");
            int size = lineas.Length;
            //ejemplo columnas que podria tener la tabla
            string[] columna1 = new string[size];
            string[] columna2 = new string[size];
            string[] columna3 = new string[size];

            string[][] matrix = { columna1, columna2, columna3 };

            string[] arrlinea;
            int j = 0;
            foreach (string linea in lineas){
                arrlinea = linea.Split(","); 
                int i = 0;
                foreach(string palabra in arrlinea){
                    matrix[i][j] = palabra;
                    i++;
                }j++;
            }
            //creacion del objeto tabla con lo que parseamos
            Tabla tabla = new Tabla(matrix,3,2);
            Console.WriteLine("El parseo de la Tabla es");
            Console.WriteLine($"{tabla}");
            File.WriteAllText("salida", $"{tabla}");
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}
