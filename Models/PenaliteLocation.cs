
namespace Projet_Loc.Models
{
    public class PenaliteLocation
    {
        public int IdPenalite
        {
            get; set;
        }
        public Article Article
        {
            get; set;
        }
        public Location Location
        {
            get; set;
        }
        public int Nombre
        {
            get; set;
        }
    }
}
