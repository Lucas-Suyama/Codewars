public static class Kata
{
  public static string Remove_char(string s)
  {
    if (s.Length <= 2)
    {
      return "";
    }

    int novoComprimento = s.Length - 2;
    char[] novosCaracteres = new char[novoComprimento];

    for (int i = 0; i < novoComprimento; i++)
    {
      novosCaracteres[i] = s[i + 1];
    }
    
    return new string(novosCaracteres);
  }

  public static void Main(string[] args)
  {
    Console.WriteLine(Remove_char("hello"));   
    Console.WriteLine(Remove_char("codewars")); 
  }
}