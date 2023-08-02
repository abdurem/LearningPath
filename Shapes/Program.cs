using Shapes;

namespace Main
{
    class Program{
        static void Main(){
            Circle circle = new (1);
            
            circle.SetRadius(5);
            circle.PrintShape(circle);

            Rectangle rectangle = new (1, 1);

            rectangle.SetWidth(5);
            rectangle.SetHeight(5);

            rectangle.PrintShape(rectangle);

            Triangle triangle = new (1, 1);

            triangle.SetBase(5);
            triangle.SetHeight(5);

            triangle.PrintShape(triangle);
        }
    }
}