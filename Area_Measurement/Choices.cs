public class Choices
{
    public static void OperationChoice()
    {
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: \n" +
                          "********************************************************* \n" +
                          "(1) Çevre Hesaplaması \n" +
                          "(2) Alan Hesaplaması \n");
        

        string operationChoice = Console.ReadLine();
        if(operationChoice.Contains('1')) Perimeter.Start();
        else if(operationChoice.Contains('2')) Area.Start();
        else {Error(); OperationChoice();}
    }

    public static void ShapesChoice()
    {
        Console.WriteLine("Lütfen işlem yapmak istediğiniz geometrik şekili seçiniz: \n" +
                          "********************************************************* \n" +
                          "(1) Dikdörtgen \n" +
                          "(2) Üçgen \n" +
                          "(3) Daire \n");       
    }
    
    public static void Error()
    {
        Console.WriteLine("Lütfen geçerli bir değer giriniz!");
    }
}
