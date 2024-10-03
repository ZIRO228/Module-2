using System;

class Person
{
    // Поля класса
    private string name;
    private int age;
    private string address;

    // Конструктор для инициализации объекта
    public Person(string name, int age, string address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }

    // Методы для получения значений
    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }

    public string GetAddress()
    {
        return address;
    }

    // Методы для установки значений
    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }

    public void SetAddress(string address)
    {
        this.address = address;
    }

    // Метод для вывода информации о человеке
    public void PrintInfo()
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}, Адрес: {address}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объектов класса Person
        Person person1 = new Person("Бэтмэн", 14, "Луна, ул. Патриотова, д.2");
        Person person2 = new Person("Иваныч", 50, "Орша, ул. Пушкина, д.9б");

        // Вывод информации о каждом объекте
        person1.PrintInfo();
        person2.PrintInfo();

        // Изменение значений через методы установки
        person1.SetName("Полупокер");
        person1.SetAge(32);
        person1.SetAddress("Барань, ул. Колотушкина, д.007");

        // Вывод обновленной информации
        person1.PrintInfo();
    }
}