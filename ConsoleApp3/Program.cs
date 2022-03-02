using System;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // RomanNumber nr1 = new RomanNumber(0); 
                RomanNumber nr1 = new RomanNumber(82);
                RomanNumber nr2 = new RomanNumber(18);
                RomanNumber nr3 = new RomanNumber(32);
                // RomanNumber nr3 = new RomanNumber(92);
                RomanNumber nr4 = new RomanNumber(2);
                RomanNumber nr5 = new RomanNumber(41);
                Console.WriteLine($"addition: {nr1.ToString()} + {nr2.ToString()} = {(nr1+nr2).ToString()}");
                Console.WriteLine($"subtraction: {nr1.ToString()} - {nr3.ToString()} = {(nr1-nr3).ToString()}");
                Console.WriteLine($"multiplication: {nr1.ToString()} * {nr4.ToString()} = {(nr1*nr4).ToString()}");
                Console.WriteLine($"division: {nr1.ToString()} / {nr5.ToString()} = {(nr1/nr5).ToString()}");
                RomanNumber[] arr = { nr1, nr2, nr3, nr4, nr5 };
                Array.Sort(arr);
                Console.WriteLine("sort result");
                foreach (var i in arr)
                {
                    Console.WriteLine(i.ToString());
                }

            }
            catch (RomanNumberException exc)
            {
                Console.WriteLine($"error: {exc.Message}");
            }

        }
    }
}