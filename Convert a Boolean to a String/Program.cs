public class kata
{
    public static string BooleanToString(bool b)
    {
        string boolean = "";
      
        if(b == true)
          boolean = "True";
        else
          boolean = "False";
          
        return boolean;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(BooleanToString(true));
        Console.WriteLine(BooleanToString(false));
    }
}