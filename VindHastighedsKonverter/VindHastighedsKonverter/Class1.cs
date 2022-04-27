namespace VindHastighedsKonverter
{
    internal class Methods
    {

        public void Ms_Km()
        {
            Console.WriteLine("Input = m/sec");
            int ms = Convert.ToInt32(Console.ReadLine());
            var ConvertedMs = (ms * 18) / 5;
            Console.WriteLine(ConvertedMs);
        }
        public void Mps_K()
        {
            Console.WriteLine("Input = Mps");
            int mph = Convert.ToInt32(Console.ReadLine());
            var convertedMph = (mph * 0.868976);
            Console.WriteLine(convertedMph);
        }

    }
}
