internal class Avto{
    public int najvecjaHitrost;
    public double PovprecnaPoraba;
    public double kolicinagoriva;
    public int steviloKilometrov;
    public string regSt;
    public Avto(int najvecjaHitrost, double PovprecnaPoraba, double kolicinagoriva, int steviloKilometrov, string regSt)
    {
        this.najvecjaHitrost = najvecjaHitrost;
        this.PovprecnaPoraba = PovprecnaPoraba;
        this.kolicinagoriva = kolicinagoriva;
        this.steviloKilometrov = steviloKilometrov;
        this.regSt = regSt;
    }
    public Avto(int najvecjaHitrost, double PovprecnaPoraba)
    {
        this.najvecjaHitrost = najvecjaHitrost;
        this.PovprecnaPoraba = PovprecnaPoraba;
        this.regSt = "";
    }

    public double doseg(){
        return this.PovprecnaPoraba * this.kolicinagoriva;
    }
    public int naslednjiServis(int interval){
        return interval-(this.steviloKilometrov%interval);
    }
    public void izpis(){
        Console.WriteLine("Največja hitrost: " + this.najvecjaHitrost + " km/h");
        Console.WriteLine("Povprečna poraba: " + this.PovprecnaPoraba + " l/100km");
        Console.WriteLine("Količina goriva: " + this.kolicinagoriva + " L");
        Console.WriteLine("Število prevoženih kilometrov: " + this.steviloKilometrov + " km");
        Console.WriteLine("Registrska številka: " + this.regSt);
    }

}