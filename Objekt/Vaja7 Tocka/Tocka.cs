internal class Tocka{
    private int x;
    private int y;
    public Tocka(int x, int y){
        this.x = x;
        this.y = y;
    }
    public int X
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }
    public double razdalja(Tocka t){
        return System.Math.Sqrt((t.x - x) * (t.x - x) + (t.y - y) * (t.y - y));
    }
    
}