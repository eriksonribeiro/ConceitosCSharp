using System;

namespace Serialization.Entities
{
    public sealed class PessoaJuridica : Pessoa
    {
        #region Propriedades
          private string _razao;
          private long _cnpj;
        #endregion

        public PessoaJuridica(int id, string name, string razao, long cnpj)
            :base(id, name)
        {
            this._cnpj = cnpj;
            this._razao = razao;
        }

        public override void ExibirPessoa()
        {
            base.ExibirPessoa();
            Console.WriteLine($"Razão: {_razao}");
            Console.WriteLine($"CNPJ: {_cnpj.TratatCPFCNPJ()}");
        }
    }
}
