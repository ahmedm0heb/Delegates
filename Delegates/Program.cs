using System;
using System.Linq;

namespace ConsoleApp1
{
    class myTestClass
    {

        public string TextLength(string text)
        {
            return "number of text is " + text.Length;
        }
    }
    class Program
    {
        public delegate string FirDelgate(string text);


        static void Main(string[] args)
        {
            myTestClass newtest = new myTestClass();

            FirDelgate lengthoftext = new FirDelgate(newtest.TextLength);

            Console.WriteLine("enter text");

            string text = Console.ReadLine();

            Console.Write(lengthoftext(text));
        }
    }
}

