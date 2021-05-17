namespace ProjetoConceitos
{
    partial class Program
    {
        public class Pensionato
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public int Room { get; set; }
            public Pensionato(string name, string email, int room)
            {
                this.Name = name;
                this.Email = email;
                this.Room = room;
            }
        }
    }
}
