using System;
/// <summary>
/// Conjunto de funciones auxiliares para el manejo de errores, al recibir entradas
/// y al indicarle al usuario el tipo de error.
/// </summary>
namespace ErrorFunctions{
////////////////////////////////// EXCEPCIONES /////////////////////////////////
    class NegativeException:Exception{public NegativeException():base(){}}
    class NoValidMatrixException:Exception{public NoValidMatrixException():base(){}}
    class NoDivisionCeroException:Exception{public NoDivisionCeroException():base(){}}
    class FileExistsException : Exception { }
///////////////////////////////// FORMAT PRINT /////////////////////////////////
    static class Print{
        public static void ArgsPrint(params string[] args){
            foreach(string arg in args) Console.WriteLine(arg);
        }
        public static void RedPrint(params string[] args){
            foreach (string arg in args){
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(arg);
                Console.ResetColor();
            }
        }
        public static void BluePrint(params string[] args){
            Console.BackgroundColor = ConsoleColor.Blue;
            foreach (string arg in args){
                Console.WriteLine(arg);
            }Console.ResetColor();
        }

    }
////////////////////////////////// FORMAT READ /////////////////////////////////
    static class Read{
        public static string ReadString(params string[] args){
            while(true){
                foreach(string arg in args) Console.WriteLine(arg);
                string str = Console.ReadLine();
                try{
                    if (str.Length == 0) throw new NullReferenceException();
                    return str;
                }catch(NullReferenceException){Print.RedPrint("Ingresar una cadena no vacia");}
            }
        }
        /*- Valida que la entrada sea un entero
          - Valida que la entrada no sea un negativo*/
        public static int ReadInt(params string[] args)
        {
            while(true){
                foreach(string arg in args) Console.WriteLine(arg);
                try{
                    string str = Console.ReadLine();
                    if (str.Length > Math.Log10(double.MaxValue) + 1)
                        throw new OverflowException();
                    int num = Convert.ToInt32(str);
                    if (num < 0) throw new NegativeException();
                    return num;  
                }catch(FormatException){
                    Print.RedPrint("Error ingrese una entero valido");
                }catch(NegativeException){
                    Print.RedPrint("Error ingrese una entero no negativo");
                }catch (OverflowException){
                    Print.RedPrint("Error el double es demasiado grande");
                }
            }
        }

        public static decimal ReadDecimal(params string[] args){
            while(true){
                foreach(string arg in args) Console.WriteLine(arg);
                try{
                    string str = Console.ReadLine();
                    if (str.Length > Math.Log10(double.MaxValue) + 1)
                        throw new OverflowException();
                    decimal dec = Convert.ToDecimal(str); 
                    if (dec < 0) throw new NegativeException();
                    return dec;  
                }catch(FormatException){
                    Print.RedPrint("Error ingrese una decimal valido");
                }catch(NegativeException){
                    Print.RedPrint("Error ingrese una decimal no negativo");
                }catch (OverflowException){
                    Print.RedPrint("Error el double es demasiado grande");
                }
            }
        }

        public static decimal ReadNegativeDecimal(params string[] args){
            while(true){
                foreach(string arg in args) Console.WriteLine(arg);
                try{
                    string str = Console.ReadLine();
                    if (str.Length > Math.Log10(double.MaxValue) + 1)
                        throw new OverflowException();
                    return Convert.ToDecimal(str);  
                }catch(FormatException){
                    Print.RedPrint("Error ingrese una decimal valido");
                }catch (OverflowException){
                    Print.RedPrint("Error el double es demasiado grande");
                }
            }
        }

        public static double ReadDouble(params string[] args){
            while(true){
                foreach(string arg in args) Console.WriteLine(arg);
                try{
                    string cadena = Console.ReadLine();
                    if (cadena.Length > Math.Log10(double.MaxValue) + 1)
                        throw new OverflowException();
                    double dec = Convert.ToDouble(cadena);
                    if (dec < 0) throw new NegativeException();
                    return dec;  
                }catch(FormatException){
                    Print.RedPrint("Error ingrese un double valido");
                }catch(NegativeException){
                    Print.RedPrint("Error ingrese un double no negativo");
                }catch (OverflowException){
                    Print.RedPrint("Error el double es demasiado grande");
                }
            }
        }

        public static double ReadNegativeDouble(params string[] args){
            while(true){
                foreach(string arg in args) Console.WriteLine(arg);
                try{
                    string cadena = Console.ReadLine();
                    if (cadena.Length > (Math.Log10(double.MaxValue) + 1)/2)
                        throw new OverflowException();
                    double dec = Convert.ToDouble(cadena);
                    return dec;  
                }catch(FormatException){
                    Print.RedPrint("Error ingrese un double valido");
                }catch (OverflowException){
                    Print.RedPrint("Error el double es demasiado grande");
                }
            }
        }

    }
}
