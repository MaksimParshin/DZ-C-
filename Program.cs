//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString();
char digit2 = str[1];
string newStr = digit2.ToString();
int newNumber = Convert.ToInt32(newStr);
Console.WriteLine(newNumber);

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 99)
{
    string str1 = N.ToString();
    char digit3 = str[2];
    string newS = digit3.ToString();
    int newN = Convert.ToInt32(newS);
    Console.WriteLine(newN);
}
else
{
     Console.WriteLine("третьей цифры нет");
}

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 6 || n == 7)
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}
