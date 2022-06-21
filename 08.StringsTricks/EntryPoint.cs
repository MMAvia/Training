
class EntryPoint
{
    static void Main()
    {
        string fruitJuice = "Strawberry Juice";
        System.Console.WriteLine(fruitJuice.Contains("berry"));
        System.Console.WriteLine(fruitJuice.IndexOf("berry"));
        System.Console.WriteLine(fruitJuice.LastIndexOf("berry"));
        fruitJuice = fruitJuice.ToLower();
        System.Console.WriteLine(fruitJuice);
        System.Console.ReadLine();
    }
}

