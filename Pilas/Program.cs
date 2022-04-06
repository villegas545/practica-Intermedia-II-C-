using System;
using System.Collections.Generic;

namespace Pilas
{
    internal class Program
    {
        static void Main(string[] args)
        {
          if (MyMethod("anna")){
            Console.WriteLine("Es un palindromo");
          }
          else{
            Console.WriteLine("No es un palindromo");
          }
        }
        public static bool MyMethod(string word){
            Stack<char> pila = new Stack<char>();
            foreach(char c in word){
                pila.Push(c);
            }
           foreach(char c in word){
               if(pila.Pop() != c){
                   return false;
                }
            }
            return true;
        }
    }
}
