using System;
using System.Collections.Generic;

namespace Intermedia_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lista = new ListaTuplas<Tupla>();
            
            lista.Agregar(new Tupla(1, 2));
            lista.Agregar(new Tupla(2, 3));
            var lista2 = new ListaTuplas<Tupla2>();
            lista2.Agregar(new Tupla2("Nombre", "Kind",5,true));
            lista2.Agregar(new Tupla2("Nombre2", "Kind2",6,false));

            foreach (var tupla in lista.GetLista())
            {
                Console.WriteLine(tupla.V1.ToString());
                Console.WriteLine(tupla.V2.ToString());
            }
            foreach (var tupla in lista2.GetLista())
            {
                Console.WriteLine(tupla.Name);
                Console.WriteLine(tupla.Kind);
                Console.WriteLine(tupla.Replicas.ToString());
                Console.WriteLine(tupla.Run.ToString());
            }
            Console.ReadKey();
        }
    }
}
