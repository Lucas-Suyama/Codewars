public static class Kata
{
  public static int[] ReverseSeq(int n)
  {
    int[] vet = new int[n];
    
    for(int i=0; n > 0; i++ ){
      vet[i] = n;
      n--;
    }
      return vet;
  }
  public static void Main(string[] args)
  {
    int[] vet = ReverseSeq(5);
    foreach(int i in vet){
      Console.WriteLine(i);
    }
  }
}