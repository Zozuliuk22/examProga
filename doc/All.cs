using System;
using System.Text; //для кодировок

namespace Usually
{
    public class All
    {
        public static void Random() 
        {
            Random rand = new Random();
            Console.WriteLine("rand.Next() = " + rand.Next());
            Console.WriteLine("rand.Next(Int32) = " + rand.Next(100000));
            Console.WriteLine("rand.Next(Int32, Int32) = " + rand.Next(-1000, -500));
            Console.WriteLine("rand.NextDouble() = " + rand.NextDouble());
            double max = 1990;
            double min = -1990;

            Console.WriteLine("rand.NextDouble() * (max - min) + min  = " + (rand.NextDouble() * (max - min) + min));
        }

        public static void Division(ref int a, ref int b, out double rezult)
        {
            rezult = (double) a / b;
        }

        enum Operations : int
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        public static void UsingEnum(int first, int second)
        {
            Console.WriteLine(Operations.Add + " = " + (first + second + (int)Operations.Add));
            Console.WriteLine(Operations.Subtract + " = " + (first - second - (int)Operations.Subtract));
            Console.WriteLine(Operations.Multiply + " = " + (first * second * (int)Operations.Multiply));
            Console.WriteLine(Operations.Divide + " = " + ((double)first / second / (int)Operations.Divide));
        }

        struct User
        {
            public string name;
            public int age;

            public void Info()
            {
                Console.WriteLine("Name : " + name + "\nAge : " + age);
            }
        }

        public static void UsingStruct(int number)
        {
            User user = new User { name = "Jack", age = number };
            user.Info();
        }

        public static void LengthOfNumber(out int length, ref int number)
        {
            length = 0;
            int temp = number;
            while (temp > 1)
            {
                temp /= 10;
                length += 1;
            }
        }        

        public static void DoublingNumberOdd(ref int number)
        {
            int temp = number;
            int i = 0;
            while (temp > 1)
            {
                int s = temp % 10;
                if (s % 2 == 1)
                {
                    number = temp * (int)(Math.Pow(10, i + 1)) + s * (int)(Math.Pow(10, i)) + number % ((int)(Math.Pow(10, i)));
                    i += 1;
                }
                temp /= 10;
                i += 1;
            }
        }

        public static void FormatPrint(ref double first, ref double second)
        {
            Console.WriteLine(String.Format("{0, 25}", first) + "\n" + "Second = " + String.Format("{0, 15}", String.Format("{0:0.000}", second)) );
        }

        public static void ConvertSystem()
        {
            string Bin = "1111";
            string Oct = "17";
            long Dec = 15;
            long Hex = 0xf;

            Console.WriteLine("Bin = 1111\nOct = 17\nDec = 15\nHex = {0:x}", 0xf);

            Console.WriteLine("======Перевод в двоичную=======\n");
            Console.WriteLine("Из 2 в 2 : " + Bin);
            Console.WriteLine("Из 8 в 2 : " + Convert.ToString(Convert.ToInt64(Oct, 8), 2));
            Console.WriteLine("Из 10 в 2 : " + Convert.ToString(Dec, 2));
            Console.WriteLine("Из 16 в 2 : " + Convert.ToString(Hex, 2));

            Console.WriteLine("======Перевод в восьмеричную=======\n");
            Console.WriteLine("Из 2 в 8 : " + Convert.ToString(Convert.ToInt64(Bin, 2), 8));
            Console.WriteLine("Из 8 в 8 : " + Oct);
            Console.WriteLine("Из 10 в 8 : " + Convert.ToString(Dec, 8));
            Console.WriteLine("Из 16 в 8 : " + Convert.ToString(Convert.ToInt64(Bin, 2), 8));

            Console.WriteLine("======Перевод в десятичную=======\n");
            Console.WriteLine("Из 2 в 10 : " + Convert.ToInt64(Bin, 2));
            Console.WriteLine("Из 8 в 10 : " + Convert.ToInt64(Oct, 8));
            Console.WriteLine("Из 10 в 10 : " + Dec);
            Console.WriteLine("Из 16 в 10 : " + Hex);

            Console.WriteLine("======Перевод в шестнадцатеричную=======\n");
            Console.WriteLine("Из 2 в 16 : " + Convert.ToString(Convert.ToInt64(Bin, 2), 16));
            Console.WriteLine("Из 8 в 16 : " + Convert.ToString(Convert.ToInt64(Bin, 2), 16));
            Console.WriteLine("Из 10 в 16 : " + Convert.ToString(Dec, 16));
            Console.WriteLine("Из 16 в 16 : {0:x}", Hex);
        }

        public static void SystemCoding()
        {
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;
            Encoding utf7 = Encoding.UTF7;
            Encoding utf32 = Encoding.UTF32;

            string s = "Рідна держава Україна. ABC/123";

            Console.WriteLine(s + " in ASCII : " + ascii.GetString(ascii.GetBytes(s)));
            Console.WriteLine(s + " in Unicode : " + unicode.GetString(unicode.GetBytes(s)));
            Console.WriteLine(s + " in UTF7 : " + utf7.GetString(utf7.GetBytes(s)));
            Console.WriteLine(s + " in UTF32 : " + utf32.GetString(utf32.GetBytes(s)));
        }

    }
}
