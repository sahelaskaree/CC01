using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [Serializable]
    public class Etudiant
    {
        public string Matricule { get; set; }
        public string MatriculeEcole { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Image { get; set; }
        public DateTime DateN { get; set; }
        public string LieuN { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }

        public Etudiant()
        {
        }

        public Etudiant(string matricule)
        {
            Matricule = matricule;
        }

        public Etudiant(string matricule, string matriculeEcole, string nom, string prenom, string image, DateTime dateN, string lieuN, string contact, string email) : this(matricule)
        {
            MatriculeEcole = matriculeEcole;
            Nom = nom;
            Prenom = prenom;
            Image = image;
            DateN = dateN;
            LieuN = lieuN;
            Contact = contact;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Nom} {Prenom}";
        }
    }

}

