using GeometricShapes;

var q1 = new Quad() { Side1 = 3, Side2 = 4, Side3 = 5, Side4 = 6 };

Console.WriteLine(q1.Perimeter());

var r1 = new Rect() { Side1 = 3, Side2 = 4 };

Console.WriteLine($"{r1.Perimeter()} | {r1.area()}");

var s1 = new Square() { side1 = 5};

Console.WriteLine($"{s1.Perimeter()} | {s1.area()}");