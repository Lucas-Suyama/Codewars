public class Kata
{
  public static string Even_or_Odd(int number)
  {
      int remainder =  number % 2;
      string word = "";
      
      if(remainder == 0)
        word = "Even";
      else
        word = "Odd";
        
      return word;
    }
  public static void Main(string[] args)
  {
    Console.WriteLine(Even_or_Odd(2));
    Console.WriteLine(Even_or_Odd(1));
  }
}