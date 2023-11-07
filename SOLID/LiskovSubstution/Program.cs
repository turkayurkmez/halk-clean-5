// See https://aka.ms/new-console-template for more information
using LiskovSubstution;

//Console.WriteLine("Hello, World!");
//Square square = new Square();
//square.Width = 5;
//Console.WriteLine(square.GetArea());
//Rectangle rectangle = new Rectangle();
//rectangle.Width = 5;
//rectangle.Height = 15;
//Console.WriteLine(rectangle.GetArea());


var rect = new Geometry().GetShape(5, 3);

//rect.Width = 10;
//rect.Height = 8;

Console.WriteLine(rect.GetArea());

var sqr = new Geometry().GetShape(5);
Console.WriteLine(sqr.GetArea());
