internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the length of the Fibonacci Series: ");  
        int length = Convert.ToInt32(Console.ReadLine());  
        Console.WriteLine("The mean value for Fibonacci Series: {0}", Fibonacci(length)); 
        Console.ReadKey();
    }

    public static int Fibonacci(int length)  
    {
        int firstNumber = 0;
        int secondNumber = 1;
        int finalNumber = 0;
        int sum = 0;
        
        for (int i = 2; i < length; i++)
        {
            finalNumber = firstNumber + secondNumber;
            sum = sum + finalNumber;
            firstNumber = secondNumber;
            secondNumber = finalNumber;               
        }  
        int mean = sum/length;
        return mean;
    }

}