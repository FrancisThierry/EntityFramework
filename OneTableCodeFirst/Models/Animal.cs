using System;
using System.ComponentModel.DataAnnotations;


namespace OneTableCodeFirst.Models
{
    public class Animal
    {
        public Animal(){
            Foods = new HashSet<Food>();
        }
        public int Id { get; set; }
        [StringLength(50)]

        public string Name { get; set; }

        public string FirstName { get; set; }       
        

        public string Breed { get; set; }

        public virtual ICollection<Food> Foods { get; set; }


    }
}
