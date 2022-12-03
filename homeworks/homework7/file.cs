// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// // m = 3, n = 4.

// // 0,5 7 -2 -0,2

// // 1 -3,3 8 -9,9

// // 8 7,8 -7,1 9
// int [,] CreateRandonm2DArray(double minValue, double maxValue, int rows, int columns){
//     int [,] newArray = new  int[rows, columns];
//     for (int i = 0; i < rows; i++){
//         for (int j = 0; j < colums; j++){
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }
// void Show2DArray(int [,] arr){
//     Console.WriteLine("-----------------------Начало массива----------------------------");
//     for(int i = 0; i < arr.GetLenght(0); i++){
//         for(int j = 0; j < arr.GetLenght(1); j++){
//             Console.Write($"{arr[i, j]} | ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine("-----------------------Конец массива----------------------------");
// }

// Console.Write("Введите Количетво строк в массиве: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Количетво столбцов в массиве: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ячейки массива: ");
// double minValue = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите максимальное значение ячейки массива: ");
// double maxValue = Convert.ToDouble(Console.ReadLine());

// int[,] arr = CreateRandonm2DArray(minValue, maxValue, rows, columns);
// Show2DArray(arr);


// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// // возвращает значение этого элемента или же указание, что такого элемента нет.

// // Например, задан массив:

// // 1 4 7 2

// // 5 9 2 3

// // 8 4 2 4

// // 17 -> такого числа в массиве нет

// int GetElement(int [,] array){
//     Console.Write("Введите номер строки элемента массива: ");
//     int row = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите номер столбца элемента массива: ");
//     int column = Convert.ToInt32(Console.ReadLine());
    
//     for(int i = 0; i < array.GetLenght(0); i++){
//         for(int j = 0; j < array.GetElement(1); j++){
//             if(i == row && j == column) return array[i, j];
//         }
//     }
//     Console.WriteLine($"Элемента с параметрами {row} и {column} не существует");
//     return -1;
// }
// int element = GetElement(array);
// Console.WriteLine($"Элемент массива с заданными параметрами равен {element}");

// // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// // элементов в каждом столбце.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int [,] CreateRandonm2DArray(int minValue, int maxValue, int rows, int columns){
//     int [,] newArray = new  int[rows, columns];
//     for (int i = 0; i < rows; i++){
//         for (int j = 0; j < colums; j++){
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Average(int [,] array){
//     int columnsNum = array.GetLenght(1);
//     int rowsNum = array.GetLenght(0);
//     int [] sumOfColumnArr = new double[columnsNum];
    
//     for(int i = 0; i < array.GetLenght(0); i++){
//         for(int j = 0; j < array.GetLenght(1); j++){
//             sumOfColumnArr[j] += array[i, j];
//         }
//     }
//     Console.WriteLine("Средние арифметические столбцов массива равны следующим числам:");
//     for(int k = 0; k < sumOfColumnArr.Length; k++){
//         Console.Write($" {sumOfColumnArr[k]} |");
//     }

// }

// Console.Write("Введите Количетво строк в массиве: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Количетво столбцов в массиве: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ячейки массива: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ячейки массива: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
