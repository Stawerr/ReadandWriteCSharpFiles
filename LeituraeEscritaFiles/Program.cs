using System;
using System.IO;
namespace LeituraeEscritaFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader rd = new StreamReader("C:\\vencimentos.txt");
            StreamWriter wd = new StreamWriter("C:\\SUPMIL.txt");

            while (!rd.EndOfStream)
            {
                string linha = rd.ReadLine();
                string[] palavras = linha.Split(' ');

                if (int.Parse(palavras[2]) > 1000)
                {
                    wd.WriteLine(linha);
                }
            }
            rd.Close();
            wd.Close();
        }
    }
}
