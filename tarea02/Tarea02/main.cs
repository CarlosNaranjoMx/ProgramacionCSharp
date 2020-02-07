using System;
namespace Main{
    class Program{
        
        static void Main(){
            Console.WriteLine("Ingresa el numero de alumnos a calificar: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Alumno[] arreglo = new Alumno[n];
            for (int i = 0; i < n; i++){
                Console.WriteLine($"Ingrese el nombre del alumno {i+1}:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la calificacion de su proyecto: ");
                double proyecto = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el numero de tareas: ");
                int tareas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de participaciones: ");
                int participaciones = Convert.ToInt32(Console.ReadLine()); 
                Alumno alumno = new Alumno(nombre,proyecto,tareas,participaciones);
                alumno.Calificacion = Calculadora.calcula(alumno);
                arreglo[i] = alumno;
            }
            foreach (Alumno alumno in arreglo){
                Console.WriteLine(
                    $"La calificacion final de {alumno.Nombre} es de: {alumno.Calificacion}/100");
            }
            Console.ReadKey(true);
        }
    }    
}