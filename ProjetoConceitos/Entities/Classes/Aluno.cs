using System;

namespace ProjetoConceitos
{
    public class Aluno : Pessoa
    {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
        public void AprovadoReprovado()
        { 
           if(NotaFinal()>=60)
                Console.WriteLine("APROVADO");
           else
            {
              Console.WriteLine("REPROVADO");
              Console.WriteLine($"Faltaram {60 - NotaFinal():f2} Pontos");
            }

        }
    }
}
