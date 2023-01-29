using System;

namespace TrigonometricEquationCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение угла в градусах: ");
            double angle = double.Parse(Console.ReadLine());

            Console.WriteLine("Значение синуса равно: {0}", Math.Sin(angle * Math.PI / 180));
            Console.WriteLine("Значение косинуса равно: {0}", Math.Cos(angle * Math.PI / 180));
            Console.WriteLine("Значение тангенса равно: {0}", Math.Tan(angle * Math.PI / 180));

            Console.ReadKey();

        }
    }
}