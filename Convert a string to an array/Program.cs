public static class Kata
{
    public static string[] StringToArray(string str)
    {
      return str.Split(' ');
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(StringToArray("Hello World"));
    }
}