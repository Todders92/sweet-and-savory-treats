using System.Collections.Generic;

namespace SavoryTreats.Models
{
  public class Treat
    {
        public Treat()
        {
            this.Flavors = new HashSet<FlavorTreat>();
        }

        public int TreatId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<FlavorTreat> Flavors { get; set; }
    }
}