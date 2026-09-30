namespace Lab5
{
    public class SimpleEuler
    {
        public static void Run()
        {
            Console.WriteLine("Enter parameters.");
            Console.Write("Total time (T): ");
            double T = InputHandler.ReadDouble(0, double.MaxValue);
            Console.Write("Total intervals (N): ");
            int N = InputHandler.ReadInt(0, int.MaxValue);
            Console.Write("Starting position (y_0): ");
            double y0 = InputHandler.ReadDouble();
            Console.Write("Starting velocity (v_0): ");
            double v0 = InputHandler.ReadDouble();
            Console.Write("Starting acceleration (a_0): ");
            double a0 = InputHandler.ReadDouble();

            double t = 0;
            double a = a0;
            double v = v0;
            double y = y0;
            double dt = T / N;

            Console.WriteLine();
            Console.WriteLine("    i    |    t    |    a    |    v    |    y    ");
            Console.WriteLine("-------------------------------------------------");

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($" {i:N6} | {t:N6} | {a:N6} | {v:N6} | {y:N6} ");

                t = t + dt;
                y = y + v * dt;
                v = v + a * dt;
            }
        }
    }
}