using OneTableCodeFirst.Models;
using (var ctx = new AnimalContext())
{


   


    foreach (Animal item in ctx.Animals)
    {
        item.Foods.Add(new Food {Name="Pate pour chat" });
        
    }

    ctx.SaveChanges();
    // var anim = new Animal() { Name = "Bill", Breed="Sia" };

    // ctx.Students.Add(stud);
    // ctx.SaveChanges();                
}