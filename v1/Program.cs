using System;

class Car
{
    // Поля для хранения информации об автомобиле
    public string Make { get; set; }  // Марка
    public string Model { get; set; } // Модель
    public int Year { get; set; }     // Год выпуска
    public decimal Price { get; set; } // Цена

    // Конструктор для инициализации объекта автомобиля
    public Car(string make, string model, int year, decimal price)
    {
        Make = make;
        Model = model;
        Year = year;
        Price = price;
    }

    // Метод для расчета цены с учетом скидки
    public decimal CalculatePriceWithDiscount(decimal discountPercentage)
    {
        if (discountPercentage < 0 || discountPercentage > 100)
        {
            Console.WriteLine("Скидка должна быть от 0 до 100%.");
            return Price;
        }
        decimal discountAmount = Price * (discountPercentage / 100);
        return Price - discountAmount;
    }

    // Метод для расчета стоимости с учетом налога (НДС)
    public decimal CalculatePriceWithTax(decimal taxPercentage)
    {
        if (taxPercentage < 0)
        {
            Console.WriteLine("Налог не может быть отрицательным.");
            return Price;
        }
        decimal taxAmount = Price * (taxPercentage / 100);
        return Price + taxAmount;
    }

    // Метод для расчета цены с учетом скидки и налога
    public decimal CalculateFinalPrice(decimal discountPercentage, decimal taxPercentage)
    {
        decimal priceWithDiscount = CalculatePriceWithDiscount(discountPercentage);
        return priceWithDiscount + (priceWithDiscount * (taxPercentage / 100));
    }

    // Метод для вывода информации об автомобиле
    public void PrintCarInfo()
    {
        Console.WriteLine($"Марка: {Make}, Модель: {Model}, Год: {Year}, Цена: {Price:C}");
    }
}

class Program
{
    static void Main()
    {
        // Создание объекта автомобиля
        Car car1 = new Car("Toyota", "Camry", 2020, 100000);

        // Вывод исходной информации об автомобиле
        Console.WriteLine("Исходная информация об автомобиле:");
        car1.PrintCarInfo();

        // Рассчитываем цену с учетом скидки
        decimal discount = 10; // 10% скидка
        decimal priceWithDiscount = car1.CalculatePriceWithDiscount(discount);
        Console.WriteLine($"\nЦена с учетом скидки {discount}%: {priceWithDiscount:C}");

        // Рассчитываем цену с учетом НДС
        decimal tax = 20; // 20% НДС
        decimal priceWithTax = car1.CalculatePriceWithTax(tax);
        Console.WriteLine($"Цена с учетом НДС {tax}%: {priceWithTax:C}");

        // Рассчитываем итоговую цену с учетом скидки и НДС
        decimal finalPrice = car1.CalculateFinalPrice(discount, tax);
        Console.WriteLine($"\nИтоговая цена с учетом скидки {discount}% и НДС {tax}%: {finalPrice:C}");
    }
}