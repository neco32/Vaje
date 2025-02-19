using Vaja2_Clan;

internal class Program
{
    private static void Main(string[] args)
    {
        Clan clan = new Clan();
        clan.Ime = "Janez";
        clan.Priimek = "Novak";
        clan.LetoVpisa = 2025;
        clan.VpisnaStevilka = "2025-0001 ";
        Console.WriteLine("Clan1:");
        Console.WriteLine("Ime: " + clan.Ime+ " Priimek: " + clan.Priimek + " Leto vpisa: " + clan.LetoVpisa + " Vpisna številka: " + clan.VpisnaStevilka);
        Clan clan2 = new Clan();
        clan2.Ime = "Mojca";
        clan2.Priimek = "Kovač";
        clan2.LetoVpisa = 2025;
        clan2.VpisnaStevilka = "2025-0002 ";
        Console.WriteLine("Clan2:");
        Console.WriteLine("Ime: " + clan2.Ime + " Priimek: " + clan2.Priimek + " Leto vpisa: " + clan2.LetoVpisa + " Vpisna številka: " + clan2.VpisnaStevilka);
        Clan clan3 = clan2;
        clan3.Ime = "Petra";
        Console.WriteLine("Clan3:");
        Console.WriteLine("Ime: " + clan3.Ime + " Priimek: " + clan3.Priimek + " Leto vpisa: " + clan3.LetoVpisa + " Vpisna številka: " + clan3.VpisnaStevilka);
    }
}