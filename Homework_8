namespace Hw8;
class Program
{
   
   static void ArraySum(int[]a){
        int sum = 0;
        foreach( int x in a){
            sum += x;
        }
        Console.WriteLine($"The sum of int_array is: {sum}");
   }

   static void PrintAllOddNumber(int[,]a){
        Console.WriteLine("Q1: Print all odd numbers:");
        foreach(int x in a){
            if(x%2 != 0 ){
                Console.Write(x+" ");
            }
        }
        Console.WriteLine();
   }

   static int ElementSum(int[,]a){
        int sum = 0;
        for (int x = 0; x< a.GetLength(0); x++){
            for(int y = 0; y< a.GetLength(1); y++){
                sum += a[x,y];
            }
        }
        
        Console.WriteLine($"Q2: The sum of array elemnts: {sum}");
        return sum;
   }

   static int[ , ] DoubleArray(int[,]a){
        for (int x = 0; x< a.GetLength(0); x++){
            for(int y = 0; y< a.GetLength(1); y++){
               a[x,y] = a[x,y]*2; 
            }
        }

        Console.WriteLine("Q3: The new 2d array:");
        foreach(int z in a){
            Console.Write(z+" ");
        }
       return a;
   }
   
    static void Main(string[] args)
    {
        //Q1
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);

        //Q2
        int[,] array_2d = {
            {1, 2, 3},
            { 4, 5, 6},
            {7, 8, 9}
            };

        PrintAllOddNumber(array_2d);
        ElementSum(array_2d);
        DoubleArray(array_2d);
        


    }
}
