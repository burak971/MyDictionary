using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> FenerbahceTakımıOyuncuları = new MyDictionary<int, string>();

           
            FenerbahceTakımıOyuncuları.Add(1, "ismail");
            FenerbahceTakımıOyuncuları.Add(1, "Osayi");
            FenerbahceTakımıOyuncuları.Add(1, "Szalai");
            FenerbahceTakımıOyuncuları.Add(1, "Mesut");
        }
    }
}
