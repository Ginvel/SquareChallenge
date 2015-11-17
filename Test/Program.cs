using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SquareChallenge.Logic;
using Test.Tests;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var tester = new SquareCalculatorTester();
            var testerType = typeof(SquareCalculatorTester);
            var methods = testerType.GetMethods();
            foreach (var method in methods.Where(item=>item.Name.Contains("Test")).Select(item => item))
            {
                string result;
                if ((bool)method.Invoke(tester, null))
                {
                    result = "ОК";
                }
                else
                {
                    result = "Ошибка"; 
                }
                Console.WriteLine(string.Format("Выполнение теста \"{0}\", результат: {1}", method, result));
            }
            Console.ReadLine();
        }
    }
}
