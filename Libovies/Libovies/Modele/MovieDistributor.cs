using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libovies.Modele
{
    public class MovieDistributor
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int DistributorId { get; set; }
        public Distributor Distributor { get; set; }
    }
}
