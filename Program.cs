﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Írj be egy számot ");
            string be = Console.ReadLine();
            int[] tomb = new int[5];
            Random r = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(0,91);
            }
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i]+",");
            }
            Console.WriteLine();
            int talalat = 0;
            bool asd = false;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (int.Parse(be)==tomb[i])
                {
                    talalat++;
                    asd = true;
                }
            }
            if (asd==true)
            {
                Console.WriteLine("fasza vagy");
            }
            Console.WriteLine("Ennyiszer találtad el: {0}",talalat);
            */
            int[] tomb = new int[5];
            int[] szamok = new int[5];
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write("Írj be egy számot: ");
                string be = Console.ReadLine();
                szamok[i] = int.Parse(be);
            }
            Random r = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(0, 91);
            }
            Array.Sort(tomb);
            Array.Sort(szamok);
            int talalt = 0;
            for (int i = 0; i < 5; i++)
            {
                if (tomb[i]==szamok[i])
                {
                    talalt++;
                }
            }
            Console.WriteLine("A lottón ennyi számot találtál el {0} ",talalt);
            Console.ReadKey();
        }
    }
}
