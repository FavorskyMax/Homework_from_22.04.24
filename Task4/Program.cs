// Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.

Console.Write("Напиши натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

string numberAsString = N.ToString(); // Преобразуем число в строку

for (int i = 0; i < numberAsString.Length; i++)
{
    Console.Write(numberAsString[i]); // Выводим текущую цифру

    if (i != numberAsString.Length - 1) // Добавляем запятую после каждой цифры, кроме последней
    {
        Console.Write(",");
    }
}

Console.WriteLine(); // Переходим на новую строкуg