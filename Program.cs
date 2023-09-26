using System;
using System.Collections.Generic;
using System.Data;

namespace pilas_estaticas
{
    class program
    {
        static void Main(string[] args)
        {
            //    List<string> nombres = new List<string>();
            //    nombres.Add("carlos");
            //    nombres.Add("arturo");
            //    nombres.Add("jose");              //[ADD]
            //    nombres.Add("lucas");
            //    nombres.Add("maria");
            //    nombres.Add("paola");
            //    nombres.Sort();                   //[SORT]
            //    for(int i = 0; i< nombres.Count; i++) //[COUNT]
            //    {
            //        Console.WriteLine(nombres[i]);
            //    }
            //Console.ReadKey();

            //COLA - QUEUE: PRIMERO EN ENTRAR - PRIMERO EN SALIR

            Queue<string> cola = new Queue<string>();
            Console.WriteLine("__________cola__________");
            cola.Enqueue("primero");
            cola.Enqueue("segundo");
            cola.Enqueue("tercero");
            cola.Enqueue("cuarto");
            cola.Enqueue("quinto");
            foreach(var item in cola)
                {
                Console.WriteLine(item);
            }
            Stack<string> pila = new Stack<string>();
            {
                Console.WriteLine("__________pila__________");
                pila.Push("primero");
                pila.Push("segundo");
                pila.Push("tercero");
                pila.Push("cuarto");
                pila.Push("quinto");
                foreach (var item in pila)
                {
                    Console.WriteLine(item);
                }
                Console.ReadKey();
            }

        }
    }
}