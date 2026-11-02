namespace MagicNumberGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generator gen = new Generator();
            gen.SetUpGenerator(-1);
            //Console.WriteLine(gen.StartCalculation());

            Console.WriteLine(gen.StartLongCalculation());

            Console.WriteLine(gen.StartComplexCalculation());
        }
    }
}
