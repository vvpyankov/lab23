using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
// Разработать асинхронный метод для вычисления факториала числа. В методе Main выполнить проверку работы метода.

namespace lab23zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите число для определения его факториала:  ");
            int n = Convert.ToInt32(Console.ReadLine());
            FactAsync(n);

            Console.ReadKey();
        }

        static void Fact(int n)// метод  - определение факториала
        {
            int s = 1;// факториал с 1
            for (int i = 1; i < n + 1; i++)
            {
                s *= i;// произведение всех чисел
                Thread.Sleep(50);
            }
            Console.WriteLine(s);
        }
        static async void FactAsync(int n)// асинхронный метод
        {
            await Task.Run(() => Fact(n));// задача с await
        }
    }
}
