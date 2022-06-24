using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathClassLibrary;
namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions obj1 = new Functions();

            // Access Add method from the class library
            var add = obj1.Add(20, 10);
            Console.WriteLine("Add : " + add);   

            // Access Substract from the class library
            var substract = obj1.Substract(20, 10);
            Console.WriteLine("Substract : " + substract);   

            // Access Multiply from the class library
            var multiply = obj1.Multiply(20, 10);
            Console.WriteLine("Multiply : " + multiply);   

            // Access Divide from the class library
            var divide = obj1.Divide(20, 10);
            Console.WriteLine("Divide : " + divide);
            Console.Read();
        }
    }
}
