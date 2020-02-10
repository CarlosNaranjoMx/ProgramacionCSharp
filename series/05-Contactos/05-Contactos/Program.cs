using System;
using System.Collections.Generic;
using Functions;//Importamos nuestras propias funciones

namespace _05_Contactos{
    class Program{
        //Decalaracion del diccionario
        static Dictionary<string,int> dic = new Dictionary<string,int>();
////////////////////////////////////////////////////////////////////////////////

        //Agregar Usuarios
        static void agregar(){
            //Leemos el nombre
            string nombre = Read.ReadString("Ingrese el nombre para agregar: ");
            /* VALIDACION:
            Verificamos que el nombre que queremos agregar no exista*/
            if(dic.ContainsKey(nombre)){
                Print.RedPrint(
                    "Error el nombre ya existe",
                    "Contacto no agregado");
                return;
            }
            //Agregamos el numero al diccionario, con el nombre
            dic[nombre]= Read.ReadInt("Ingrese el numero para agregar: ");
            //Confirmamos que agregamos el usuario
            Print.BluePrint("Contacto Agregado");
        }

        //Eliminar Usuarios
        static void eliminar(){
            //leemos el nombre
            string nombre = Read.ReadString("Ingrese el nombre para eliminar");
            /* VALIDACION:
            Verificamos que el nombre que queremos eliminar exista*/
            if(!dic.Remove(nombre)){
                Print.RedPrint("El nombre no existe en la agenda");
                return;
            }
            //Confirammos que eliminamos al usuario
            Print.BluePrint("Contacto Eliminado");
        }

        //Mostrar usuario
        static void mostrar(){
            string nombre = Read.ReadString("Ingrese el nombre para mostrar:");
            if (!dic.ContainsKey(nombre)){
                Print.RedPrint("Error el nombre no existe");
                return;
            }
            Console.WriteLine($"El contacto {nombre} tiene el numero {dic[nombre]}");

        }
////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args){
            while (true){
                string input = Read.ReadString(
                    "---------Menu---------",
                    "Agregar Contacto..... a",
                    "Eliminar Contacto     e",
                    "Mostrar Contacto..... m",
                    "Salir                 s",
                    "----------------------");
                switch (input[0]){
                    case 'A': 
                    case 'a': agregar();
                       break;
                    case 'E':
                    case 'e': eliminar();
                       break;
                    case 'M': 
                    case 'm': mostrar();
                       break;
                    case 'S':
                    case 's': goto End; //el uso del goto tambien puede hacer menos pesado el codigo
                }
            }
            End:;
            //Console.ReadKey(true); <- al tener un while true no es necesario
        }
    }
}
