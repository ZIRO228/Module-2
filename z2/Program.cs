using System;

class Shape
{
    // Метод для расчета площади (заглушка, переопределяется в наследниках)
    public virtual double Area()
    {
        return 0;
    }

    // Метод для расчета периметра (заглушка, переопределяется в наследниках)
    public virtual double Perimeter()
    {
        return 0;
    }
}

class Circle : Shape
{
    private double radius;

    // Конструктор для инициализации радиуса
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Переопределение метода для расчета площади круга
    public override double Area()
    {
        return Math.PI * radius * radius;
    }

    // Переопределение метода для расчета периметра круга (длины окружности)
    public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }
}

class Rectangle : Shape
{
    private double width;
    private double height;

    // Конструктор для инициализации сторон прямоугольника
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    // Переопределение метода для расчета площади прямоугольника
    public override double Area()
    {
        return width * height;
    }

    // Переопределение метода для расчета периметра прямоугольника
    public override double Perimeter()
    {
        return 2 * (width + height);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объекта круга с радиусом 10
        Circle circle = new Circle(10);
        Console.WriteLine($"Площадь круга: {circle.Area():F2}");
        Console.WriteLine($"Периметр круга: {circle.Perimeter():F2}");

        // Создание объекта прямоугольника с шириной 5 и высотой 10
        Rectangle rectangle = new Rectangle(5, 10);
        Console.WriteLine($"\nПлощадь прямоугольника: {rectangle.Area():F2}");
        Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter():F2}");
    }
}