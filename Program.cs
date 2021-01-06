using System;
using Primeiro_projeto_MVC.Models;
using Primeiro_projeto_MVC.Controllers;

namespace Primeiro_projeto_MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoControllers prod = new ProdutoControllers();
            prod.ListarProdutos();
        }
    }
}
