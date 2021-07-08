using System;

namespace MultiMethodParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper _Helper = new Helper();

            //Console.WriteLine("First value: " + _Helper.TwoParaeter().Item1);
            //Console.WriteLine("Second value: " + _Helper.TwoParaeter().Item2);

            Console.WriteLine("Sum:" + _Helper.Caculation(10, 5).Item1);
            Console.WriteLine("Sub:" + _Helper.Caculation(10, 5).Item2);
            Console.WriteLine("Mul:" + _Helper.Caculation(10, 5).Item3);
            Console.WriteLine("Div:" + _Helper.Caculation(10, 5).Item4);

            Console.ReadKey();
        }
    }
}
