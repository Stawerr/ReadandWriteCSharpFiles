using System;
using System.IO;
namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader rd = new StreamReader("C:\\produtos.csv");
          //  StreamWriter wd = new StreamWriter("C:\\produtos.csv");

            while (!rd.EndOfStream)
            {
                string linha = rd.ReadLine();
                string[] palavras = linha.Split();
               
                    Console.WriteLine(palavras[4]);
            }
            rd.Close();
            //wd.Close();
            
        }
    }
}
