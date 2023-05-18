using LINQ_MHegyek;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Hegycsucsok> HegycsucsLista = new List<Hegycsucsok>();
        StreamReader sr = new StreamReader("hegyekMo.txt");
        sr.ReadLine();

        while (!sr.EndOfStream)
        {
            string[] hegycsucs = sr.ReadLine().Split(";");
            HegycsucsLista.Add(new Hegycsucsok(hegycsucs[0], hegycsucs[1], int.Parse(hegycsucs[2])));
        }
        sr.Close();


        Console.WriteLine($"3.feladat: Hegycsúcsok száma: {HegycsucsLista.Count()} db");
        Console.WriteLine($"4.feladat: Hegycsúcsok átlagos magassága: {Math.Round(HegycsucsLista.Average(x => x.Magassag), 2)} m");

        Hegycsucsok legmagasabbHegy = HegycsucsLista.OrderByDescending(h => h.Magassag).First();

        Console.WriteLine("5. feladat: A legmagasabb hegycsúcs adatai:");
        Console.WriteLine($"\tNév: {legmagasabbHegy.Nev}");
        Console.WriteLine($"\tHegység: {legmagasabbHegy.Hegyseg}");
        Console.WriteLine($"\tMagasság: {legmagasabbHegy.Magassag} m");

        int bekertMagassagertek = int.Parse(Console.ReadLine());

    }
}