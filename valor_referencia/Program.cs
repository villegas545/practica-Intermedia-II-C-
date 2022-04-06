using System;
using System.Diagnostics;

namespace valor_referencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass[] myClasses = new MyClass[1000000];
            MyStruct[] myStructs = new MyStruct[1000000];
            cronogramar(myClasses);
            cronogramar(myStructs);
        }
        public static void cronogramar<T>(T[] objeto) where T:IMyInterface,new()
        {
        Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
                for (int i = 0; i < objeto.Length; i++)
                {
                    objeto[i] = new T();
                    objeto[i].setVariables("v1", "v2", "v3");
                }
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0}",
            stopwatch.Elapsed);
        }
    }
}
