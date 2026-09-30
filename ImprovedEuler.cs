namespace Lab5
{
    public class ImprovedEuler
    {
        public static void Run()
        {
            Console.WriteLine("Enter parameters.");
            Console.WriteLine("-----------------");
            Console.Write("Total time (T): ");
            double T = InputHandler.ReadDouble(0, double.MaxValue);
            Console.Write("Total intervals (N): ");
            int N = InputHandler.ReadInt(0, int.MaxValue);
            Console.Write("Starting position (y_0): ");
            double y0 = InputHandler.ReadDouble();
            Console.Write("Starting velocity (v_0): ");
            double v0 = InputHandler.ReadDouble();
            Console.Write("Gravitational acceleration (g): ");
            double g = InputHandler.ReadDouble();

            double t = 0;
            double a = g;
            double v = v0;
            double y = y0;
            double dt = T / N;

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("      i      |      t      |      a      |      v      |      y      ");
            Console.WriteLine("---------------------------------------------------------------------");

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($" {i,11} | {t,11:N3} | {a,11:N6} | {v,11:N6} | {y,11:N6} ");

                t = t + dt;
                double vi = v + a * dt;
                y = y + (vi + v) / 2 * dt;
                v = vi;
            }
        }
    }
}