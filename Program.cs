using System;

namespace MiPrimerConsola.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido....!!!");
            Console.Write("Ingrese su nombre: ");
            var nombre = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            var edad = Console.ReadLine();
            int edad1 = int.Parse(edad);
            Console.Write("Ingrese su peso: ");
            var peso = float.Parse(Console.ReadLine());//Trasforma a otro tipo de variable
            Console.Write("Ingrese su estatura: ");
            var estatura = float.Parse(Console.ReadLine());
            Console.Write("Ingrese pais de origen: ");
            var pais = (Console.ReadLine());
            Console.Write("Ingrese ciudad donde vive: ");
            var ciudad = (Console.ReadLine());
            Console.Write("Ingrese su numero de telefono: ");
            var numerotelefono = int.Parse(Console.ReadLine());
            Console.Write("¿Cual es su Genero? " + "\n");
            Console.Write("Ingrese M si es Masculino o F si es Femenino: " + "\n");
            var genero = char.Parse(Console.ReadLine());
            Console.Write("¿Usted Trabaja? " + "\n");
            Console.Write("Ingrese True si trabaja o False si no trabaja: " + "\n");
            var trabajo =bool.Parse(Console.ReadLine());
            Console.Write("¿Usted Estudia? " + "\n");
            Console.Write("Ingrese True si estudia o False si no estudia: " + "\n");
            var estudio = bool.Parse(Console.ReadLine());



            var persona = new Persona();
            persona.nombre = nombre;
            persona.edad = edad1;
            persona.peso = peso;
            persona.estatura = estatura;
            persona.ciudad = ciudad;
            persona.pais = pais;
            persona.numerotelefono = numerotelefono;
            persona.trabajo = trabajo;
            persona.estudio = estudio;
            persona.genero = genero;


            Console.Write("Usted ingreso lo siguiente: " + "\n");
            Console.WriteLine("Su nombre es:" + persona.nombre);
            Console.WriteLine("Su edad es:" + persona.edad);
            Console.WriteLine("Su peso es:" + persona.peso);
            Console.WriteLine("Su estatura es:" + persona.estatura);
            Console.WriteLine("Su pais de origen es:" + persona.pais);
            Console.WriteLine("La ciudad donde vive es:" + persona.ciudad);
            Console.WriteLine("su telefono es:" + persona.numerotelefono);
            Console.WriteLine("Su genero es:" + persona.genero);
            Console.WriteLine("Usted trabaja:" + persona.trabajo);
            Console.WriteLine("Usted estudia:" + persona.estudio);
            Console.Write("Muchas gracias...!!!:  , Digite cualquier tecla para salir... ");
            Console.ReadKey();

        }
        public void SaludoInicial(string[] args)
        {
            if (args.Length > 0)
                Console.WriteLine("Hola {0} {1} {0} ", args[0], args[1] );
            else
            {
                Console.WriteLine("Hola desconocido");

            }
            Console.WriteLine("Como Estas?");
            var estado = Console.ReadLine();
            Console.WriteLine("mmmmmm", "entiendo");
            Console.ReadLine();
        }
    }
}
    
