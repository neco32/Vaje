internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Napiši poljuben stavek: ");
        string vnos = Console.ReadLine();
        int pike = 0;
        int vejice = 0;
        int a=0;
        for(int i=0; i<vnos.Length; i++){
            switch (vnos[i]){
                case '.':
                    pike++;
                    break;
                case ',':
                    vejice++;
                    break;
                case 'a':
                    a++;
                    break;
            }
        }
        Console.WriteLine("Število pik: " + pike);
        Console.WriteLine("Število vejic: " + vejice);
        Console.WriteLine("Število črk a: " + a);
    }
}