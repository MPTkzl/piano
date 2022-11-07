namespace ПрактическаяПиано
{
    internal class Program
    {
        public static string currentOctaveName = "small Octave";
        static void Main(string[] args)
        {
            double[]? currentOctave = SwitchOctave("F1");
            while (true)
            {
                Console.WriteLine("Чтобы сменить октаву нажмите: F1, F2, F3");
                Console.WriteLine($"Выбранная октава: {currentOctaveName}");
                var currentKey = Console.ReadKey();
                switch (currentKey.Key)
                {
                    case ConsoleKey.F1:
                        currentOctave = SwitchOctave("F1");
                        break;
                    case ConsoleKey.F2:
                        currentOctave = SwitchOctave("F2");
                        break;
                    case ConsoleKey.F3:
                        currentOctave = SwitchOctave("F3");
                        break;
                    case ConsoleKey.Z:
                        PlayNote(0, currentOctave);
                        break;
                    case ConsoleKey.S:
                        PlayNote(1, currentOctave);
                        break;
                    case ConsoleKey.X:
                        PlayNote(2, currentOctave);
                        break;
                    case ConsoleKey.C:
                        PlayNote(3, currentOctave);
                        break;
                    case ConsoleKey.D:
                        PlayNote(4, currentOctave);
                        break;
                    case ConsoleKey.V:
                        PlayNote(5, currentOctave);
                        break;
                    case ConsoleKey.B:
                        PlayNote(6, currentOctave);
                        break;
                    case ConsoleKey.G:
                        PlayNote(7, currentOctave);
                        break;
                    case ConsoleKey.N:
                        PlayNote(8, currentOctave);
                        break;
                    case ConsoleKey.H:
                        PlayNote(9, currentOctave);
                        break;
                    case ConsoleKey.M:
                        PlayNote(10, currentOctave);
                        break;
                    case ConsoleKey.J:
                        PlayNote(11, currentOctave);
                        break;
                }
                Console.Clear();
            }
        }
        public static void PlayNote(int freqId, double[]? currentOctave)
        {
            Console.Beep((int)currentOctave[freqId], 500);
        }
        public static double[]? SwitchOctave(string keyInfo)
        {
            double[] smallOctave = new double[] { 130.8, 138.6, 146.8, 155.6, 164.8, 174.6, 185.0, 196.0, 207.7, 220.0, 233.1, 246.9 };
            double[] firstOctave = new double[] { 261.6, 277.2, 293.7, 311.1, 329.6, 349.2, 370.0, 392.0, 415.3, 440.0, 466.2, 493.9 };
            double[] secondctave = new double[] { 523.3, 554.4, 587.3, 622.3, 659.3, 698.5, 740.0, 784.0, 830.6, 880.0, 932.3, 987.8 };

            switch (keyInfo)
            {
                case "F1":
                    currentOctaveName = "Малая октава";
                    return smallOctave;
                case "F2":
                    currentOctaveName = "Первая октава";
                    return firstOctave;
                case "F3":
                    currentOctaveName = "Вторая октава";
                    return secondctave;

            }
            return null;
        }
    }
}