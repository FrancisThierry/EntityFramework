// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//instancier

Etudiant et = new Etudiant {ID=1,FirstName="Thierry",Lastname="Boulanger"};

// Etudiant et = new Etudiant();
// et.DateBirth = new Datetime("21/02/1972");
Console.WriteLine("Nom"+et.Lastname,"Prenom"+et.FirstName);

List<Etudiant> listeE = new List<Etudiant>();
listeE.Add(et);
listeE.Add(new Etudiant {ID=1,FirstName="Eric",Lastname="Allard"});
listeE.Add(new Etudiant {ID=1,FirstName="Etienne",Lastname="Alif"});

Console.WriteLine("Liste des étudiants");

foreach (var item in listeE)
{
    Console.WriteLine(item.FirstName);
    
}

//Linq
var etSearched = listeE.Where(e=>e.Lastname.StartsWith('A'));

Console.WriteLine("Liste des étudiants dont le nom commence par A");
foreach (var item in etSearched)
{
    Console.WriteLine(item.FirstName);
    
}



