// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string message)
{
    System.Console.Write($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int number = Prompt("Введите трехзначное число");

if (number >= 100&& number < 1000)
{
    int result = number / 10 % 10;
    System.Console.WriteLine($"Вторая цифра числа {result}"); 
}
else
{
    System.Console.WriteLine("число не соответствует обозначеным критериям");
}