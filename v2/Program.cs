using System;
using System.Linq;

struct Student
{
    public string LastName;         // Фамилия
    public string Initials;         // Инициалы
    public int GroupNumber;         // Номер группы
    public int[] Grades;            // Успеваемость (массив оценок)

    // Метод для расчета среднего балла
    public double GetAverageGrade()
    {
        return Grades.Average();
    }

    // Метод для проверки, что все оценки равны 4 или 5
    public bool HasOnlyHighGrades()
    {
        return Grades.All(grade => grade >= 4);
    }
}

class Program
{
    static void Main()
    {
        // Создание массива студентов
        Student[] students = new Student[10];

        // Инициализация студентов (пример данных)
        students[0] = new Student { LastName = "Ньютон", Initials = "И.A.", GroupNumber = 1000-7, Grades = new int[] { 5, 5, 4, 4, 5 } };
        students[1] = new Student { LastName = "Эйнштейн", Initials = "А.Г.", GroupNumber = 228, Grades = new int[] { 3, 4, 4, 5, 5 } };
        students[2] = new Student { LastName = "Максвелл", Initials = "Д.К.", GroupNumber = 13, Grades = new int[] { 4, 4, 4, 4, 4 } };
        students[3] = new Student { LastName = "Пастер", Initials = "Л.Ж.", GroupNumber = 228, Grades = new int[] { 5, 5, 5, 5, 5 } };
        students[4] = new Student { LastName = "Дарвин", Initials = "Ч.Р.", GroupNumber = 007, Grades = new int[] { 4, 4, 4, 4, 5 } };
        students[5] = new Student { LastName = "Кюри", Initials = "М.В.", GroupNumber = 777, Grades = new int[] { 3, 3, 4, 4, 3 } };
        students[6] = new Student { LastName = "Тесла", Initials = "Н.М.", GroupNumber = 1337, Grades = new int[] { 5, 5, 5, 5, 5 } };
        students[7] = new Student { LastName = "Бор", Initials = "Н.Х.", GroupNumber = 1234, Grades = new int[] { 3, 3, 4, 4, 4 } };
        students[8] = new Student { LastName = "Галилей", Initials = "Г.В.", GroupNumber = 999, Grades = new int[] { 4, 5, 5, 5, 5 } };
        students[9] = new Student { LastName = "Менделеев", Initials = "Д.И.", GroupNumber = 1505, Grades = new int[] { 5, 4, 5, 5, 5 } };

        // Сортировка студентов по возрастанию среднего балла
        var sortedStudents = students.OrderBy(s => s.GetAverageGrade()).ToArray();

        Console.WriteLine("Студенты, отсортированные по возрастанию среднего балла:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"{student.LastName} {student.Initials}, Группа: {student.GroupNumber}, Средний балл: {student.GetAverageGrade():F2}");
        }

        Console.WriteLine("\nСтуденты, имеющие оценки только 4 или 5:");
        foreach (var student in sortedStudents)
        {
            if (student.HasOnlyHighGrades())
            {
                Console.WriteLine($"{student.LastName}, Группа: {student.GroupNumber}");
            }
        }
    }
}