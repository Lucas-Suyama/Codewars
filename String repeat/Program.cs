public static class Kata
{
  public static string RepeatStr(int n, string s)
  {
    string result = "";

    for (int i = 0; i < n; i++)
      result += s;

    return result;
  }
  public static void Main(string[] args)
  {
    Console.WriteLine(RepeatStr(3, "a"));
    Console.WriteLine(RepeatStr(5, "hello"));
  }
}