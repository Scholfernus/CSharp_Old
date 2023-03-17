using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._11._2019_Helion_ćwiczenia_z_książki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FeetToInches(30));
            Console.WriteLine(FeetToInches(100));
        }
        static int FeetToInches(int feet)
        {
            int inches = feet * 12;
            return inches;            
        }

    }
}
