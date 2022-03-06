using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab23
{
    internal class Program
    {
        static void Method1()
        {
            Console.WriteLine("Method1 Has started");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Method1 provides counter = {i}");
                Thread.Sleep(100);
            }
            Console.WriteLine("Method1 had finished");
        }
        static void Method2(int n)
        {
            Console.WriteLine("Method2 Has started");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Method2 provides counter = {i}");
                Thread.Sleep(200);
            }
            Console.WriteLine("Method2 had finished");
        }
        static int Method3()
        {
            Console.WriteLine("Method3 Has started");
            int S = 0;
            for (int i = 0; i < 10; i++)
            {
                S += i;
                Thread.Sleep(100);
            }
            Console.WriteLine("Method3 had finished");
            return (S);
        }
        static void Main(string[] args)
        {
            /*Action action = new Action(Method1);
            Task task = new Task(action);
            task.Start();

            Task task1 = new Task(Method1);

            Task task2 = new Task(delegate () { Method1(); });

            Task task3 = new Task(() => Method1());

            Task task4 = Task.Factory.StartNew(action);*/

            /*Task task5 = Task.Run(() => Method1());
            task5.Wait(); //блокирующая операция

            Task task6 = Task.Run(() => Method2(100));
            task6.Wait(); //блокирующая операция
            //Method1(); - синхронное программирование
            //Method2(100);*/

            int r = Method1Async().Result;
            Method2(100);
            Console.WriteLine("Main had finished");
            Console.ReadKey();

        }
        static async Task<int> Method1Async()
        {
            Console.WriteLine("Method1Async has started");
            int result = await Task.Run(() => Method3());
            Console.WriteLine("Method1Async had finished");
            return result;
           

        }
    }
}
