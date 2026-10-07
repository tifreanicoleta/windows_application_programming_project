using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonatiTelefonici
{
    internal class Plati
    {
        public int IdPlata { get; set; }
        public int IdAbonament { get; set; }
        public DateTime DataPlata { get; set; }
        public double Suma { get; set; }

        public Plati(int idPlata, int idAbonament, DateTime dataPlata, double suma)
        {
            IdPlata = idPlata;
            IdAbonament = idAbonament;
            DataPlata = dataPlata;
            Suma = suma;
        }
    }
}
