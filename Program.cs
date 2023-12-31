﻿using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System;

namespace tip_donusum
{

    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("**** inplicit conversion ****");
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "ugur";
            char f = 'k';
            object g = e+f+d;
            Console.WriteLine("g: " + g);

            Console.WriteLine("**** explicit conversion ****");
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            Console.WriteLine("**** ToString Metodu ****");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            string zz = 12.3f.ToString();
            Console.WriteLine("zz: " + zz);

            Console.WriteLine("**** System.convert sınıfı ****");
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1+sayi2;
            Console.WriteLine("toplam: " + toplam);

            //Parse
            Console.WriteLine("**** Parse Metodu ****");       
            ParseMethod();





        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("rakam1: " + rakam1);
            Console.WriteLine("double1: " + double1);

        }
    }
}
