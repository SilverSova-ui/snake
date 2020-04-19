﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');

            Point p2 = new Point(4, 5, '#');

            Point p3 = new Point(2, 10, '&');

            Point p4 = new Point(3, 1, '%');

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            List<char> pChar = new List<char>();
            pChar.Add('*');
            pChar.Add('+');
            pChar.Add('1');


            foreach (var i in pList)
            {
                i.Draw();
            }

            foreach (int q in numList)
            {
                Console.Write(q);
            }

            foreach (char p in pChar)
            {
                Console.Write(z);
            }

            Console.ReadLine();
        }
    }
}
