using System;
namespace ProjetoConceitos
{
    public class Funcionario : Pessoa
    {
        public int Id { get; set; }
        public double Salario { get; set; }
        public double Imposto { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(int id, string name, double salary)
        {
            this.Id = id;
            this.Nome = name;
            this.Salario = salary;
        }
        public void ExibeFuncionario()
        {
            Console.WriteLine($"\nFuncionário: {Nome} | R$ {SalarioLiquido():f2}\n");
        }
        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }

        public void AumentoSalario(double percentual)
        {
            this.Salario += (Salario * percentual) / 100;
        }

        public void ExibeFuncionarioLista()
        {
            Console.WriteLine($"\nID: {Id} | Funcionário: {Nome} | R$ {SalarioLiquido():f2}\n");
        }
    }
}
