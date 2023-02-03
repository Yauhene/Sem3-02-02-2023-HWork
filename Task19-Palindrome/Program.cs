// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Ну шо? Приступим помолясь?");
Console.WriteLine();
Console.Write("Введите пятизначное число: ");

if(int.TryParse(Console.ReadLine(), out int number))
{
    //Console.WriteLine("number: " + number);
    int numberLen=(int)Math.Log10(Math.Abs(number)) + 1; // Определяем разрядность введенного целого числа
    //Console.WriteLine("Разрядность введенного числа - " + numberLen);
    if (numberLen != 5 ) Console.WriteLine("По-человечески же просили - ПЯТИЗНАЧНОЕ !!!");
    // Console.WriteLine("number: " + number);
    // Console.WriteLine("numberLen: " + numberLen);

}
else Console.WriteLine("Введено не целое число");


int newNumber=0;
int doubleNumber=number;

for(int i=5; i != 0; i--) // "Разворачиваем" число number, превращая его в newNumber
{
    newNumber=newNumber * 10;
    newNumber=newNumber + (doubleNumber % 10);
    doubleNumber=doubleNumber / 10;
    
    
}

Console.WriteLine($"Введенное число в 'развернутом' виде: {newNumber}");
Console.WriteLine("----------------------------------------------------------------------------");

if (number != newNumber)
{
    Console.WriteLine($"Введеное число  {number} не является палиндромом");
}
else Console.WriteLine($"Введеное число  {number} является палиндромом");

Console.WriteLine("----------------------------------------------------------------------------");
Console.WriteLine();