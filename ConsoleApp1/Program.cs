using NUnitLite;
using TestTaskShape;

new AutoRun(typeof(ShapeTests).Assembly).Execute(args);

IShape circle = new Circle(5);
double circleArea = circle.CalculateArea();
Console.WriteLine("Площадь круга: " + circleArea);

IShape triangle = new Triangle(3, 4, 5);
double triangleArea = triangle.CalculateArea();
Console.WriteLine("Площадь треугольника: " + triangleArea);

bool isRightAngled = (triangle as Triangle).IsRightAngledTriangle();
Console.WriteLine("Треугольник прямоугольный: " + isRightAngled);