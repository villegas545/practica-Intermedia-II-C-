using System;

namespace operador_implicito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClaseA a = new ClaseA() { Nombre = "Julio" };
            convertClassAToClassB(a);
        
            ClaseB b = new ClaseB() { Nombre = "Cesar" };
            convertClassAToClassB(b);
        }
        public static void convertClassAToClassB(ClaseA a)
        {
            ClaseB b = a;
            Console.WriteLine(b.Nombre);
        }
        public static void convertClassBToClassA(ClaseB b)
        {         
            ClaseA a = b;
            Console.WriteLine(a.Nombre);
        }
    }
}
