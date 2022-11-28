// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int [] CreatRandomArray (int size)
// {
//     int [] newArray = new int [size]; // инициализация массива
//     for (int i = 0; i < size; i++)
//     {
//     newArray[i] = new Random().Next(-10, 11); //Заполняем массив, +1 т.к. последнее число не входит в диапозон
//     }
//     return newArray; //вернуть массив    
// }

// int CountDigits(int [] array){
//     int count = 0;
//     for (int i = 0; i < array.Length; i++){
//         if(array[i] > 0) count++;
//     }

//     return count;
// }
// void ArrayPrint (int [] array){
//     Console.WriteLine("Начало массива:");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{i} => {array[i]} | ");
//     }
//     Console.WriteLine("\nКонец массива");
// }

// Console.WriteLine("Введите количество цифр");
// int a = Convert.ToInt32(Console.ReadLine());
// int [] arr = CreatRandomArray (a);
// ArrayPrint(arr);
// Console.WriteLine($" Количтсво положительных элементов = {CountDigits(arr)}");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Point(double b1, double k1, double b2, double k2){
    double x, y;
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"({x} ; {y})");
}
Console.WriteLine("Введите 1-е значение");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите 2-е значение");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите 3-е значение");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите 4-е значение");
double k2 = Convert.ToDouble(Console.ReadLine());


Point(b1,k1,b2,k2);
