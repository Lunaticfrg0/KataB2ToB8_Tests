using System;

namespace Kata__6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int ConvertB2ToB10(string binary)
        {
            int binaryNumber = int.Parse(binary);
            int decimalNumber = 0;
            int base1 = 1;

            while(binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalNumber += reminder * base1;
                base1 = base1 * 2;
            }

            return decimalNumber;
        }
        public static string ConvertB10ToB8(int decimalToAnalize)
        {
            int numToChange = decimalToAnalize;
            string valueInB8 = "";

            while(true){
                if((numToChange % 8) != 0)
                {
                    valueInB8 = (numToChange % 8).ToString()+ valueInB8;
                }
                else
                {
                    valueInB8 = "0"+ valueInB8;
                }
                numToChange/=8;

                if(numToChange <= 0)
                {
                    break;
                }
            }

            return valueInB8;
        }
        public static string ConvertB2ToB8(string binaryToConvert)
        {
            return ConvertB10ToB8(ConvertB2ToB10(binaryToConvert));
        }
    }
}
