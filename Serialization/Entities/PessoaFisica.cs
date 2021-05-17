using System;

namespace Serialization.Entities
{
    public sealed class PessoaFisica : Pessoa
    {
        #region Propriedades
        private long _cpf;
        private string _rg;
        #endregion

        public PessoaFisica()
        {
        }

        public PessoaFisica(int id, string name, long cpf)
            : base (id, name)
        {
            this._cpf = cpf;
        }
    
        public override void ExibirPessoa( )
        {
            base.ExibirPessoa();
            //Tratamentos tratar = new Tratamentos(); -- static class
            Console.WriteLine($"CPF: {_cpf.TratatCPFCNPJ()}");
        }

    }
}
