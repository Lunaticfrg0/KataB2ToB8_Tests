using System;

namespace Kata__6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int ConvertB2ToB10(string b2Digit)
        {
            int binaryNumber = int.Parse(b2Digit);
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
            string b8Value = "";
            while (true)
            {
                if((numToConvert % 8) != 0 )
                {
                    b8Value = (numToConvert % 8).ToString() + b8Value;
                }
                else
                {
                    b8Value = "0"+ b8Value;
                }
                numToConvert/= 8;
                if (numToConvert <= 0)
                {
                    break;
                }
            }
            return b8Value;
        }
        public static string ConvertB2ToB8(string x)
        {
            return ConvertB10ToB8(ConvertB2ToB10(x));
        }
    }
}
