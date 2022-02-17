using System;
using System.IO;
namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader rd = new StreamReader("C:\\notas.txt");
            StreamWriter wd = new StreamWriter("C:\\aprovado.txt");
            StreamWriter wd2 = new StreamWriter("C:\\reprovado.txt");

            while (!rd.EndOfStream)
            {
                string linha = rd.ReadLine();
                string[] palavras = linha.Split(' ');
                
                if (double.Parse(palavras[2]) >= 9.5){
                    wd.WriteLine(linha);
                }
                else
                {
                    wd2.WriteLine(linha);
                }
            }
            rd.Close();
            wd.Close();
            wd2.Close();
        }
    }
}
