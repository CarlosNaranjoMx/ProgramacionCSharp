using System;
using Functions;
namespace _11_Matriz{
 
    class Matrix {
        int N { get; set; }
        int M { get; set; }
        decimal[,] matrix { get; set; }
        public Matrix(int n, int m, decimal[,] typematrix) {
            N = n;
            M = m;
            matrix = typematrix;
        }

        /*
        Las Matrices deben ser del mismo tamaño para que se puedan sumar
        */
        public static Matrix operator+(Matrix m1, Matrix m2){
            Matrix objresult;
            if (m1.N==m2.N && m1.M==m2.M){
                //creamos una nueva matriz con las dimensiones de las matrices
                decimal[,] result = new decimal[m1.N,m2.M];
                for (int i = 0; i < m1.N; i++){
                    for (int j = 0; j < m1.M; j++){
                        result[i,j] = m1.matrix[i,j]+m2.matrix[i,j];
                    }
                }
                objresult = new Matrix(m1.N,m2.M,result);
            }else{
                Print.RedPrint(
                    "Error No se puede realizar la suma",
                    "las matrices no son validaz",
                    "El ancho y el largo deben coincidir en ambas matrices");
                throw new NoValidMatrixException();
            }return objresult;
        }
        public static Matrix operator -(Matrix m1, Matrix m2){
            Matrix objresult;
            if (m1.N==m2.N && m1.M==m2.M){
                //creamos una nueva matriz con las dimensiones de las matrices
                decimal[,] result = new decimal[m1.N,m2.M];
                for (int i = 0; i < m1.N; i++){
                    for (int j = 0; j < m1.M; j++){
                        result[i,j] = m1.matrix[i,j]+m2.matrix[i,j];
                    }
                }
                objresult = new Matrix(m1.N,m2.M,result);
            }else{
                Print.RedPrint(
                    "Error No se puede realizar la resta",
                    "las matrices no son validaz",
                    "El ancho y el largo deben coincidir en ambas matrices");
                throw new NoValidMatrixException();
            }
            return objresult;
        }
        /*
        Para la multiplicacion de matrices es requisito que el ancho de la
        primer matriz coincida con el largo de la segunda
        */
        public static Matrix operator *(Matrix m1, Matrix m2){
            Matrix objresult;
            if(m1.M==m2.N){
                decimal[,] result = new decimal[m1.N, m2.M];
                decimal product;
                for (int i = 0; i < m1.N; i++){
                    for (int j = 0; j < m2.M; j++){
                        product=0;
                        for (int k = 0; k < m2.N; k++){
                            product += m1.matrix[i,k]*m2.matrix[k,j];
                        }result[i,j] = product;
                    }
                }
                objresult = new Matrix(m1.N,m2.N,result);
            }else{
                Print.RedPrint(
                    "Error No se puede realizar la Multiplicacion",
                    "de matrices, las matrices no son validaz ",
                    "El largo de la primer matriz debe coincidir con el",
                    "ancho de la segunda matriz");
                throw new NoValidMatrixException();
            }return objresult;
        }
        //definimos como mostrar las matrices

        public override string ToString(){
            string result = "";
            for (int i = 0; i < N; i++){
                result+="[";
                for (int j = 0; j < M; j++){
                    if (j < M - 1) result += $"{matrix[i,j]},";
                    else result += $"{matrix[i,j]}";
                }result+="]\n";
            }return result;
        }
    }
    class Program{
        static void Main(string[] args){
            //definicion de todo el menu de calculadora de matrices
            while (true){
                int n, m;
                Console.WriteLine("CALCULADORA DE MATRICES");
                n = Read.ReadInt("Ingrese el ancho de la PRIMER matriz");
                m = Read.ReadInt("Ingrese el largo de la PRIMER matriz");
                if (n != m) { Print.BluePrint("Advertencia no es una matriz cuadrada"); }
                decimal[,] matrix01 = new decimal[n, m];
                for (int i = 0; i < n; i++){
                    for (int j = 0; j < m; j++){
                        decimal value = Read.ReadNegativeDecimal($"Ingrese el valor ({i},{j}): ");
                        matrix01[i, j] = value;
                    }
                }
                Matrix objmatrix01 = new Matrix(n, m, matrix01);
                n = Read.ReadInt("Ingrese el ancho de la SEGUNDA matriz");
                m = Read.ReadInt("Ingrese el largo de la SEGUNDA matriz");
                if (n != m) { Print.BluePrint("Advertencia no es una matriz cuadrada"); }
                decimal[,] matrix02 = new decimal[n, m];
                for (int i = 0; i < n; i++){
                    for (int j = 0; j < m; j++){
                        decimal value = Read.ReadNegativeDecimal($"Ingrese el valor ({i},{j}): ");
                        matrix02[i, j] = value;
                    }
                }
                Matrix objmatrix02 = new Matrix(n, m, matrix02);
                Print.ArgsPrint(
                    "-------MENU-------",
                    "suma.............s",
                    "resta            r",
                    "multiplicacion...m",
                    "salir            e",
                    "------------------"
                );
                try{
                    switch(Read.ReadString(" ")[0]){
                        case 's': 
                            Console.WriteLine(objmatrix01);
                            Console.WriteLine("+");
                            Console.WriteLine(objmatrix02);
                            Console.WriteLine("------------------");
                            Console.WriteLine(objmatrix01+objmatrix02);
                            break;
                        case 'r': 
                            Console.WriteLine(objmatrix01);
                            Console.WriteLine("-");
                            Console.WriteLine(objmatrix02);
                            Console.WriteLine("------------------");
                            Console.WriteLine(objmatrix01-objmatrix02);
                            break;
                        case 'm': 
                            Console.WriteLine(objmatrix01);
                            Console.WriteLine("*");
                            Console.WriteLine(objmatrix02);
                            Console.WriteLine("------------------");
                            Console.WriteLine(objmatrix01*objmatrix02);
                            break;
                        case 'e': goto End;
                        default: Print.RedPrint("Opcion no soportada"); break;
                    }
                }catch(NoValidMatrixException){}
            } End:;
        }
    }
}
