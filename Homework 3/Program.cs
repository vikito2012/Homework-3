using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static bool plndrm(string S, int L)
        {
            if (L < 2)
            {
                return true;
            }
            else
            {
                int M = 0;
                if (L % 2 == 1)
                {
                    M = (L + 1) / 2;
                }
                else
                {
                    M = L / 2;
                }
                for (int i =1;i <= M; i++)
                {
                    if (S.Substring(i - 1, 1) != S.Substring(L - i, 1))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string pln = Console.ReadLine();
            int lnght = pln.Length;
            Console.WriteLine(plndrm(pln, lnght));
        }
    }
}
