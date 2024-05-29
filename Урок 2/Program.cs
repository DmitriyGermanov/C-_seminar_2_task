using Task_00;

internal class Program
{
    private static void Main(string[] args)
    {
        long a = 5;
        int b = 6;
        byte c = 7;
        Bits bits = a;
        Bits bits2 = b;
        Bits bits3 = c;
        Console.WriteLine($"""
                            Проверка неявного приведения типов: 
                            long = {bits}
                            int = {bits2}
                            byte = {bits3} 
                            """);
    }
}