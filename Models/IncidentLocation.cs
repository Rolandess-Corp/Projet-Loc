using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_Loc.Models
{
    public class IncidentLocation
    {
        public int IdInc
        {
            get; set;
        }
        public Location Location
        {
            get; set;
        }
        public Article Article
        {
            get; set;
        }
        public string TypeIncident
        {
            get; set;
        }
        public int nombre
        {
            get; set;
        }
    }
}
