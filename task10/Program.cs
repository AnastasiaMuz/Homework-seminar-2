// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine ("Введите трехзначное число: ");
string number = (Console.ReadLine ());
char[] chars = number.ToCharArray(1,1);
Console.WriteLine (chars);
