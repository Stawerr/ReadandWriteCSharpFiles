using System.Collections.Generic;

namespace Exercicio3
{
    class Funcoes
    {
        //public static int TotalQuantidadeProduto (List<String[]> compraVec, int idCliente)
        //{
        //    int soma = 0;
        //    for (int i = 1; i < compraVec.Count; i++)
        //    {
        //        if(int.Parse(compraVec[i][0]) == idCliente)
        //        {
        //            soma++;
        //        }
        //    }
        //    return soma;
        //}

        // Somar os produtos comprados pelo cliente
        public static int ProdutosCompradosSoma(List<string[]> compras, int idCliente)
        {
            int soma = 0;
            List<int> produtos = new List<int>();
            for (int i = 1; i < compras.Count; i++)
            {
                if (int.Parse(compras[i][0]) == idCliente)
                    soma++;
            }
            return soma;
        }

        //Retornar a lista de Produtos comprados pelo cliente
        public static List<int> ProdutosComprados(List<string[]> compras, int idCliente)
        {
            List<int> produtos = new List<int>();
            for (int i = 1; i < compras.Count; i++)
            {
                if (int.Parse(compras[i][0]) == idCliente)
                    produtos.Add(int.Parse(compras[i][1]));
            }
            return produtos;
        }

        // Com a lista de produtos retornada somar o preço dos produtos
        public static int TotalValorProdutos(List<string[]> produtos, List<int> produtosPesquisar)
        {
            int soma = 0;
            for (int i = 0; i < produtosPesquisar.Count; i++)
            {
                for (int j = 1; j < produtos.Count; j++)
                {
                    if (int.Parse(produtos[j][0]) == produtosPesquisar[i])
                    {
                        soma += int.Parse(produtos[j][4]);
                        break;
                    }

                }
            }
            return soma;
        }
        public static string NomeCliente(List <string[]> clientes, int idCliente)
        {
            for(int i=1; i < clientes.Count; i++)
            {
                if (int.Parse(clientes[i][0]) == idCliente)
                    return clientes[i][1];
            }
            return null;
        }
    }
}