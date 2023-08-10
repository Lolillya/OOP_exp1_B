class Program
{
    public static void Main(string[] args)
    {
        double population = 1949400;
        int year = 2024;

        Console.WriteLine("Year" + "\t" + "Estimated Population");

        for (int i = 0; i < 5; i++) {
            population += population * 0.0218;
            Console.WriteLine(year + "\t" + Convert.ToInt32(population));
            year++;
        }
    }
}
