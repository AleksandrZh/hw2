namespace hw2
{
    public struct Distance
    {
        public int feet;
        public double inch;

    }
    internal class DistanceProj
    {
        static void Main(string[] args)
        {
            int z;
            int x;
            Distance a1, a2, a3;
            Console.Write("Enter a1- feet: ");
            a1.feet = int.Parse(Console.ReadLine());

            Console.Write("Enter a1 - inch: ");
            a1.inch = int.Parse(Console.ReadLine());


            Console.Write("Enter a2 - feet: ");
            a2.feet = int.Parse(Console.ReadLine());

            Console.Write("Enter a2 - inch: ");
            a2.inch = int.Parse(Console.ReadLine());

            a3.inch = a1.inch + a2.inch;

            z = (int)(a3.inch % 12);

            x = (int)(a3.inch / 12);

            a3.feet = a1.feet + a2.feet + x;



            Console.WriteLine($"Sum{a3.feet}' - {z}\" ");



        }
    }
}