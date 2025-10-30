public static class Kata
{
    public static int Paperwork(int n, int m)
    {
      if(n < 0 || m < 0) return 0;
      else return n * m;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(Paperwork(5, 5));
        Console.WriteLine(Paperwork(5, -5));
    }
}