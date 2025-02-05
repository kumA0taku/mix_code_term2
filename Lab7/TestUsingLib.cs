﻿using System;
using System.Collections.Generic;
using System.Text;
using DataStructureLib;

namespace TestUsingLib
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList P = new ArrayList(4);
            ArrayList L = new ArrayList(6); // edit value >> 5 to 6 in phase 2
            P.insert((int)0);
            P.insert((int)2);
            P.insert((int)3);
            P.insert((int)5);

            L.insert((int)20);
            L.insert((int)-6);
            L.insert((int)-5);
            L.insert((int)10);
            L.insert((int)70);
            L.insert((int)33);

            printElement(L, P);
        }
        static void printElement(ArrayList L, ArrayList P)
        {
            int Itemp = 0;
            int ptemp = 0;
            int pos = 0;

            while (ptemp < P.size())
            {
                //P have array data = [4]={ 5, 0, 2, 3}
                //L have array data = [5]={ 70, 20, -6, -5, 10}
                while (Itemp < L.size())
                {
                    if ((int)P.peek(ptemp) > (L.size() - 1)) //it work when "ptemp"++
                    {
                        Console.WriteLine("L[{0}] : Out of order", P.peek(ptemp));
                        break;
                    }
                    if ((int)P.peek(ptemp) == pos)
                    {
                        Console.WriteLine("L[{0}] : {1}", pos, L.peek(Itemp));
                        break;
                    }
                    ++Itemp;
                    ++pos;
                }
                ++ptemp;
            }
        }
    }
}
