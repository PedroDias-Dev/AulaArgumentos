using System;

namespace AulaArgumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();

            Produto p1 = new Produto(1, "Minecraft", 49);
            Produto p2 = new Produto(2, "The Last of Us II", 249);
            Produto p3 = new Produto(3, "Forza Horizon 4", 79);
            Produto p4 = new Produto(4, "Sekiro", 149);
            
            cart.Adicionar(p1);
            cart.Adicionar(p2);
            cart.Adicionar(p3);
            cart.Adicionar(p4);

            Produto prodAlterado = new Produto(1, "CyberPunk 2077", 399);
            cart.Alterar(2, prodAlterado);

            cart.Ler();

            cart.MostrarTotal();

        }
    }
}
