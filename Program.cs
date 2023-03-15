//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6



Random rnd = new Random();
int number =rnd.Next(100, 1000);
System.Console.WriteLine(number);

if (number >= 100 && number < 1000)
{
    int result = number / 100;
    int result2 = number / 10 % 10;
    int answer = result * 10 + result2;
    System.Console.WriteLine($"Вторая цифра случайного числа стерта! {answer}");
}
