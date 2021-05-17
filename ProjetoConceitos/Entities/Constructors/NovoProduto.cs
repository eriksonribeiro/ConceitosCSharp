namespace ProjetoConceitos
{
    public class NovoProduto : Produto
    {
        public NovoProduto()
        {
        }
        public NovoProduto(string nome, double preco):this() //sem parametros o padrão
        {
            this.Nome = nome;
            this.Preco = preco;
        }
        public NovoProduto(string nome, double preco, int qtd) : this(nome, preco) //passando o parametro do segundo contrutor (primeira sobrecarga)
        {
            this.Quantidade = qtd;
        }


    }
}
