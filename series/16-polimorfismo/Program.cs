using System;
using Functions;
//El programa es un ejemplo de polimorfismo
//Deacuerdo al planeta que nos toque la distancia los demas planetas cambiara
namespace _16_polimorfismo{
    class Planeta{
        public void rotar(){
            Console.WriteLine("El planeta se encuentra rotando...");
        }
        public virtual void distancia(Planeta p){ }
    }

    class Tierra:Planeta{
        public override void distancia(Planeta p){
            switch (p){
                case Tierra t: Console.WriteLine("La distancia es 0km"); break;
                case Marte m:  Console.WriteLine("La distancia es 281.65 millones de km"); break;
                default: Console.WriteLine("Distancia no registrada"); break;
            }
        }
    }
    //En este caso la distancia a Marte desde Marte es 0
    class Marte:Planeta{
        public override void distancia(Planeta p){
            switch (p){
                case Tierra t: Console.WriteLine("La distancia es 281.65 millones de km"); break;
                case Marte m:  Console.WriteLine("La distancia es 0"); break;
                default: Console.WriteLine("Distancia no registrada"); break;
            }
        }
    }

    class Program{
        static void Main(string[] args){
            while (true){
                Planeta planeta=new Planeta();
                Planeta tierra = new Tierra();
                Planeta marte = new Marte();
                switch (
                    Read.ReadString(
                        "Elige tu planeta",
                        "tierra        t",
                        "marte         m",
                        "salir         s"
                    )[0]
                ){
                    case 'T':
                    case 't':planeta=tierra; break;
                    case 'M':
                    case 'm':planeta=marte; break;
                    case 's':
                    case 'S':goto End;
                    default: Print.RedPrint("Opcion No soportada"); break;
                }
                switch (
                    Read.ReadString(
                        "Calcula la distancia a",
                        "tierra        t",
                        "marte         m",
                        "salir         s"
                    )[0]
                ){
                    case 'T':
                    case 't':planeta.distancia(tierra); break;
                    case 'M':
                    case 'm':planeta.distancia(marte); break;
                    case 's':
                    case 'S':goto End;
                    default: Print.RedPrint("Opcion No soportada"); break;
                }              
            }End:;

        }
    }
}
