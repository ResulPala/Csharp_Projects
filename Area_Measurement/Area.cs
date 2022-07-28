public class Area
{
    public static void Start()
    {
        Choices.ShapesChoice();
        string shape = Console.ReadLine();

        if(shape.Contains('1')) Rectangular();
        else if(shape.Contains('2')) Triangle();
        else if(shape.Contains('3')) Circle();
        else {Choices.Error(); Start();}
    }
    public static void Rectangular()
    {
        Console.WriteLine("Lütfen kısa kenar uzunluğunu giriniz: ");
        double kisaKenar = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Lütfen uzun kenar uzunluğunu giriniz: ");
        double uzunKenar = Convert.ToDouble(Console.ReadLine());

        double area = kisaKenar * uzunKenar;
        Console.WriteLine("\nUzunlukları girilen dikdörtgenin alanı {0} birim karedir.", area);
    }

    public static void Triangle()
    {
        Console.WriteLine("Lütfen 1. kenar uzunluğunu giriniz: ");
        double birinciKenar = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Lütfen 2. kenar uzunluğunu giriniz: ");
        double ikinciKenar = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Lütfen 3. kenar uzunluğunu giriniz: ");
        double ucuncuKenar = Convert.ToDouble(Console.ReadLine());

        double halfPerimeter = (birinciKenar + ikinciKenar + ucuncuKenar) / 2;
        double area = Math.Sqrt(halfPerimeter * (halfPerimeter - birinciKenar) * (halfPerimeter - ikinciKenar) * (halfPerimeter - ucuncuKenar));
        Console.WriteLine("\nUzunlukları girilen üçgenin alanı {0} birim karedir.", area);
    }

    public static void Circle()
    {
        Console.WriteLine("Lütfen yarıçap uzunluğunu giriniz: ");
        double yaricap = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * yaricap * yaricap;

        Console.WriteLine("\n{0} birim yarıçaplı dairenin alanı {1} birim karedir.", yaricap,area);
    }
}