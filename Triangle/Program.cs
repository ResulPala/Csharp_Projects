internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please input the length of triangle: ");

        int lengthT = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= lengthT; i++)  
        {   
           for (int k = 1; k <= i; k++)  
           {  
              Console.Write("*");  
           }  
           Console.WriteLine("");  
        }  
        Console.ReadLine();
    }
}