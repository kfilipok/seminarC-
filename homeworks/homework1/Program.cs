/* Урок 1. Знакомство с языком программирования С#
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

// Console.WriteLine("Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
// Console.WriteLine("Enter a 1st number");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter f 2-d number");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > b){
//     Console.WriteLine($"a = {a}; b = {b} -> max {a}");
// }else if(a < b){
//     Console.WriteLine($"a = {a}; b = {b} -> max {b}");
// }else{
//     Console.WriteLine($"nubers are similar");
// }

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

// Console.WriteLine("Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
// Console.WriteLine("Enter a 1-st number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// Console.WriteLine("Enter a 2-nd number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num2 > max){
//     max = num2;
// }
// Console.WriteLine("Enter a 3-d number");
// int num3 = Convert.ToInt32(Console.ReadLine());
// if (num3 > max){
//     max = num3;
// }
// Console.WriteLine($"Entered numbers: {num1} {num2} {num3}, max -> {max}");

/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */
Console.WriteLine("При вводе числа программа выдает четное ли это число");
Console.WriteLine("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 > 0){
    Console.WriteLine($"Number {num} is odd");
}else{
    Console.WriteLine($"Number {num} is even");
}

/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */