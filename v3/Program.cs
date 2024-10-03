using System;

// Абстрактный класс "Геометрическая фигура"
abstract class Shape
{
    // Абстрактный метод для вычисления площади
    public abstract double GetArea();
}

// Класс "Круг" наследует "Геометрическую фигуру"
class Circle : Shape
{
    private double radius;

    // Конструктор для установки радиуса
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Реализация метода для вычисления площади круга
    public override double GetArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}

// Класс "Прямоугольник" наследует "Геометрическую фигуру"
class Rectangle : Shape
{
    private double width;
    private double height;

    // Конструктор для установки ширины и высоты
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    // Реализация метода для вычисления площади прямоугольника
    public override double GetArea()
    {
        return width * height;
    }
}

// Класс "Треугольник" наследует "Геометрическую фигуру"
class Triangle : Shape
{
    private double baseLength;
    private double height;

    // Конструктор для установки основания и высоты
    public Triangle(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    // Реализация метода для вычисления площади треугольника
    public override double GetArea()
    {
        return 0.5 * baseLength * height;
    }
}

// Тестирование классов
class Program
{
    static void Main()
    {
        // Создание объектов различных фигур
        Shape circle = new Circle(10);
        Shape rectangle = new Rectangle(10, 5);
        Shape triangle = new Triangle(12, 4);

        // Вывод площади каждой фигуры
        Console.WriteLine("Площадь круга: " + circle.GetArea());
        Console.WriteLine("Площадь прямоугольника: " + rectangle.GetArea());
        Console.WriteLine("Площадь треугольника: " + triangle.GetArea());
    }
}