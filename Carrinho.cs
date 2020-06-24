using System;
using System.Collections.Generic;

namespace AulaArgumentos
{
    public class Carrinho
    {
        public float ValorTotal {get ; set;}

        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto _prod){
            carrinho.Add(_prod);
        }

        public void Deletar(Produto _p){
            carrinho.Remove(_p);
        }

        public void Ler(){
            foreach (Produto item in carrinho){
                System.Console.WriteLine($"${item.Preco} - {item.Nome}");
            }
        }

        public void MostrarTotal(){
            foreach (Produto item in carrinho){
                ValorTotal += item.Preco;
            }
            System.Console.WriteLine($"Valor total do carrinho: {ValorTotal}");
        }

        public void Alterar(int _codigo, Produto _novoProduto){
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
        }
    }
}