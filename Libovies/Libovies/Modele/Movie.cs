using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libovies.Modele
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreation { get; set; }

        public Director? Director { get; set; }

        public ICollection<Actor>? Actors { get; set;}

        public ICollection<MovieDistributor> MovieDistributors { get; set; }


    }
}
