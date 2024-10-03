using System;

// Интерфейс IDrawable с методом Draw()
interface IDrawable
{
    void Draw();
}

// Класс Circle, реализующий интерфейс IDrawable
class Circle : IDrawable
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Реализация метода Draw() для круга
    public void Draw()
    {
        Console.WriteLine($"Рисуем круг с радиусом: {radius}");
    }
}

// Класс Rectangle, реализующий интерфейс IDrawable
class Rectangle : IDrawable
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    // Реализация метода Draw() для прямоугольника
    public void Draw()
    {
        Console.WriteLine($"Рисуем прямоугольник с шириной: {width} и высотой: {height}");
    }
}

// Класс Triangle, реализующий интерфейс IDrawable
class Triangle : IDrawable
{
    private double baseLength;
    private double height;

    public Triangle(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    // Реализация метода Draw() для треугольника
    public void Draw()
    {
        Console.WriteLine($"Рисуем треугольник с основанием: {baseLength} и высотой: {height}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем массив объектов, реализующих интерфейс IDrawable
        IDrawable[] drawableObjects = new IDrawable[]
        {
            new Circle(8),
            new Rectangle(6, 12),
            new Triangle(6, 9)
        };

        // Вызов метода Draw() для каждого объекта в массиве
        foreach (IDrawable drawable in drawableObjects)
        {
            drawable.Draw();
        }
    }
}