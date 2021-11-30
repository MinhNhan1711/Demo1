using System;

namespace Lab2_LeTruongMinhNhan
{
    class Program
    {
        static void Main(string[] args)
        {
            BookList b1 = new BookList();
            b1.InputList();
            b1.ShowList();

            Console.WriteLine("\n Sap xep thu tu theo nam = phuong phap Icomparerble");
            b1.sapXepIComparerable();
            b1.ShowList();

            Console.WriteLine("\n Sap xep thu tu theo ten = phuong phap Icomparer");
            b1.sapXepIComparer();
            b1.ShowList();

            Console.ReadLine();

        }
    }
}
