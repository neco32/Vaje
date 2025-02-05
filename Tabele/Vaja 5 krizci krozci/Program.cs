internal class Program
{
    private static void Main(string[] args)
    {
        String[,] polje = new String[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                polje[i, j] = "1";
            }
        }
        while (true)
        {
            IzpisiPolje(polje);
            Console.WriteLine("Vnesi vrstico in stolpec (1-3) za igralca X:");
            int vrstica = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Vnesi vrstico in stolpec (1-3) za igralca X:");
            int stolpec = int.Parse(Console.ReadLine()) - 1;
            if(polje[vrstica, stolpec] != "1")
            {
                Console.WriteLine("Polje je že zasedeno!");
                continue;
            }
            polje[vrstica, stolpec] = "X";
            if (PreveriZmago(polje))
            {
                Console.WriteLine("Zmagal je igralec X!");
                break;
            }
            if (!PreveriPrazno(polje))
            {
                Console.WriteLine("Igra je neodločena!");
                break;
            }
            IzpisiPolje(polje);
            Console.WriteLine("Vnesi vrstico in stolpec (1-3) za igralca O:");
            vrstica = int.Parse(Console.ReadLine()) - 1;
            stolpec = int.Parse(Console.ReadLine()) - 1;
            if(polje[vrstica, stolpec] != "1")
            {
                Console.WriteLine("Polje je že zasedeno!");
                continue;
            }
            polje[vrstica, stolpec] = "O";
            if (PreveriZmago(polje))
            {
                Console.WriteLine("Zmagal je igralec O!");
                break;
            }
            if (!PreveriPrazno(polje))
            {
                Console.WriteLine("Igra je neodločena!");
                break;
            }

        }

    }
    public static bool PreveriZmago(String[,] polje)
    {
        for (int i = 0; i < 3; i++)
        {
            if (polje[i, 0] != "1" && polje[i, 0] == polje[i, 1] && polje[i, 1] == polje[i, 2])
            {
                return true;
            }
            if (polje[0, i] != "1" && polje[0, i] == polje[1, i] && polje[1, i] == polje[2, i])
            {
                return true;
            }
        }
        if (polje[0, 0] != "1" && polje[0, 0] == polje[1, 1] && polje[1, 1] == polje[2, 2])
        {
            return true;
        }
        if (polje[0, 2] != "1" && polje[0, 2] == polje[1, 1] && polje[1, 1] == polje[2, 0])
        {
            return true;
        }
        return false;
    }
    public static bool PreveriPrazno(String[,] polje)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (polje[i, j] == "1")
                {
                    return true;
                }
            }
        }
        return false;
    }
    public static void IzpisiPolje(String[,] polje)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(polje[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}