internal class Denarnica
{
    public double stanje;
    public string ime;

    public Denarnica(string ime, double stanje)
    {
        this.ime = ime;
        this.stanje = stanje;
    }
    public void Dvigni(double znesek)
    {
        if (znesek > stanje)
        {
            Console.WriteLine("Nimate dovolj denarja!");
        }
        else
        {
            stanje -= znesek;
        }
    }
    public void Polozi(double znesek)
    {
        stanje += znesek;
    }
    
}