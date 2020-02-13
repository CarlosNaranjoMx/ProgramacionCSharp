using System;
using ErrorFunctions;
using ConsoleFunctions;
/// <summary>
/// Archivo Principal de Ejecución de la aplicacion "MiniConsola"
/// </summary>
namespace ConsoleProgram{
    /// <summary>
    /// Clase que contiene al metodo Main
    /// </summary>
    class Program{

        static void Main(string[] args){
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            /* Usamos Trim para quitarle los espacios al inicio y Split para
            guardar cada uno de los argumentos  */
            string history = "";
            while(true){
                Console.Write($"{path}>");
                string readcommand = Read.ReadString();
                history += readcommand+"\n";
                string[] commands = readcommand.Trim().Split();
                int no_commands = commands.Length;

                string directory;
                switch (commands[0].ToLower()){
                    case "dir":
                        directory = no_commands > 1 ? commands[1] : path;
                        MiniConsole.show_directories(directory);
                        break;
                    case "cd":
                        directory = no_commands > 1 ? commands[1] : path;
                        string cd = MiniConsole.change_directory(path, directory);
                        path = cd==null?path:cd;
                        break;
                    case "touch":
                        if (no_commands > 1 ) MiniConsole.touch_file(path,commands[1]);
                        else Print.RedPrint("Argumentos induficientes");
                        break;
                    case "move":
                        if(no_commands > 2) MiniConsole.move_file(path,commands[1],commands[2]);
                        else Print.RedPrint("Argumentos Insuficientes");
                        break;
                    case "history": Console.WriteLine(history);break;
                    case "cls": Console.Clear(); break;
                    case "exit": goto End;
                    default: Print.RedPrint("Opcion no soportada"); break;
                }
            }End:;
        }
    }
}
// En caso de que no se quiera el directorio Documents por defecto
// Usar este fragmento para obtener el directorio actual
// public string str_directory = Environment.CurrentDirectory.ToString();