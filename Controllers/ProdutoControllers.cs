using System.Collections.Generic;
using Primeiro_projeto_MVC.Models;
using Primeiro_projeto_MVC.Views;

namespace Primeiro_projeto_MVC.Controllers
{
    public class ProdutoControllers
    {
        //Models
        Produto produto =  new Produto();

        //Views
        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos(){

            List<Produto> produtos = produto.Ler();

            produtoView.Listagem(produtos);
        }

            public void Cadastrar(){
                produto.Inserir(produtoView.CadastrarProduto());
            }
    }
}