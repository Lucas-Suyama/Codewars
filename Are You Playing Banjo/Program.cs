public class Kata
{
    public static string AreYouPlayingBanjo(string name)
    {
        return name.ToUpper().StartsWith("R") ? $"{name} plays banjo" : $"{name} does not play banjo";
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(AreYouPlayingBanjo("Martin"));
        Console.WriteLine(AreYouPlayingBanjo("Rikke"));
        Console.WriteLine(AreYouPlayingBanjo("rolf"));
        Console.WriteLine(AreYouPlayingBanjo("bruno"));
    }
}
