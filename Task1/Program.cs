// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Напиши число: ");
int a =Convert.ToInt32(Console.ReadLine());
int firstDigit = 7;
int secondDigit = 23;

if (a % firstDigit == 0 && a % secondDigit == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}