// Напишите программу, которая принимает на вход целое число
//  из отрезка [10, 99] и показывает наибольшую цифру числа.


Console.Write("Напиши перую цифру целого числа из отрезка [10,99]: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.Write("Напиши вторую цифру целого числа из отрезка [10,99]: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Целое число: " + firstDigit + "" + secondDigit);

int num = firstDigit * 10 + secondDigit; // Вычисляем число, учитывая позиции цифр

if (num >= 10 && num <= 99)
{
    if (firstDigit > secondDigit)
    {
        Console.WriteLine("Наибольшая цифра из числа: " + firstDigit);
    }
    else
    {
        Console.WriteLine("Наибольшая цифра из числа: " + secondDigit);
    }
}
else
{
    Console.WriteLine("Не корректный ввод!");
}