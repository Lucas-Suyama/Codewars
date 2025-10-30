public static class Kata
{
  public static int MakeNegative(int number)
  {
    if (number <= 0)
      return number;
    else
      return number * -1;
  }
  public static void Main(string[] args)
  {
    Console.WriteLine(MakeNegative(1));
    Console.WriteLine(MakeNegative(-1));
  }
}