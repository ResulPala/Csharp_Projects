internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Start();
    }

    public static void Start()
    {
        try
        {
            Console.WriteLine("Lütfen kelimelerden oluşan ve kelimelerin arasında boşluk olan bir dizi giriniz: ");
            string[] strArray = Console.ReadLine().Split();

            foreach (var item in strArray)
            {
                char[] cArray = item.ToCharArray();
                char carrier = cArray[0];
                cArray[0] = cArray[cArray.Length - 1];
                cArray[cArray.Length - 1] = carrier;

                string strSum = null;
                foreach (var c in cArray)
                    strSum += c.ToString();
                Console.Write(strSum + " ");
            }

        }
        catch (System.Exception)
        {
            ErrorMessage();
            Start();
        }   

        EndingApp(); 
    }

    public static void ErrorMessage()
    {
        Console.WriteLine("Lütfen geçerli değer giriniz!");
    }

    public static void EndingApp()
    {
        Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz: \n" +
                          "********************************************************* \n" +
                          "(1) Programı sonlandır \n" +
                          "(2) Programı tekrar başlat \n");  

        string choice = Console.ReadLine();
        if(choice.Contains('1')) Environment.Exit(0);
        else if(choice.Contains('2')) Start();
        else {ErrorMessage(); EndingApp();}
    }
}