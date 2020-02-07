using System;
namespace Main{
    public class Alumno{
        public Alumno(string nombre,double cal_proyecto,int tareas,int participaciones) {
            Nombre = nombre;
            Cal_Proyecto = cal_proyecto>10?10:cal_proyecto;
            Cal_Proyecto = cal_proyecto<0?0:cal_proyecto;
            Tareas = tareas>5?5:tareas;
            Tareas = tareas<0?0:tareas;
            Participaciones = participaciones;
        }
        public string Nombre {get;}
        public double Cal_Proyecto {get;}
        public int Tareas {get;}
        public int Participaciones {get;}
        public int Calificacion {get; set;}    
        
    }
}