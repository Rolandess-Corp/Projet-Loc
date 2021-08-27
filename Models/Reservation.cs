using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_Loc.Models
{
    public class Reservation_
    {
        public int IdRes
        {
            get; set;
        }
        public DateTime DateRes
        {
            get; set;
        }
        public Client Client
        {
            get; set;
        }
    }
}
