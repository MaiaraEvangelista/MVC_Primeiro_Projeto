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
                   
            }
        }
    }
}