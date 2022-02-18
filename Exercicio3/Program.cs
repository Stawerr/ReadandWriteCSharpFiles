using System;
using System.IO;
namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader rdStock = new StreamReader("D:\\produtos.csv");
            StreamReader rdCompras = new StreamReader("D:\\compras.csv");
            StreamReader rdClientes = new StreamReader("D:\\clientes.csv");
            StreamWriter wd = new StreamWriter("D:\\produtosclintes.csv",true);

            while (!rdStock.EndOfStream)
            {
                string linhaStock = rdStock.ReadLine();
                string[] palavrasStock = linhaStock.Split(';');

                Console.WriteLine(linhaStock);
            }
            Console.WriteLine("\n");

            while (!rdClientes.EndOfStream)
            {
                string linhaClientes = rdClientes.ReadLine();
                string[] palavrasClientes = linhaClientes.Split(';');

                Console.WriteLine(linhaClientes);
            }

            Console.WriteLine("\n");

            int cliente;
            Console.WriteLine("Qual o ID do cliente a guardar? ");
            cliente = int.Parse(Console.ReadLine());

            while (!rdCompras.EndOfStream)
            {
                string linhaCompras = rdCompras.ReadLine();
                string[] palavrasCompras = linhaCompras.Split(';');

                if (palavrasCompras[0] == cliente.ToString())
                {
                    Console.WriteLine(linhaCompras);
                }
                
            }


            rdStock.Close();
            rdCompras.Close();
            rdClientes.Close();
            //wd.Close();
            
        }
    }
}
