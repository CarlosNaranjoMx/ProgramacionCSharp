using System;
namespace Main{
    static class Calculadora{
        /**
         * Se encarga de obtener la calificacion del alumno
         * calificacion del proyecto    60%
         * cantidad de tareas           40%
         * cantidad de  participaciones  8%
         */
        public static int calcula(Alumno alumno){
            int porcentaje = Convert.ToInt32(alumno.Cal_Proyecto*6);
            int tareas = alumno.Tareas*8;
            int part = alumno.Participaciones>5?8:0;
            // Console.WriteLine($"porcentaje:{porcentaje}");
            // Console.WriteLine($"tareas: {tareas}");
            // Console.WriteLine($"participaciones:{part}");
            int calif = porcentaje+tareas+part;
            calif = calif>100?100:calif;
            calif = calif<50?50:calif;
            return calif;
        }        
    }    
} 