using System;
using Functions;
namespace _13_Carro{
    /*(1) Crear clase carro con atributos peso, altura y encendido  */
    class Carro{
        public double Peso {get; set;}
        public double Altura {get; set;}
        /*(2) Atributo encendido inicializado en false */
        public bool Encendido { get; set; } = false;
        public Carro(double peso, double altura){
            Peso = peso;
            Altura = altura;
        }
        public void encender(){
            Console.WriteLine("Encendido");
            Encendido = true;
        }
        public void apagar(){
            Console.WriteLine("Apagado");
            Encendido = false;
        }
        public bool estado(){return Encendido;}

        public override string ToString(){
            return 
            $"El peso del auto es {Peso}\n"+
            $"La altura del auto es {Altura}";
        }
    }
    //extendiendo la clase carro
    class CarroBMW : Carro{
        public string Modelo {get; set;} = "BMW";
        public CarroBMW(double peso, double altura):base(peso,altura){}

        public override string ToString(){
            return $"El peso del auto es {Peso}\n"+
                   $"La altura del auto es {Altura}\n"+
                   $"El modelo del auto es {Modelo}";
        }
    }
    //extendiendo la clase carro
    class CarroVW : Carro{
        public string Modelo {get; set;} = "VW";
        public CarroVW(double peso, double altura):base(peso,altura){}
    }

    class Program{
        static void Main(string[] args){
            //creacion de los objetos de prueba
            CarroBMW carrobmw = new CarroBMW(2.4,3.5);
            CarroVW carrovw = new CarroVW(1.3,3.8);
            //llamando los metodos
            carrobmw.apagar();
            carrovw.encender();
            Console.WriteLine(carrobmw);
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}


