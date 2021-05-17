namespace ProjetoConceitos
{
    public static class ConversorDeMoeda
    {
        public static double CalculaValorPagar(double valor, double qtd)
        {
            const double iof = 0.06;
            return ((valor*qtd)*iof + valor*qtd);
        }
    }
}
