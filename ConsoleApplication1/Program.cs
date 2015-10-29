using System;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            long baseTwo = NumericConversion.Transform.ToBinaryNumber(n);
            long baseEight = NumericConversion.Transform.ToOctalNumber(n);
            string base16 = NumericConversion.Transform.ToHex(n);

            Console.WriteLine("Binary conversion: " + baseTwo);
            Console.WriteLine("Octal conversion: " + baseEight);
            Console.WriteLine("Hexadecimal conversion: " + base16);

            Console.ReadKey();
        }
    }
}
