
int[] ArrayCreate(){
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void PrintArray(int [] array){
    Console.WriteLine("-----------------------Начало массива----------------------------");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " | ");
    }
    Console.WriteLine();
    Console.WriteLine("------------------------Конец массива----------------------------");
}
void EvenDigitsCount(int[] array){
    int countEvenDigits = 0;
    for (int i = 0; i < array.Length; i++){
        if(array[i] % 2 == 0) countEvenDigits++;
    }
    Console.WriteLine($"Количество четных элементов массива: {countEvenDigits}");
}
void OddIndexCount(int[] array){
    int summOddIndexElements = 0;
    for (int i = 1; i < array.Length; i+=2){
       summOddIndexElements += array[i];
    }
    Console.WriteLine($"Сумма значений нечетных элементов массива: {summOddIndexElements}");
}
void MaxMinDifferense(int[] array){
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
    }
    int min = max;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
    }
    Console.WriteLine($"Разность между максимальным и минимальным элементами: {max - min}");
}
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = ArrayCreate();
PrintArray(arr);
EvenDigitsCount(arr);
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
OddIndexCount(arr);
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
MaxMinDifferense(arr);