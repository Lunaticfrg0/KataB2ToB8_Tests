using System;

namespace Kata__6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int ConvertB2ToB10(string binaryDigit)
        {
            int binaryNumber = int.Parse(binaryDigit);
            int decimalValue = 0;
            int base1 = 1;

            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            return decimalValue;
        }
        public static string ConvertB10ToB8(int decimalValue)
        {
            int numToConvert = decimalValue;
            string octalValue = "";
            while (true)
            {
                if((numToConvert % 8) != 0 )
                {
                    octalValue = (numToConvert % 8).ToString() + octalValue;
                }
                else
                {
                    octalValue = "0"+ octalValue;
                }
                numToConvert/= 8;
                if (numToConvert <= 0)
                {
                    break;
                }
            }
            return octalValue;
        }
        public static string ConvertB2ToB8(string binaryNumber)
        {
            return ConvertB10ToB8(ConvertB2ToB10(binaryNumber));
        }
    }
}
