// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета

//456 -> 46
//782 -> 72
//918 -> 98


Random rnd = new Random();
int number =rnd.Next(100, 1000);
System.Console.WriteLine(number);

if (number >= 100 && number < 1000)
{
    int result = number / 100;
    int result2 = number / 10 % 10;
    System.Console.WriteLine($"Вторая цифра случайного числа стерта! {result} {result2}");
}
