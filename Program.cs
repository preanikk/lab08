// int lessonNumber = 5;
// int totalLessons = 1;

// while (lessonNumber >= totalLessons){
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber--;
// }

// Console.WriteLine("Пары закончились");


// Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());
// int count = 0;
// while (grade != -1)
// {
//     Console.WriteLine($"Оценка принята: {grade}");
//     grade = int.Parse(Console.ReadLine());
//     count++;
// }
// Console.WriteLine("Ввод завершен");
// Console.WriteLine(count);


// int sum = 0;
// int count = 0;
// int max = 0;
// Console.WriteLine("Вводите оценки, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());
// while (grade != -1)
// {
//     if (grade > max)
//         max = grade;
//     sum += grade;
//     count++;
//     grade = int.Parse(Console.ReadLine());
// }

// if (count > 0)
// {
//     Console.WriteLine($"Средний балл: {(double)sum / count}");
// }
// else
// {
//     Console.WriteLine("Оценок не было введено");
// }
// Console.WriteLine(max);


using System.ComponentModel;

string correctPassword = "qwerty123";
int count = 0;

while (true)
{
    Console.Write("Введите пароль от личного кабинета:");
    string password = Console.ReadLine();

    if (password == correctPassword)
    {
        Console.WriteLine("Доступ разрешен");
        break;
    }
    Console.WriteLine("Неверный пароль, попробуйте снова: ");
    count++;
}
Console.WriteLine(count);