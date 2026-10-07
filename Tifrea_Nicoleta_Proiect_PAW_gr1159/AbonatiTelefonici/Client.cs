using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonatiTelefonici
{
    public class Client
    {
        private int _idClient;
        private string _nume;
        private string _prenume;
        private string _telefon;
        private string _email;
        private string _judet;
        private string _localitate;

        public int IdClient
        {
            get { return _idClient; }
            set { _idClient = value; }
        }

        public string Nume { 
            get { return _nume; }
            set { _nume = value; }
        }

      
        public string Prenume
        {
            get { return _prenume; }
            set { _prenume = value; }
        }


        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Judet
        {
            get { return _judet; }
            set { _judet = value; }
        }

        public string Localitate
        {
            get { return _localitate; }
            set { _localitate = value; }
        }

        public Client() { }
        public Client(int idClient, string nume, string prenume, string telefon, string email, string judet, string localitate)
        {
            _idClient = idClient;
            _nume = nume;
            _prenume = prenume;
            _telefon = telefon;
            _email = email;
            _judet = judet;
            _localitate = localitate;
        }


       
    }
}
