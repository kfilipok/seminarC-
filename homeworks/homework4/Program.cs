// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int Inv(int num, int inv){
//     int result = 1;
//     for (int i = 1; i <= inv; i++)
//     {
//         result = result * num;
//     }
//     return result;
// }
// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень возведения");
// int inv = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"число {a}  в степени {inv} равно {Inv(a, inv)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int SumOfDigits(int num){
    int sum = 0;
    int digit = 0;
    int mNum = num;
    while (mNum > 0)
    {
        digit = mNum % 10;
        mNum = mNum / 10;
        sum += digit;
    }
    return sum;
}
 Console.WriteLine("Введите Число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {n} составляет {SumOfDigits(n)}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// int [] CreateRandomArray(int size, int minValue, int maxValue){
//     int [] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

//  void ShowArray (int[] array)
//  {
//     Console.Write("Получившийся массив ->");
//     for(int i=0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//    // Console.WriteLine();
//  }
//  Console.WriteLine("Введите размер массива");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(a,min,max);
// ShowArray(myArray);