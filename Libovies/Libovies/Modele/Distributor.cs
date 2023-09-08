using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libovies.Modele
{
    public class Distributor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<MovieDistributor> MovieDistributors { get; set; }

    }
}
