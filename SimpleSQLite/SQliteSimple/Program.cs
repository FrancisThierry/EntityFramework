using System.Data.SQLite;

string cs = @"URI=file:C:\Users\thboulan\Documents\EntityFramework\helloSqlite.db";

using var con = new SQLiteConnection(cs);
con.Open();

String stm = "SELECT * FROM contact LIMIT 5";

using var cmd = new SQLiteCommand(stm, con);
using SQLiteDataReader rdr = cmd.ExecuteReader();
Console.WriteLine("Liste des contacts");
while (rdr.Read())
{
    Console.WriteLine($"{rdr.GetInt32(0)} {rdr.GetString(1)} {rdr.GetString(2)}");
}
con.Close();