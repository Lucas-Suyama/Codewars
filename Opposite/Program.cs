public class Kata
{
  public  static int Opposite(int number)
  {
    int opposite = number * -1;
    return opposite;
  }

  public static void Main(string[] args)
  {
    Console.WriteLine(Opposite(1));
    Console.WriteLine(Opposite(10));
  }
}