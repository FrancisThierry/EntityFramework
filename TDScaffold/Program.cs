using TDScaffold.Models;
using var db = new helloSqliteContext();
Console.WriteLine("Query after scaffold");

var contacts = db.Contacts;

foreach (var item in contacts)
{
    Console.WriteLine(item.Firstname);
    
}


db.Contacts
db.SaveChanges();
