namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta atleta = new Atleta { Nome = "Mario", Età = 25 };
            Dipendente dipendente = new Dipendente { Nome = "Luigi", Annidisevizio = 30 };
            Animale animale = new Animale { Nome = "Ghepardo", Razza = "Felina" };
            Veicolo veicolo = new Veicolo { Modello = "Auto", Km = 2020 };

            Console.WriteLine("Informazioni sull'Atleta:");
            Console.WriteLine($"Nome: {atleta.Nome}, Età: {atleta.Età}");

            Console.WriteLine("\nInformazioni sul Dipendente:");
            Console.WriteLine($"Nome: {dipendente.Nome}, Annidisevizio: {dipendente.Annidisevizio}");
 
            Console.WriteLine("\nInformazioni sull'Animale:");
            Console.WriteLine($"Nome: {animale.Nome}, Razza: {animale.Razza}");

            Console.WriteLine("\nInformazioni sul Veicolo:");
            Console.WriteLine($"Modello: {veicolo.Modello}, Km: {veicolo.Km}");

            Console.ReadLine();
        }
    }
}
