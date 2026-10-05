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


// using System.ComponentModel;

// string correctPassword = "qwerty123";
// int count = 0;

// while (true)
// {
//     Console.Write("Введите пароль от личного кабинета:");
//     string password = Console.ReadLine();

//     if (password == correctPassword)
//     {
//         Console.WriteLine("Доступ разрешен");
//         break;
//     }
//     Console.WriteLine("Неверный пароль, попробуйте снова: ");
//     count++;
// }
// Console.WriteLine(count);


// string answer;

// do
// {
//     Console.Write("Введите дату посещения (например, 01.09):");
//     string date = Console.ReadLine();
//     Console.WriteLine($"Запись добавлена: {date}");

//     Console.Write("Добавить еще одну запись? (да/нет): ");
//     answer = Console.ReadLine();
// } while (answer == "да");

// Console.WriteLine("Дневник сохранен");

// // Задача А
// int n = 7;
// int count = 1;
// while (count <= 10)
// {
//     Console.WriteLine($"{n} * {count} = {n * count}");
//     count++;
// }


// // Задача Б
// Console.WriteLine("vvedite name");
// int count = 0;
// string name = Console.ReadLine();
// while (name != "конец")
// {
//     name = Console.ReadLine();
//     count++;
// }
// Console.WriteLine(count);


// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// // Вариант 1
// int n = 5;
// while (n >= 1)
// {
//     Console.WriteLine(n);
//     n--;
// }
// Console.WriteLine("Старт!");


//Вариант 10
int count5 = 0;
int grade = int.Parse(Console.ReadLine());
while (grade != -1)
{
    if (grade == 5)
        count5++;
    grade = int.Parse(Console.ReadLine());
    
}
Console.WriteLine(count5);