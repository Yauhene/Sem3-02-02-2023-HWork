// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Ну шо? Приступим помолясь?");

Console.Write("Введите пятизначное число: ");




if(int.TryParse(Console.ReadLine(), out int number))
{
    int numberLen=(int)Math.Log10(Math.Abs(number)) + 1; // Определяем разрядность введенного целого числа
    Console.WriteLine("Разрядность введенного числа - " + numberLen);
    if (numberlen!=5) Console.WriteLine("По-человечески же просили - П Я Т И З Н А Ч Н О Е !!!");
}
else Console.WriteLine*("Введено не целое число");

int[] digArr=new int[5];


