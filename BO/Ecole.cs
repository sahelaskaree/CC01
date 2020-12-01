using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [Serializable]
    public class Ecole
    {
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string LieuN { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }

        public Ecole()
        {
        }

        public Ecole(string matricule)
        {
            Matricule = matricule;
        }

        public Ecole(string matricule, string nom, string lieuN, string contact, string email) : this(matricule)
        {
            Nom = nom;
            LieuN = lieuN;
            Contact = contact;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Nom}";
        }
    }
}

