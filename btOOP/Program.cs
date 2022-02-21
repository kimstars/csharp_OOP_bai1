using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace btOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Medicine amo = new Medicine();
            amo.Accept();
            amo.Print1();
        }


    }




}
