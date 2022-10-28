using System;
using System.ComponentModel.DataAnnotations;

namespace OneTableCodeFirst.Models
{
    public class Food
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        public int FkAnimalId { get; set; }

        public virtual Animal FkAnimal { get; set; } = null!;
    }
}
