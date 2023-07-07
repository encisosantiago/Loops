using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            while (counter < 10)
            {
                Console.WriteLine($"Hello World, esta es la vez No. {counter}");
                counter++;
            }

            Console.ReadKey();
            Console.Clear();

            counter = 0;

            do
            {
                Console.WriteLine($"Hello World, esta es la vez No. {counter}");
                counter++;
            } while (counter < 10);

            counter = 0;

            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World dentro de un Loop For {index}");
            }

            List<string> names = new List<string> { "<name>", "Sonia", "Esteban", "Santiago" };
            foreach (string name in names)
            {
                Console.WriteLine($"Bonjour " + name);
            }

            List<string> apellidos = new List<string> { "<apellido>" };
            apellidos.Add("Palyga");
            apellidos.Add("Enciso");
            apellidos.Add("Pusineri");

            foreach (string appelido in apellidos)
            {
                Console.WriteLine($"Salut tout le monde! " + appelido.ToUpper());
            }

            List<int> lista = new List<int> { 0 };
            lista.Add(9);
            lista.Add(3);
            lista.Add(6);

            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }

            lista.Sort();
            Console.WriteLine("Lista ordenada");
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }
        }
    }
}