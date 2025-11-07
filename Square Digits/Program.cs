using System;

public class Kata
{
  public static int SquareDigits(int n)
  {
    string numString = n.ToString();
    string resultString = "";
    foreach( char c in numString){
      int digit = (int)Char.GetNumericValue(c);
      resultString += (digit * digit);
    }

    return int.Parse(resultString);
  }

  public static void Main(string[] args)
  {
    Console.WriteLine(SquareDigits(9119));
  }
}