using ConsoleApp18;

using ConsoleApp18.Daire;

Shape circle = new Circle(5);
Shape square = new Square(4);
Shape triangle = new Triangle(3, 6);
Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
Console.WriteLine($"Square Area: {square.CalculateArea()}");
Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}");
