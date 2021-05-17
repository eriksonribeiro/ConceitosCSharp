using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProjetoConceitos
{
    public static  class WorkingWithList
    {
        public static void ListConcepts()
        {
            List<string> list = new List<string>();

            list.Add("Adore Delano");
            list.Add("Yara Sofia");
            list.Add("Bob The Drag Queen");
            list.Add("RuPaul");
            list.Add("Pabblo Vittar");
            list.Add("Joelma");

            list.Insert(1, "Jujubee"); //You can choose the position to insert, ADD always include in the end of the List

            foreach (string name in list)
            {
                Console.WriteLine($"Name: {name}");
            }

            //COUNT
            Console.WriteLine($"\nList Count is {list.Count}");
            
            //FIND
            string search = list.Find(x => x[0] == 'R');
            Console.WriteLine($"First Name with R: {search}");

            //FIND LAST
            string search2 = list.FindLast(x => x[0] == 'J');
            Console.WriteLine($"Last Name with J: {search2}");

            //FIND INDEX
            int position = list.FindIndex(x => x[0] == 'R');
            Console.WriteLine($"Position First Name with R: {position}");

            //FIND INDEX LAST
            int position2 = list.FindLastIndex(x => x[0] == 'J');
            Console.WriteLine($"Position Last Name with J: {position2}");

            //FIND ALL
            List<string> newList = list.FindAll(x => x.Length == 6);
            Console.WriteLine("-----------------------------------------------");
            foreach (string item in newList)
            {
                Console.WriteLine($"Name: {item}");
            }

            //REMOVE
            list.Remove("RuPaul");
            Console.WriteLine("-----------------------------------------------");
            foreach (string item in list)
            {
                Console.WriteLine($"Name: {item}");
            }
            Console.WriteLine("-----------------------------------------------");

            //REMOVE ALL
            list.RemoveAll(x => x[0] == 'J');
            foreach (string item in list)
            {
                Console.WriteLine($"Name: {item}");
            }
            Console.WriteLine("-----------------------------------------------");

            
            //RemoveAt
            list.RemoveAt(2);
            foreach (string item in list)
            {
                Console.WriteLine($"Name: {item}");
            }
            Console.WriteLine("-----------------------------------------------");

            //RemoveRange
            list.RemoveRange(0,1);
            foreach (string item in list)
            {
                Console.WriteLine($"Name: {item}");
            }
            Console.WriteLine("-----------------------------------------------");


        }

        public static void ListEmployee()
        {
            List<Funcionario> employeeList = new List<Funcionario>();

            Console.Write("How many employees will be registred? ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine($"Employee #{i+1}");
                Console.Write("Fill the Employee ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Fill the Employee Name: ");
                string name = Console.ReadLine();
                Console.Write("Fill the Employee Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employeeList.Add(new Funcionario(id, name, salary));

                Console.WriteLine("");
            }

            Console.Write("Enter the employee Id that will have salary increase: ");
            int idEmployee = int.Parse(Console.ReadLine());

            Funcionario func = employeeList.Find(f => f.Id == idEmployee);

            if (func != null)
              { 
                Console.Write("Enter the percentage: ");
                double perc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                func.AumentoSalario(perc);
              }
            else
                Console.WriteLine("This id does not exist!");

            foreach (Funcionario employee in employeeList)
            {
                employee.ExibeFuncionarioLista();
            }
        }

    }
}
