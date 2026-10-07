using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonatiTelefonici
{
    public class TipAbonament
    {
        public int IdTip { get; set; }
        public string Denumire { get; set; }
        public double PretLunar {  get; set; }

        public TipAbonament() { }

        public TipAbonament(int idTip, string denumire, double pretLunar)
        {
            IdTip = idTip;
            Denumire = denumire;
            PretLunar = pretLunar;
        }
    }
}
