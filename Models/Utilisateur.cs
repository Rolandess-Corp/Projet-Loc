using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_Loc.Models
{
    public class Utilisateur
    {
        public int IdUtilisateur
        {
            get; set;
        }
        public string Nom
        {
            get; set;
        }
        public string Prenom
        {
            get; set;
        }
        public string Login
        {
            get; set;
        }
        public string MotDePasse
        {
            get; set;
        }
        public string Droit
        {
            get; set;
        }

    }
}
