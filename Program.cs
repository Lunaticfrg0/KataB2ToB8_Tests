using System;

namespace Kata__6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int ConvertB2ToB10(string binaryValue)
        {
            int binaryNumber = int.Parse(binaryValue);
            int decimalValue = 0;
            int base1 = 1;

            while(binaryNumber > 0)
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
            int base10Number = decimalValue;
            string base8 = "";

            while (true)
            {
                if((base10Number % 8) != 0)
                {
                    base8 = (base10Number % 8).ToString()+base8;
                }
                else
                {
                    base8 = "0"+base8;
                }
                base10Number /= 8;
                if(base10Number <= 0)
                {
                    break;
                }
            }
            return base8;

        }
        public static string ConvertB2ToB8(string x)
        {
            return ConvertB10ToB8(ConvertB2ToB10(x));
        }
    }
}
