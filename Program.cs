using System;

namespace MiPrimerConsola.App
{
    class Program
    {
        public static void Main(string[] args)
        {
            SaludoInicial(args);
            Console.WriteLine("Bienvenido....!!!");
            Console.Write("Ingrese su nombre: ");
            var nombre = Console.ReadLine();


            int edad = IngresarEdad();


            Console.Write("Ingrese su peso: ");
            var peso = float.Parse(Console.ReadLine());//Trasforma a otro tipo de variable

            Console.Write("Ingrese su estatura: ");
            var estatura = float.Parse(Console.ReadLine());

            Console.Write("Ingrese pais de origen: ");
            var pais = (Console.ReadLine());

            Console.Write("Ingrese ciudad donde vive: ");
            var ciudad = (Console.ReadLine());

            int numeroTelefono = IngresarNumeroTelefono();

            Console.Write("¿Cual es su Genero? " + "\n");
            Console.Write("Ingrese M si es Masculino o F si es Femenino: " + "\n");
            var genero = char.Parse(Console.ReadLine());

            Console.Write("¿Usted Trabaja? " + "\n");
            bool trabajo = Console.ReadLine().ToUpper() == "SI";

            Console.Write("¿Usted Estudia? " + "\n");
            bool estudio = Console.ReadLine().ToUpper() == "SI";


            var persona = new Persona
            {
                nombre = nombre,
                edad = edad,
                peso = peso,
                estatura = estatura,
                ciudad = ciudad,
                pais = pais,
                numeroTelefono = numeroTelefono,
                trabajo = trabajo,
                estudio = estudio,
                genero = genero

            };


            Console.Write("Usted ingreso lo siguiente: " + "\n");
            Console.WriteLine($"Su nombre es: {persona.nombre}");
            Console.WriteLine($"Su edad es: {persona.edad}");
            Console.WriteLine($"Su peso es: {persona.peso}");
            Console.WriteLine($"Su estatura es: {persona.estatura}");
            Console.WriteLine($"Su pais de origen es: {persona.pais}");
            Console.WriteLine($"La ciudad donde vive es: {persona.ciudad}");
            Console.WriteLine($"su telefono es: {persona.numeroTelefono}");
            Console.WriteLine($"Su genero es: {persona.genero}");
            Console.WriteLine($"Usted trabaja: {persona.trabajo}");
            Console.WriteLine($"Usted estudia: {persona.estudio}");
            Console.Write("Muchas gracias...!!!:  , Digite cualquier tecla para salir... ");
            Console.ReadKey();

        }
        public static void SaludoInicial(string[] args)
        {
            if (args.Length > 0)
                Console.WriteLine("Hola {0} {1} {0} ", args[0], args[1]);
            else
            {
                Console.WriteLine("Hola desconocido");

            }
            Console.WriteLine("Como Estas?");
            var estado = Console.ReadLine();
            Console.WriteLine("mmmmmm ,entiendo");
            Console.ReadLine();
        }



        static int IngresarEdad()
        {
            Console.Write("Ingrese su edad: ");

            int edad1;
            while (true)
            {
                var edad = Console.ReadLine();
                if (!int.TryParse(edad, out edad1))
                {
                    Console.Write("Ingrese un valor numerico");
                }
                else
                {
                    break;
                };
            };
            return edad1;
        }
        static int IngresarNumeroTelefono()
        {
            Console.Write("Ingrese su numero de telefono: ");

            int numeroTelefono1;
            while (true)
            {
                var numeroTelefono = Console.ReadLine();
                if (!int.TryParse(numeroTelefono, out numeroTelefono1))
                {
                    Console.Write("Ingrese solo numeros: ");
                }
                else
                {
                    break;
                };
            };
            return numeroTelefono1;
        }

    }
}

