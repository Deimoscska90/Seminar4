//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int GetNumber(string message)
{
int result = 0;

while(true)
{
Console.WriteLine(message);
if(int.TryParse(Console.ReadLine(), out result))
{
break;
}
else
{
Console.WriteLine("Ввели не корректное число. Повторите ввод");
}
}
return result;
}

int GetSum(int number)
{
int sum = 0;
while (number > 0)
{
    sum += number % 10;
    number /= 10;
}
return sum;
}

int number = GetNumber("Введите число: ");
int sum = GetSum(number);

Console.WriteLine($"{sum}");


