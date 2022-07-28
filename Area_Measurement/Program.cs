internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Choices.OperationChoice();
        EndingApp();
    }

    public static void EndingApp()
    {
        Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz: \n" +
                          "********************************************************* \n" +
                          "(1) Programı sonlandır \n" +
                          "(2) Programı tekrar başlat \n");
        

        string choice = Console.ReadLine();
        if(choice.Contains('1')) Environment.Exit(0);
        else if(choice.Contains('2')) Choices.OperationChoice();
        else {Choices.Error(); EndingApp();}
    }
}