using System;
using System.Collections.Generic;
using Primeiro_projeto_MVC.Models;

namespace Primeiro_projeto_MVC.Views
{
    public class ProdutoView
    {
        public void Listagem(List<Produto> produtos){
            foreach (var item in produtos)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco}");
                 Console.WriteLine();
                   
            }
        }

        public Produto CadastrarProduto(){
            Produto produto =  new Produto();

            Console.WriteLine($"Digite um código: ");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite um nome para o produto:");
            produto.Nome = Console.ReadLine();

            Console.WriteLine($"Digite o preço do produto: ");
            produto.Preco = float.Parse(Console.ReadLine()); 

            return produto;          
            
        }
    }
}