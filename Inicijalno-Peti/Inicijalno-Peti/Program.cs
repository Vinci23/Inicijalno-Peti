﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicijalno_Peti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url;

            Console.WriteLine("Upišite URL:");
            url = Console.ReadLine();

            if (url.StartsWith("www.") && url.EndsWith(".hr"))
            {
                Console.WriteLine("URL je pravilan");
            }
            else
            {
                Console.WriteLine("URL nije pravilan");
            }


            Console.ReadKey();
        }
    }
}
