namespace Lab5
{
    public static class InputHandler
    {
        public static int ReadDigit()
        {
            bool valid;
            int input;
            do
            {
                valid = int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out input);
            } while (!valid);
            Console.WriteLine(input);

            return input;
        }

        public static int ReadDigit(int min, int max)
        {
            bool valid;
            int input;
            do
            {
                valid = int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out input);
                if (valid)
                {
                    if (input < min || input > max)
                        valid = !valid;
                }
            } while (!valid);
            Console.WriteLine(input);

            return input;
        }

        public static int ReadInt()
        {
            bool valid;
            int input;
            do
            {
                valid = int.TryParse(Console.ReadLine(), out input);
            } while (!valid);

            return input;
        }

        public static int ReadInt(int min, int max)
        {
            bool valid;
            int input;
            do
            {
                valid = int.TryParse(Console.ReadLine(), out input);
                if (valid)
                {
                    if (input < min || input > max)
                        valid = !valid;
                }
            } while (!valid);

            return input;
        }

        public static double ReadDouble()
        {
            bool valid;
            double input;
            do
            {
                valid = double.TryParse(Console.ReadLine(), out input);
            } while (!valid);

            return input;
        }

        public static double ReadDouble(double min, double max)
        {
            bool valid;
            double input;
            do
            {
                valid = double.TryParse(Console.ReadLine(), out input);
                if (valid)
                {
                    if (input < min || input > max)
                        valid = !valid;
                }
            } while (!valid);

            return input;
        }
    }
}