using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonatiTelefonici
{
    public class AbonatTelefonic
    {
        public int IdAbonament {  get; set; }
        public virtual Client Client { get; set; }
        public virtual TipAbonament AbonamentAles { get; set; }
        public List<ExtraOptiuni> OptiuniSalvate { get; set; }

        public AbonatTelefonic() { }


        public AbonatTelefonic(int idAbonament, Client client, TipAbonament abonamentAles, List<ExtraOptiuni> optiuniSalvate)
        {
            IdAbonament = idAbonament;
            Client = client;
            AbonamentAles = abonamentAles;
            OptiuniSalvate = optiuniSalvate;
        }
    } 
}
