using System;

namespace DsuDev.NumericConversion.ConsoleApplication1
{
	class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            long baseTwo = Transform.IntegerToBinaryLong(number);
            long baseEight = Transform.IntegerToOctalLong(number);
            string base16 = Transform.IntegerToHexString(number);

            Console.WriteLine($"Binary conversion: {baseTwo}");
            Console.WriteLine($"Octal conversion: {baseEight}");
            Console.WriteLine($"Hexadecimal conversion: {base16}");
            
            Console.ReadKey();
        }
    }
}
