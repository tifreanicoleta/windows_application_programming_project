using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonatiTelefonici
{
    public class ExtraOptiuni
    {
        public int IdOptiune {  get; set; }
        public string DenumireOptiune { get; set; }
        public double PretOptiune { get; set; }

        public ExtraOptiuni() { }
        public ExtraOptiuni(int idOptiune, string denumireOptiune, double pretOptiune)
        {
            IdOptiune = idOptiune;
            DenumireOptiune = denumireOptiune;
            PretOptiune = pretOptiune;
        }
    }
}
