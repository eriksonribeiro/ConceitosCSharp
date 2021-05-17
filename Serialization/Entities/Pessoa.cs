using System;
using System.Runtime.Serialization;

namespace Serialization.Entities
{
    [Serializable]
    public class Pessoa: ISerializable

    {
        #region Propriedades
            public string name;
            public string address;
            public DateTime inputDate;
        

        [NonSerialized]
            public int id;
        #endregion

        #region ConstrutorComum
        public Pessoa()
        {
        }

        public Pessoa(int Id, string Name)
        {
            this.id = Id;
            this.name = Name;
        }
        #endregion

        #region Serialização
        public Pessoa(SerializationInfo info, StreamingContext context)
        {
            this.name = info.GetValue("Nome", typeof(string)).ToString();
            this.address = info.GetValue("Endereço", typeof(string)).ToString();
            //this.inputDate = info.GetValue("Data", typeof(DateTime)).GetType(\);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Nome", this.name);
            info.AddValue("Endereço", this.address);
          //  info.AddValue("Data", this.inputDate);
        }
        #endregion

        public virtual void ExibirPessoa()
        {
            Console.WriteLine($"Nome: {name}");
        }
    }
}
