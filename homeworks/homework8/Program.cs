
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// int [,] CreateRandonm2DArray(){
//     Console.Write("Введите Количетво строк в массиве: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите Количетво столбцов в массиве: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимальное значение ячейки массива: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное значение ячейки массива: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int [,] newArray = new  int[rows, columns];
//     for (int i = 0; i < rows; i++){
//         for (int j = 0; j < columns; j++){
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

void Show2DArray(int [,] arr){
    Console.WriteLine("-----------------------Начало массива----------------------------");
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i, j]} | ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("-----------------------Конец массива----------------------------");
}

// int[,] Array2DSort(int [,] array){ 
//     int temp = 0;
//     for (int row = 0; row < array.GetLength(0); row++){
//          bool sorted = false;
//         while (sorted == false){
//             sorted = true;
//             for (int col = 0; col < array.GetLength(1); col++){ 
//                 if(col < array.GetLength(1)-1){
//                     if(array[row, col] < array[row, col+1]){
//                         sorted = false;
//                         temp = array[row, col+1];
//                         array[row, col+1] = array[row, col];
//                         array[row, col] = temp;
//                     }
//                 }else if(col == array.GetLength(1)-1){
//                     if(array[row, col] > array[row, col-1]){
//                         sorted = false;
//                         temp = array[row, col];
//                         array[row, col] = array[row, col-1];
//                         array[row, col-1] = temp;
//                     }
//                 }
//             }
//         }

//     }
//     return array;
// }
// int [,] arr = CreateRandonm2DArray();
// Show2DArray(arr);
// Array2DSort(arr);
// Console.WriteLine("Отсортированный массив:");
// Show2DArray(arr);
// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// void MinSumOfArrRows(int [,] array){
//     if (array.GetLength(0) != array.GetLength(1)) {
//         Console.WriteLine("MinSumOfArrRows - Массив должен быть квадратным");
//     }else {
//         int minSum = -1;
//         int numRow = 0;
//         for (int i = 0; i < array.GetLength(0); i++){
//             int sum = 0;
//             for (int j = 0; j < array.GetLength(1); j++){
//                 sum += array[i, j];
//             }
//             if(minSum < 0){
//                 minSum = sum;
//                 numRow = i;
//             } 
//             if(sum < minSum){
//                 minSum = sum;
//                 numRow = i;
//             } 
//         }
//         Console.WriteLine($"Строка с минимальной суммой {numRow+1} минимальная сумма {minSum}");
//     }
// }
// MinSumOfArrRows(arr);
// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18
// int [,] arr2 = CreateRandonm2DArray();

// int[,] MatrixMultiply(int [,] matrix1, int[,] matrix2){
//     if(matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1)){
//         Console.WriteLine("Массивы должны быть матрицами и одинаковыми");
//         return matrix1;
//     }else{
//         int [,] resultArr = new int [matrix2.GetLength(0), matrix2.GetLength(1)];
//         for (int i = 0; i < matrix1.GetLength(0); i++){
//             for (int j = 0; j < matrix2.GetLength(1); j++){
//                 // cij = ai1 · b1j + ai2 · b2j + ... + ain · bnj
//                 for (int k = 0; k < matrix2.GetLength(0); k++){
//                     resultArr[i, j] += matrix1[i, k] * matrix2[k, j];
//                 }

//             }
//         }
//         return resultArr;
//     }
// }
// Show2DArray(MatrixMultiply(arr, arr2));
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
// int[,,] Array3DPrint(int size){
//     int dig = 10;
//     int [,,] arr = new int[size, size, size];
//     for (int i = 0; i < size; i++){
//         for (int j = 0; j < size; j++){
//             for (int k = 0; k < size; k++){
//                arr[i, j, k] = dig;
//                dig++;
//             }
//         }
//     }
//     return arr;
// }
// void Show3DArray(int [,,] arr){
//     for (int i = 0; i < arr.GetLength(0); i++){
//         for (int j = 0; j < arr.GetLength(1); j++){
//             for (int k = 0; k < arr.GetLength(2); k++){
//                Console.Write($" {arr[i, j, k]} ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }
// int[,,] arr3 = Array3DPrint(3);
// Show3DArray(arr3);
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int [,] fillArray(int size){
    int dig = 1;
    int row = 0;
    int col = 0;
    int[,] arr = new int[size+1, size+1];
    for (int i = 0; i < size; i++){
        arr[row, i] = dig;
        dig++;
        col++;
    }
    // size--;
    for (int i = 0; i < size; i++){
        arr[i, col] = dig;
        dig++;
        row++;
    }
    // size--;
    for (int i = size; i > size; i--){
        arr[row, i] = dig;
        dig++;
        col--;
    }
    size--;
    for (int i = size; i > size; i--){
        arr[i, col] = dig;
        dig++;
        row--;
    }
    return arr;
}

int [,] arr4 = fillArray(4);
Show2DArray(arr4);