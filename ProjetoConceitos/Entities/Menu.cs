using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConceitos
{
    static class Menu
    {
        public static void Show()
        {
            #region Estrutura Sequencial
            //EstruturaSequencial.Soma();
            //EstruturaSequencial.CalculaAreaCirculo();
            //EstruturaSequencial.MostrarDiferença();
            //EstruturaSequencial.CalculaValorAPagar();
            //EstruturaSequencial.CalculaArea();
            #endregion

            #region Estrutura Condicional
            //EstruturaCondicional.NegativoOrPositivo();
            //EstruturaCondicional.ImparOrPar();
            //EstruturaCondicional.Multiplos();
            //EstruturaCondicional.DuracaoJogo();
            //EstruturaCondicional.Conta();
            //EstruturaCondicional.Intervalo();
            //EstruturaCondicional.Coordenadas();
            //EstruturaCondicional.CalculoImposto();
            #endregion

            #region Repeticao While
            //EstruturaRepeticaoWhile.Senha();
            //EstruturaRepeticaoWhile.Coordenadas();
            //EstruturaRepeticaoWhile.PostoCombustivel();
            #endregion

            #region Repeticao For
            //EstruturaRepeticaoFor.MostrarNumerosImpares();
            //EstruturaRepeticaoFor.Intervalo();
            //EstruturaRepeticaoFor.MediaPonderada();
            //EstruturaRepeticaoFor.PodeDivir();
            //EstruturaRepeticaoFor.Fatorial();
            #endregion

            #region Classe Triangulo
            /* Classe Triangulo para Calcular Area
            var x = new Triangulo(3.00, 4.00, 5.00);
            var y = new Triangulo(7.50, 4.50, 4.02);


            x.ApresentaArea();
            y.ApresentaArea();

            if (x.CalcularArea() > y.CalcularArea())
                Console.WriteLine("X Maior");
            else
                Console.WriteLine("Y Maior");
            */
            #endregion

            #region Classe Pessoa
            /*
            var pessoa1 = new Pessoa();
            Console.WriteLine("Informe o nome da primeira pessoa:");
            pessoa1.Nome = Console.ReadLine();
            Console.WriteLine("Informe a idade da primeira pessoa:");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            var pessoa2 = new Pessoa();
            Console.WriteLine("Informe o nome da segunda pessoa:");
            pessoa2.Nome = Console.ReadLine();
            Console.WriteLine("Informe a idade da segunda pessoa:");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
                Console.WriteLine($"A pessoa mais velha é {pessoa1.Nome}");
            else
                Console.WriteLine($"A pessoa mais velha é {pessoa2.Nome}");
            */
            #endregion

            #region Classe Funcionario
            /* 
             var funcionario1 = new Funcionario();
             Console.WriteLine("Informe o nome do primeiro funcionário:");
             funcionario1.Nome = Console.ReadLine();
             Console.WriteLine("Informe o Salario do primeiro funcionário:");
             funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             var funcionario2 = new Funcionario();
             Console.WriteLine("Informe o nome do segundo funcionário:");
             funcionario2.Nome = Console.ReadLine();
             Console.WriteLine("Informe o Salario do segundo funcionário:");
             funcionario2.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

             Console.WriteLine($"Salário médio = {(funcionario1.Salario + funcionario2.Salario)/2:f2}");
             */
            #endregion

            #region Classe Produtos
            /*
            var produto = new Produto();
            Console.Write("Informe o nome do Produto: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Informe o preço do Produto: ");
            produto.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Informe a quantidade em estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());
            produto.ExibeDados();

            Console.Write("Informe a quantidade a ser adicionada em estoque: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));
            produto.ExibeDados();

            Console.Write("Informe a quantidade a ser removida do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));
            produto.ExibeDados();
            Console.WriteLine(produto); //second way
            */
            #endregion

            #region Calculos Quadrado
            /*
            var retangulo = new Retangulo();
            Console.Write("Informe a Largura do retangulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe a Altura do retangulo: ");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Área = {retangulo.Area():f2}");
            Console.WriteLine($"Período = {retangulo.Perimetro():f2}");
            Console.WriteLine($"Diagonal = {retangulo.Diagonal():f2}");
            */
            #endregion

            #region Funcionários 2
            /*
            var funcionario = new Funcionario();
            Console.Write("Informe o nome do Funcionário: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Informe o salário do Funcionário: ");
            funcionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o imposto do Funcionário: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.ExibeFuncionario();
            Console.Write("Informe o percentual de aumento: ");
            funcionario.AumentoSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            funcionario.ExibeFuncionario();           
            */
            #endregion

            #region Classe Aluno
            /*
            var aluno = new Aluno();
            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Nota Final = {aluno.NotaFinal():f2}");
            aluno.AprovadoReprovado();
            */
            #endregion

            #region Static Class Conversor Moeda
            /*
            Console.Write("Informe a cotação do Dolar: ");
            double dolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares pretende comprar: ");
            double qtd = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine($"Valor a ser pago é R$ {ConversorDeMoeda.CalculaValorPagar(dolar,qtd):f2}.");
            */
            #endregion

            #region Produto Conceito Construtor
            /*
             var p = new NovoProduto("TV", 900.00);
             var p2 = new NovoProduto("TV 32'", 900.00, 10);

             p.ExibeDados();
             p2.ExibeDados();
            */
            #endregion

            #region Arrays
            //WorkingWithArray.RentARoom();
            #endregion

            #region Params
            /*
             UsingParamsModifiers.SumNumberWithParams(1, 2, 3, 4); //using params you dont need to use new 
             UsingParamsModifiers.SumNumberWithParams(new int[] { 1, 3 });
            */
            #endregion

            #region Ref and Out
            /*
             *int number = 10;
             int result;
             UsingParamsModifiers.TripleNumberWithRef(ref number); //with ref the variable needs to be initialized
             Console.WriteLine($"Triple of number with Ref {number}");
             UsingParamsModifiers.TripleNumberWithOut(10, out result);//with out the return variable dont need to be initialized
             Console.WriteLine($"Triple of number with Out {result}");
            */
            #endregion

            #region List
            // WorkingWithList.ListConcepts();
            //WorkingWithList.ListEmployee();
            #endregion

            #region Matriz
            /* 
             Matriz.Declaration();
             Matriz.ExemploOne();
             Matriz.ExercicioMatriz();
            */
            #endregion

            #region Convert
            //ConvertNumber converting = new ConvertNumber("1");
            //Console.WriteLine(converting.TryConvertion());
            #endregion

            #region Enum
            Order order = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            //Enum ToString()
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //String To Enum
            OrderStatus os;
            Enum.TryParse("Delivered", out os);
            Console.WriteLine(os);
            #endregion

            #region ExtensionMethods
            //DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            //Console.WriteLine(dt.ElapsedTime());

            //Console.WriteLine("---------------------------------------------");

            //String s1 = "Good morning dear students!";
            //Console.WriteLine(s1.Cut(10));
            #endregion
        }
    }
}
