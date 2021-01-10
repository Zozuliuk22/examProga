using System;
using MyMatrix;
using MyString;
using Usually;

namespace General
{
    enum Operations : int
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your string : ");
            //string str = Console.ReadLine();


            //Str.LocaleCountSymbols(ref str);
            //Str.ReplaceGen(ref str);
            //Str.StrTrim(ref str);
            //Console.WriteLine("Rezult :\n" + str + "|");

            //int first = 100;
            //int second = 15;
            //All.UsingEnum(first, second);
            //All.UsingStruct(second);

            //double number = 1254.014985632;
            //All.FormatPrint(ref number, ref number);
            //Console.WriteLine("\nNumber = " + number);

            All.Random();
            Console.WriteLine();
            All.ConvertSystem();
            Console.WriteLine();
            All.SystemCoding();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
