using System;
using System.IO;
namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader rdStock = new StreamReader("C:\\produtos.csv");
            StreamReader rdCompras = new StreamReader("C:\\compras.csv");
            StreamReader rdClientes = new StreamReader("C:\\clientes.csv");
            //  StreamWriter wd = new StreamWriter("C:\\produtos.csv");

            //while (!rdStock.EndOfStream)
            //{
            //    string linhaStock = rdStock.ReadLine();
            //    string[] palavrasStock = linhaStock.Split(';');
               
            //    Console.WriteLine(linhaStock);
            //}
            //Console.WriteLine("\n");

            //while (!rdClientes.EndOfStream)
            //{
            //    string linhaClientes = rdClientes.ReadLine();
            //    string[] palavrasClientes = linhaClientes.Split(';');

            //    Console.WriteLine(linhaClientes);
            //}

            //Console.WriteLine("\n");

            //while (!rdCompras.EndOfStream)
            //{
            //    string linhaCompras = rdCompras.ReadLine();
            //    string[] palavrasCompras = linhaCompras.Split(';');

            //    Console.WriteLine(linhaCompras);
            //}

            while (!rdCompras.EndOfStream)
            {
                string linhaCompras = rdCompras.ReadLine();
                string[] palavrasCompras = linhaCompras.Split(';');

                string linhaClientes = rdClientes.ReadLine();
                string[] palavrasClientes = linhaClientes.Split(';');

                Console.WriteLine(linhaClientes);
                
                Console.WriteLine(linhaCompras);
                
            }

                rdStock.Close();
            rdCompras.Close();
            rdClientes.Close();
            //wd.Close();
            
        }
    }
}
