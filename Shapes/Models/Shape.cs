namespace Shapes{
    class Shape{
        protected string? Name { get; set; }

        public virtual double CalculateArea(){
            return 0;
        }

        public virtual void PrintShape(Shape shape){
            Console.WriteLine($"This is a {shape.Name}");

            if(shape is Circle){
                Console.WriteLine($"The area of this circle is {shape.CalculateArea()}");
            }
            else if(shape is Rectangle){
                Console.WriteLine($"The area of this rectangle is {shape.CalculateArea()}");
            }
            else if(shape is Triangle){
                Console.WriteLine($"The area of this triangle is {shape.CalculateArea()}");
            }

        }
    }

    class Circle: Shape{
        private double radius;

        public Circle(){
            Name = "Circle";
        }

        public Circle(double radius){
            Name = "Circle";
            this.radius = radius;
        }

        public override double CalculateArea(){
            return Math.PI * radius * radius;
        }

        public void SetRadius(double radius){
            this.radius = radius;
        }

        public double GetRadius(){
            return radius;
        }
    }

    class Rectangle: Shape{
        private double width;
        private double height;

        public Rectangle(){
            Name = "Rectangle";
        }

        public Rectangle(double width, double height){
            Name = "Rectangle";
            this.width = width;
            this.height = height;
        }
        public override double CalculateArea(){
            return width * height;
        }

        public void SetWidth(double width){
            this.width = width;
        }

        public double GetWidth(){
            return width;
        }

        public void SetHeight(double height){
            this.height = height;
        }

        public double GetHeight(){
            return height;
        }
    }

    class Triangle: Shape{
        private double base_;
        private double height;

        public Triangle(){
            Name = "Triangle";
        }

        public Triangle(double base_, double height){
            Name = "Triangle";
            this.base_ = base_;
            this.height = height;
        }

        public override double CalculateArea(){
            return 0.5 * base_ * height;
        }

        public void SetBase(double base_){
            this.base_ = base_;
        }

        public double GetBase(){
            return base_;
        }

        public void SetHeight(double height){
            this.height = height;
        }

        public double GetHeight(){
            return height;
        }
    }
}