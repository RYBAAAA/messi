using ConsoleApp1;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZwierzakDomowy kot = new ZwierzakDomowy("Bałwan", "Pies", new DateTime(1996, 7, 2));
            ZwierzakDomowy byk = new ZwierzakDomowy("Antek", "Byk", new DateTime(2066, 8, 3));

            Console.WriteLine(kot.ToString());
            Console.WriteLine(byk.ToString());
            //zad2
            RownanieKwadratowe rownanie = new RownanieKwadratowe(3, 2, 6);

            double delta = rownanie.ObliczDelte();
            Console.WriteLine("Delta: " + delta);

            RownanieKwadratowe rownanie2 = new RownanieKwadratowe(1, 1, 1);
            try
            {
                double[] rozwiazanie2 = rownanie2.ObliczRozwiazanie();
                Console.WriteLine($"Rozwiązania: {rozwiazanie2[0]}, {rozwiazanie2[1]}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}