using System;

namespace ProjetoConceitos
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public void AdicionarProdutos(int quantidade)
        {
            this.Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            this.Quantidade -= quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void ExibeDados()
        {
            Console.WriteLine($"\nDados Atualizados: {Nome} | R$ {Preco:f2} | {Quantidade} unidades | Total: R$ {ValorTotalEmEstoque():f2}\n");
        }

        public override string ToString()// apresentar a classe
        {
            return $"\nDados Atualizados: {Nome} | R$ {Preco:f2} | {Quantidade} unidades | Total: R$ {ValorTotalEmEstoque():f2}\n";
        }
    }
}
