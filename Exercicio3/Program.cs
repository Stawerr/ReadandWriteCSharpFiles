using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Lê todas as linhas do ficheiro para dentro da lista
            List<string> listaProduto = File.ReadAllLines("D:\\produtos.csv").ToList();
            List<string> listaCompra = File.ReadAllLines("D:\\compras.csv").ToList();
            List<string> ListaCliente = File.ReadAllLines("D:\\clientes.csv").ToList();

            //Apresenta a lista
            //listaProduto.ForEach(produto => Console.WriteLine(produto));
            //Console.WriteLine("\n");

            // Alternativa ao código de cima
            //for(int i = 0; i < produto.Count; i++)
            //{
            //    Console.WriteLine(produto[i]);
            //}

            //listaCompra.ForEach(compra => Console.WriteLine(compra));
            //Console.WriteLine("\n");

            //listaCompra.ForEach(compra => Console.WriteLine(compra));
            //Console.WriteLine("\n");


            //Adiciona a lista a um vetor
            List<String[]> produtosVec = new List<string[]>();
            for (int i = 0; i < listaProduto.Count; i++)
            {
                produtosVec.Add(listaProduto[i].Split(';'));
            }

            List<String[]> compraVec = new List<string[]>();
            for (int i = 0; i < listaCompra.Count; i++)
            {
                compraVec.Add(listaCompra[i].Split(';'));
            }

            List<String[]> clienteVec = new List<string[]>();
            for (int i = 0; i < ListaCliente.Count; i++)
            {
                clienteVec.Add(ListaCliente[i].Split(';'));
            }
            //Mostrar a lista de vetores
            //for (int i = 0; i < listaProduto.Count; i++) { 
            //    for (int j = 0; j < produtosVec[0].Count(); j++){
            //        Console.Write(produtosVec[i][j]+"\t");
            //    }
            //    Console.WriteLine();
            //}


            //Função que soma o total de produtos que o cliente comprou
            int id;
            Console.WriteLine("Digite o ID do utilizador a guardar");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Total de Produtos comprados "+Funcoes.ProdutosCompradosSoma(compraVec, id));
            Console.WriteLine("Gastou " + Funcoes.TotalValorProdutos(produtosVec, Funcoes.ProdutosComprados(compraVec, id))+" Euros");

            List <string> escrever = new List<string>();
            escrever.Add("Total Produtos " + Funcoes.ProdutosCompradosSoma(compraVec, id));
            escrever.Add("Valor gasto " + Funcoes.TotalValorProdutos(produtosVec, Funcoes.ProdutosComprados(compraVec, id)));

            string path = "D:\\"+Funcoes.NomeCliente(clienteVec, id)+".txt";
            File.WriteAllLines(path , escrever);

        }
    }
}
