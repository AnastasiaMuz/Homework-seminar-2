// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine ("Введите число: ");
string number = (Console.ReadLine ());

char[] chars = number.ToArray();
if (chars.Length < 2)
{
    Console.WriteLine (" третьей цифры нет");
}
char[] result = number.ToCharArray (2,1);
Console.WriteLine (result);
