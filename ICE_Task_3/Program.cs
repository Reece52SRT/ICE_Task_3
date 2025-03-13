namespace ICE_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rt = new Rectangle("Quadrilateral", 12, 5);
            rt.Display();
            rt.ICalculateArea();

            Circle cl = new Circle("Round Object", 12);
            cl.Display();
            cl.ICalculateArea();
            Console.ReadKey();
        }
    }
}
