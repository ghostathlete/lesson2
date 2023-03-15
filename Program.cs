//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

int Prompt(string message)
{
    System.Console.Write($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int number = Prompt("Введите число дня недели");

if (number >8)
{
    System.Console.WriteLine($"данное число не является днем недели");
}
if (number <=7 && number >5)
{
    System.Console.WriteLine($"данное число является выходным днем недели");
}
if (number <6 && number >0)
{
    System.Console.WriteLine($"данное число не является выходным днем недели");
}
