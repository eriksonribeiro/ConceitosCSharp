using System;

namespace ProjetoConceitos
{
    partial class Program
    {
        public static class WorkingWithArray
        {
            
            public static void RentARoom() 
            {
                Pensionato[] pensionato = new Pensionato[10];

                Console.Write("How many rooms will be rented? ");
                int qtd = int.Parse(Console.ReadLine());

                for (int i = 0; i < qtd; i++)
                {
                    Console.WriteLine($"\nRent #{i + 1}:");
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Room: ");
                    int room = int.Parse(Console.ReadLine());

                    pensionato[room] = new Pensionato(name, email, room);
                }

                Console.WriteLine("\nBusy rooms:");
                for (int i = 0; i < 10; i++)
                {
                    if (pensionato[i] != null)
                    Console.WriteLine($"{pensionato[i].Room}: {pensionato[i].Name} , {pensionato[i].Email}");
                }

                //Order way
                foreach (Pensionato item in pensionato)
                {
                    if (item != null)
                        Console.WriteLine($"{item.Room}: {item.Name} , {item.Email}");
                }
            }



        }
    }
}
