// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Enter a 5 digits number:");
int number = Convert.ToInt32(Console.ReadLine());

string Palindrom (int number){
    int funcNum = number;
    int[] arr = new int[5];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = funcNum % 10;
        funcNum = funcNum / 10;
    }
    if (arr[0] == arr[4] && arr[1] == arr[3]) return $"{number} -> Yes";
    else return $"{number} -> No";
}

Console.WriteLine(Palindrom(number));
// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// double GetLens(int x1,int y1,int z1, int x2,int y2,int z2)
// {
//     double len = Math.Sqrt((x1-x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
//     return len;
// }
// Console.WriteLine(GetLens(3, 6, 8, 2, 1, -7));
