namespace structs
{
    class Rectangle
    {
        public int shortEdge;
        public int longEdge;

        public int CalcArea()
        {
            return this.shortEdge * this.longEdge;
        }
    }

    struct RectangleStruct
    {
        public int shortEdge;
        public int longEdge;

        public int CalcArea()
        {
            return this.shortEdge * this.longEdge;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.shortEdge = 3;
            rectangle.longEdge = 4;
            Console.WriteLine("Rectangle class Area Calc: " + rectangle.CalcArea());

            RectangleStruct rectangleStruct;
            rectangleStruct.shortEdge = 3;
            rectangleStruct.longEdge=4;
            Console.WriteLine("Rectangle struct Area Calc: " + rectangleStruct.CalcArea());

        }
    }
}