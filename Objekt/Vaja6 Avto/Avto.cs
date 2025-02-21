using System.Runtime.CompilerServices;

internal class Avto{

    public string Znamka;
    private int letnik;
    public string regSt;
    public Avto(string znamka, int letnik, string regSt)
    {
        this.Znamka = znamka;
        this.letnik = letnik;
        this.regSt = regSt;
    }
    public bool SpremeniLetnik(int novLetnik)
    {
        if (novLetnik >= 1960 && novLetnik <= 2024)
        {
            this.letnik = novLetnik;
            return true;
        }
        return false;
    }
    public override string ToString()
    {
        return ("Znamka: " + this.Znamka + ", letnik: " + this.letnik + ", reg. št.: " + this.regSt);
    }



}