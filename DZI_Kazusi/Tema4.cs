using System;
using System.Globalization;
using System.Collections.Generic;

public abstract class ColoredFigure {
    protected string color;
    protected double size;

    public ColoredFigure(string color, double size) {
        this.color = color;
        this.size = size;
    }

    public void Show() {
        Console.WriteLine("Color: {0}", this.color);
        Console.WriteLine("Size: {0}", this.size);
    }

    public abstract string GetName();
    public abstract double GetArea();
}

public class Square : ColoredFigure {
    public Square(string color, double size) : base(color, size) { }

    public override double GetArea() {
        return Math.Pow(base.size, 2.0);
    }

    public override string GetName() {
        return "Square";
    }
}

public class Triangle : ColoredFigure {
    public Triangle(string color, double size) : base(color, size) { }

    public override double GetArea() {
        return (Math.Pow(size, 2.0) * Math.Sqrt(3)) / 4.0;
    }

    public override string GetName() {
        return "Triangle";
    }
}

public class Circle : ColoredFigure {
    public Circle(string color, double size) : base(color, size) { }

    public override double GetArea() {
        return Math.PI * Math.Pow(base.size, 2.0);
    }

    public override string GetName() {
        return "Circle";
    }
}

public class Tema4 {
    public void Run() {
        int n = int.Parse(Console.ReadLine());

        // Store input in a list to delay output
        List<ColoredFigure> figures = new List<ColoredFigure>();

        for (int i = 0; i < n; i++) {
            var cmd = Console.ReadLine().Split();
            string shapeType = cmd[0];
            string color = cmd[1];
            double size = double.Parse(cmd[2], CultureInfo.InvariantCulture);

            ColoredFigure shape = shapeType switch {
                "Circle" => new Circle(color, size),
                "Square" => new Square(color, size),
                "Triangle" => new Triangle(color, size),
                _ => throw new ArgumentException("Invalid shape type")
            };

            figures.Add(shape);
        }

        // Now display the output **after all input is collected**
        foreach (var shape in figures) {
            Console.WriteLine($"{shape.GetName()}:");
            shape.Show();
            Console.WriteLine("Area: {0:F2}", shape.GetArea().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
