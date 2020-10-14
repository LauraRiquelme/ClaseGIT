using System;

namespace Clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            SaludarEspEng();



           
        }

        static void SaludarEspEng()
        {
             SaludarEsp("Hola. Soy argentina.");
            SaludarEng();
        }

        static void SaludarEsp(string mensaje)
        {
            Console.WriteLine(mensaje.ToUpper());
        }

        static void SaludarEng()
        {
            Console.WriteLine("Welcome to the summer house.");
        }
    }
}
