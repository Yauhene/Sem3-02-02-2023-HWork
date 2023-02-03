//Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Hello, World!");

int[] arrayA = new int[3];
int[] arrayB = new int[3];

void coordInput(string a) // метод заполнения массивов координат точек, аргумент a - имя точки, A или B
{
    Console.Write($"Введите значение X для точки {a} : "); // ввод значения X для указанной точки
    if(int.TryParse(Console.ReadLine(), out int x))
    {
        switch(a)
        {
            case "A":
                arrayA[0] = x;
                break;
            case "B":
                arrayB[0] = x;
                break;
            default:
                Console.WriteLine("Неверное значение, введите 'A' или 'B' ");
                break;
        }
        
    }
    else Console.WriteLine("Ошибка ввода, возможно введено не целое число");

    Console.Write($"Введите значение Y для точки {a} : ");// ввод значения Y для указанной точки
    if(int.TryParse(Console.ReadLine(), out int y))
    {
        switch(a)
        {
            case "A":
                arrayA[1] = y;
                break;
            case "B":
                arrayB[1] = y;
                break;
            default:
                Console.WriteLine("Неверное значение, введите 'A' или 'B' ");
                break;
        }
        
    }
    else Console.WriteLine("Ошибка ввода, возможно введено не целое число");
    
    Console.Write($"Введите значение Z для точки {a} : ");// ввод значения Z для указанной точки
    if(int.TryParse(Console.ReadLine(), out int z))
    {
        switch(a)
        {
            case "A":
                arrayA[2] = z;
                break;
            case "B":
                arrayB[2] = z;
                break;
            default:
                Console.WriteLine("Неверное значение, введите 'A' или 'B' ");
                break;
        }
        
    }
    else Console.WriteLine("Ошибка ввода, возможно введено не целое число");

}

coordInput("A");
Console.WriteLine("-----------------------------------");
Console.WriteLine($"Введены координаты XYZ для точки A: {arrayA[0]} , {arrayA[1]} , {arrayA[2]}");
Console.WriteLine($"Введены координаты XYZ для точки B: {arrayB[0]} , {arrayB[1]} , {arrayB[2]}");