using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class A
{
    int entier = 42;
    public int Entier
    {
        get
        {
            return entier;
        }
        set
        {
            entier = value > 0 ? value : 0;
        }
    }
    private void MaMethodePrivee()
    {
        Console.WriteLine("OLEOLEOLE");
    }
    public void MaMethode()
    {
        Console.WriteLine("ABCD");
        MaMethodePrivee();
    }
}

namespace ConsoleApp1
{
    class Program
    {
        static void Modification(A a)
        {
            a.Entier = 10;
        }
        static void Main(string[] args)
        {
            var test = new A();

            test.Entier = -5;
            Console.WriteLine(test.Entier);
            test.MaMethode();
        }
    }
}
