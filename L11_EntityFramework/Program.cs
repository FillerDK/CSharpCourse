using L11_EntityFramework.DAL;

/*
var context = new BilContext();
var create = context.Database.EnsureCreated();
*/

try
{
    var context = new BilContext();
    var created = context.Database.EnsureCreated();
    Console.WriteLine("Database created!");
}
catch
{
    Console.WriteLine("Database not created!");
}
