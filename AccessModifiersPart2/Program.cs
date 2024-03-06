namespace AccessModifiersPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City city = new City();
           city.Name = "Zangilan";
           city.Population = 150000;

            Console.WriteLine(city.Name);
            Console.WriteLine(city.Population);
        }
    }
}
