using System;

class Author
{
    // Поля для хранения имени автора и года рождения
    public string Name { get; set; }
    public int BirthYear { get; set; }

    // Конструктор для инициализации данных автора
    public Author(string name, int birthYear)
    {
        Name = name;
        BirthYear = birthYear;
    }

    // Метод для вывода информации об авторе
    public void PrintInfo()
    {
        Console.WriteLine($"Автор: {Name}, Год рождения: {BirthYear}");
    }
}

class Book
{
    // Поля для хранения информации о книге
    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public Author BookAuthor { get; set; }  // Композиция: связь с объектом Author

    // Конструктор для инициализации данных книги
    public Book(string title, int releaseYear, Author author)
    {
        Title = title;
        ReleaseYear = releaseYear;
        BookAuthor = author;
    }

    // Метод для вывода информации о книге
    public void PrintInfo()
    {
        Console.WriteLine($"Книга: {Title}, Год выпуска: {ReleaseYear}");
        BookAuthor.PrintInfo();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объектов авторов
        Author author1 = new Author("Джон Рональд Руэл Толкин", 1892);
        Author author2 = new Author("Фёдор Достоевский", 1821);

        // Создание объектов книг, связанных с авторами
        Book book1 = new Book("Властелин колец", 1954, author1);
        Book book2 = new Book("Идиот", 1868, author2);
        Book book3 = new Book("Хоббит, или Туда и обратно", 1937, author1);

        // Вывод информации о книгах и их авторах
        book1.PrintInfo();
        Console.WriteLine();
        book2.PrintInfo();
        Console.WriteLine();
        book3.PrintInfo();
    }
}