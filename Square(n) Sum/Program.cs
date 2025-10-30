public static class Kata
{
  public static int SquareSum(int[] numbers)
  { 
    int sum = 0;
    
    foreach(int num in numbers){
      sum += (num * num);
    }
    
    return sum;
  }

  public static void Main(string[] args)
  {
    Console.WriteLine(SquareSum(new int[] { 1, 2, 2 }));   
    Console.WriteLine(SquareSum(new int[] { 0, 3, 4, 5 })); 
  }
}