using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

namespace Serialization.Entities
{
    public static class Menu
    {
        public static void ShowMenu()
        {
            try
            {
                string pastaArquivo = @"C:\temp";
                PessoaFisica pf = new PessoaFisica(1, "Erikson", 34797725877);
                PessoaJuridica pj = new PessoaJuridica(2, "Teste", "Teste SA", 11111111111111);
                Pessoa pessoaGenerica = new Pessoa();
                pessoaGenerica.name = "Pessoa Serializada";
                pessoaGenerica.address = "Rua Numero";
                pessoaGenerica.inputDate = Convert.ToDateTime("2020-01-01");


                if (Directory.Exists(pastaArquivo) == false)
                {
                    Console.WriteLine("Pasta não existente!");
                    return;
                }
                else
                {
                    IFormatter Formatador = new BinaryFormatter();
                    FileStream Buffer = File.Create(pastaArquivo + @"\saida.bin");
                    Formatador.Serialize(Buffer, pessoaGenerica);
                    Buffer.Close();

                    Buffer = File.OpenRead(pastaArquivo + @"\saida.bin");
                    Pessoa restorePessoa = Formatador.Deserialize(Buffer) as Pessoa;

                    pf.ExibirPessoa();
                    Console.WriteLine();
                    pj.ExibirPessoa();
                    Console.WriteLine();
                    restorePessoa.ExibirPessoa();
                    Console.WriteLine();

                    IFormatter formatter = new SoapFormatter();
                    MyFormatters.MySoapFormatter(formatter, pastaArquivo + @"\saida2.xml", pessoaGenerica);

                    string [] arquivosExistentes = Directory.GetFiles(pastaArquivo, "*.*");
                    string conteudo = "";

                    foreach (string arquivo in arquivosExistentes)
                    {
                        if (string.Equals(Path.GetExtension(arquivo), ".txt", StringComparison.InvariantCultureIgnoreCase) == false)
                            continue;

                        string conteudoTxt = File.ReadAllText(arquivo);
                        Console.WriteLine($"Conteúdo do arquivo {Path.GetFileName(arquivo)}");
                        Console.WriteLine(conteudoTxt);
                        Console.WriteLine();
                        conteudo += conteudoTxt;

                    }

                    string filePath = pastaArquivo + @"\teste.txt";
                    File.AppendAllText(filePath, conteudo);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
