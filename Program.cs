﻿using System;
using Primeiro_projeto_MVC.Models;
using Primeiro_projeto_MVC.Controllers;

namespace Primeiro_projeto_MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            ProdutoControllers prod = new ProdutoControllers();
            prod.Cadastrar();
            Console.WriteLine();
            prod.ListarProdutos();
            Console.WriteLine();
            
        }
    }
}
