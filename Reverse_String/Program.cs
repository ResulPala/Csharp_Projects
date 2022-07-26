internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir cümle giriniz: ");

        char[] input = Console.ReadLine().ToCharArray();

        Array.Reverse(input);

        foreach (var item in input)
        {
            Console.Write(item);
        }
    }
}