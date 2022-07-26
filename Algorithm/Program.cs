using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Lütfen bir kelime yazınız ve çıkarmak istediğiniz karakterin index numarasını virgülle ayırarak belirtiniz: ");
        string[] input = Console.ReadLine().Split(',');

        int indexNumber = Convert.ToInt32(input[1]);

        input[0] = input[0].Remove(indexNumber,1);

        Console.WriteLine(input[0]);
    }
}