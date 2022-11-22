// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine("Enter a 5 digits number:");
// int number = Convert.ToInt32(Console.ReadLine());

// string Palindrom (int number){
//     int funcNum = number;
//     int[] arr = new int[5];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = funcNum % 10;
//         funcNum = funcNum / 10;
//     }
//     if (arr[0] == arr[4] && arr[1] == arr[3]) return $"{number} -> Yes";
//     else return $"{number} -> No";
// }

// Console.WriteLine(Palindrom(number));

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// double GetLens(int x1,int y1,int z1, int x2,int y2,int z2)
// {
//     double len = Math.Sqrt((x1-x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
//     return len;
// }
// Console.WriteLine("Enter first x ordinate:");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter first y ordinate:");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter first z ordinate:");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second x ordinate:");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second y ordinate:");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second z ordinate:");
// int z2 = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine(GetLens(x1, y1, z1, x2, y2, z2));

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cube(int num){
    if (num < 1) Console.WriteLine("Number must be bigger then 1");
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i}^3 = {i * i * i}");
    }
}

Console.WriteLine("Enter a number");
int n = Convert.ToInt32(Console.ReadLine());
Cube(n);



