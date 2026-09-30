using Lab5;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Which method do you want to use?");
        Console.WriteLine("1 => Simple Euler's Method");
        Console.WriteLine("2 => Improved Euler's Method");
        Console.WriteLine("3 => Simple Euler's Method (With Air Resistance)");
        Console.WriteLine();

        int input = InputHandler.ReadDigit(1, 3);

        switch (input)
        {
            case 1:
                SimpleEuler.Run();
                break;
            case 2:
                ImprovedEuler.Run();
                break;
            case 3:
                SimpleWithAirResistance.Run();
                break;
        }
    }
}