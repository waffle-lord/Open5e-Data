// See https://aka.ms/new-console-template for more information

using Open5e_Data.Servers;

var server = new Open5eServer();

var test = await server.GetSpells();

if(test != null)
{
    foreach(var spell in test.Results)
    {
        Console.WriteLine($"{spell.Name} - {spell.Level}");
    }
}