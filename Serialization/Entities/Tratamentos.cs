using System;

namespace Serialization.Entities
{
    public static class Tratamentos
    {
        public static string TratatCPFCNPJ(this long cpfcnpj)
        {
            long cpf = cpfcnpj;

            if (cpf.ToString().Length == 11)
                return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
            else if (cpf.ToString().Length == 14)
                return Convert.ToUInt64(cpf).ToString(@"00\.000\.000/0000-00");
            else
                return null;
        }
    }
}
