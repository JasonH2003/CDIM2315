namespace HW_5;
class Program
{
    static void Main(string[] args)
    {
    
     Console.WriteLine("Input the first number: ");
        string N1 = Console.ReadLine();
        int A = Convert.ToInt32(N1);
        Console.WriteLine("Input the second number: ");
        string N2 = Console.ReadLine();
         int B = Convert.ToInt32(N2);
         

        Console.WriteLine($"a = {A}; b = {B}");
        int large = print(A,B);
        Console.WriteLine($"The largest number is: {large}");

         Console.WriteLine("Input the first number: ");
        string n1 = Console.ReadLine();
         int a = Convert.ToInt32(n1);
          Console.WriteLine("Input the second number: ");
        string n2 = Console.ReadLine();
         int b = Convert.ToInt32(n2);
          Console.WriteLine("Input the thrid number: ");
        string n3 = Console.ReadLine();
         int c = Convert.ToInt32(n3);
          Console.WriteLine("Input the fourth number: ");
        string n4 = Console.ReadLine();
         int d = Convert.ToInt32(n4);

         Console.WriteLine($"a = {a}; b = {b}; c = {c}; d = {d};");
         int big = print(a,b,c,d);
         Console.WriteLine($"The largest number is: {big}");
       
    
    }
    public static int print(int a,int b, int c=0, int d=0){
         if(a>b&&a>c&&a>d){
            return(a);
        }
        else if(b>a&&b>c&&b>d){
            return(b);
        }
        else if(c>a&&c>b&&c>d){
            return(c);
        }
        else{
            return(d);
        }
    }
   
}
