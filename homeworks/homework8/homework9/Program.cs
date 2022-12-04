// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// void ShowPrevNumbers(int num){
//     if (num < 0) Console.WriteLine("Число должно быть положительным");
//     else if(num != 0){
//         Console.Write($"{num} ");
//         ShowPrevNumbers(num-1);
//     }
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// ShowPrevNumbers(num);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// int SumOfElements(int fDig, int lDig){
//     int sum = 0;
//     int count = fDig;
//     if(count <= lDig){
//         sum += fDig;
//         return sum += SumOfElements(fDig+1, lDig);
//     }
//     return sum;
// }
// Console.Write("Введите начало диапазона: ");
// int first = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите конец диапазона: ");
// int second = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumOfElements(first, second));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Akkerman(int n, int m){
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}
Console.WriteLine(Akkerman(1, 2));