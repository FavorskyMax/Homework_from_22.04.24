﻿// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.Write("Задай координату X: ");
int X = Convert.ToInt32(Console.ReadLine());

Console.Write("Задай координату Y: ");
int Y = Convert.ToInt32(Console.ReadLine());
if (X != 0 && Y != 0)                                     //  if (X > 0 && Y > 0)
{                                                         //   { 
    if (X > 0 && Y > 0)                                   //       Console.WriteLine("1");
    {                                                     //   }                
        Console.WriteLine("1");                           //  else if (X < 0 && Y > 0)
    }                                                     //   {
    else if (X < 0 && Y > 0)                              //       Console.WriteLine("2");  
    {                                                     //   } 
        Console.WriteLine("2");                           //  else if (X < 0 && Y < 0) 
    }                                                     //   { 
    else if (X < 0 && Y < 0)                              //       Console.WriteLine("3");
    {                                                     //   }
        Console.WriteLine("3");                           //  else if (X > 0 && Y < 0)  
    }                                                     //   {
    else if (X > 0 && Y < 0)                              //       Console.WriteLine("4");    
    {                                                     //   } 
        Console.WriteLine("4");                           //  else
    }                                                     //   {
}                                                         //       Console.WriteLine("Не корректный ввод!");
else                                                      //   }
{
    Console.WriteLine("Не корректный ввод!");
}