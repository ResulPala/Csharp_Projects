public class Perimeter
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

        double perimeter = 2*(kisaKenar+uzunKenar);
        Console.WriteLine("\nUzunlukları girilen dikdörtgenin çevre uzunluğu {0} birimdir.", perimeter);
    }

    public static void Triangle()
    {
        Console.WriteLine("Lütfen 1. kenar uzunluğunu giriniz: ");
        double birinciKenar = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Lütfen 2. kenar uzunluğunu giriniz: ");
        double ikinciKenar = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Lütfen 3. kenar uzunluğunu giriniz: ");
        double ucuncuKenar = Convert.ToDouble(Console.ReadLine());

        double perimeter = birinciKenar + ikinciKenar + ucuncuKenar;
        Console.WriteLine("\nUzunlukları girilen üçgenin uzunluğu {0} birimdir.", perimeter);
    }

    public static void Circle()
    {
        Console.WriteLine("Lütfen yarıçap uzunluğunu giriniz: ");
        double yaricap = Convert.ToDouble(Console.ReadLine());

        double perimeter = 2 * Math.PI * yaricap;
        Console.WriteLine("\n{0} birim yarıçaplı dairenin çevre uzunluğu {1} birimdir.", yaricap,perimeter);
    }
}