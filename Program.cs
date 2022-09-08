// See https://aka.ms/new-console-template for more information
namespace  HW_2;
class Program
{
    static void Main(string[] args)
    {   
        //Q1
         Console.WriteLine("Input Letter Grade: ");
       string grade = Console.ReadLine();
       Convert.ToChar(grade);
       if (grade=="A"){
        Console.WriteLine("Grade Point: 4");
       }
       else if (grade=="B"){
        Console.WriteLine("Grade Point: 3");
       }
        else if (grade=="C"){
        Console.WriteLine("Grade Point: 2");
       }
        else if (grade=="D"){
        Console.WriteLine("Grade Point: 1");
       }
         else if (grade=="F"){
        Console.WriteLine("Grade Point: 0");
       }
        else{
            Console.WriteLine("Wrong Letter Grade!");
        }
       // Q2

        Console.WriteLine("Input the first number: ");
        string N1 = Console.ReadLine();
        int n1 = Convert.ToInt32(N1);
        Console.WriteLine("Input the second number: ");
        string N2 = Console.ReadLine();
         int n2 = Convert.ToInt32(N2);
        Console.WriteLine("Input the third number: ");
        string N3 = Console.ReadLine();
        int n3 = Convert.ToInt32(N3);

        if(n1 < n2 && n1 < n3){
            Console.WriteLine($"The smallest value is: {n1} ");
        }
        else if(n2 < n1 && n2 < n3){
            Console.WriteLine($"The smallest value is: {n2} ");
        }
       else if(n3 < n1 && n3 < n2){
            Console.WriteLine($"The smallest value is: {n3} ");
        }

   
}
}
