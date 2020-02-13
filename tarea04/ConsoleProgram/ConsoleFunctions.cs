using System;
using System.IO; //Para la lectura de directorios
using ErrorFunctions;

namespace ConsoleFunctions{
    /// <summary>
    /// Clase que implementa metodos de consola:
    /// - show_directories
    /// - touch_file
    /// - change_directory
    /// - move_file
    /// </summary>
    static class MiniConsole{
        /// <summary>
        /// Para este ejercicio el directorio por defecto será mis Documentos
        /// </summary>
        //public static string CurrentPath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        /// <summary>
        /// Muetra los subdirectorios
        /// </summary>
        /// <param name="path">El directorio base del que tomaremos los subdirectorios</param>
        public static void show_directories(string path){
            try{

                Print.BluePrint("DIRECTORIOS:");
                foreach (string dir in Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly))
                    Console.WriteLine(Path.GetRelativePath(path,dir));
                Print.BluePrint("ARCHIVOS:");
                foreach(string file in Directory.GetFiles(path))
                    Console.WriteLine(Path.GetRelativePath(path,file));

            }catch(DirectoryNotFoundException){
                Print.RedPrint("Directorio no encontrado");
            }catch (UnauthorizedAccessException e){
                Console.WriteLine(e.Message);
                Print.RedPrint("No tienes los permisos para ver el directorio");
            }catch (IOException){
                Print.RedPrint("La ruta debe ser un directorio no un archivo");
            }
        }

        /// <summary>
        /// Crea un directorio de acuerdo a la ruta especificada
        /// </summary>
        /// <param name="path"></param>
        /// <param name="directory"></param>
        public static void touch_file(string path,string directory){
            string currentfile = Path.GetFullPath(directory, path);
            try{
                FileStream fs = File.Create(currentfile);
                if (File.Exists(currentfile)) throw new FileExistsException();
            }catch(UnauthorizedAccessException e){
                Console.WriteLine(e.Message);
                Print.RedPrint("No tienes los permisos");
            }catch (DirectoryNotFoundException){
                Print.RedPrint("No se ha encontrado el directorio especificado");
            }catch (IOException e){
                Print.RedPrint(e.Message);
            }catch (FileExistsException){
                Print.BluePrint("El archivo se sobreescribio");
            }
        }

        /// <summary>
        /// Cambia el directorio actual
        /// </summary>
        /// <param name="path"></param>
        /// <param name="directory"></param>
        /// <returns></returns>
        public static string change_directory(string path,string directory){
            string newpath = Path.GetFullPath(directory,path);
            return Directory.Exists(newpath) ? newpath : null;
        }

        /// <summary>
        /// Mueve un archivo a una ubicación y un nombre diferente
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="destiny"></param>
        public static void move_file(string path,string origin,string destiny){
            try{
                string originpath = Path.GetFullPath(origin,path);
                string destinypath = Path.GetFullPath(destiny,path);
                File.Move(originpath,destinypath);
            }catch (DirectoryNotFoundException){
                Print.RedPrint("No se ha encontrado el codigo especificado");
            }catch (UnauthorizedAccessException e){
                Console.WriteLine(e.Message);
                Print.RedPrint("No tienes los permisos");
            }catch (IOException e){
                Print.RedPrint(e.Message);
            }
        }

    }
}