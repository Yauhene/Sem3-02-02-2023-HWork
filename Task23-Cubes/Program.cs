// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Ну шо? Приступим помолясь?");
Console.WriteLine();
Console.Write("Введите целое число: ");

String Str="| ";

if(int.TryParse(Console.ReadLine(), out int number))
{
    for(int i=1; i != number+1; i++)
    {
        Str=Str+ Math.Pow(i, 3) + " | ";
    }
}
else Console.WriteLine("Введено не целое число");

Console.WriteLine();
Console.WriteLine($"Ряд значений кубов целых чисел от 1 до {number}:");
Console.WriteLine("----------------------------------------------------------------------------");
Console.WriteLine(Str);
Console.WriteLine("----------------------------------------------------------------------------");
Console.WriteLine();