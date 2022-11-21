// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int SecondDigit(int num){
//     int residue = num % 100;
//     return residue / 10;
// }
// int n = 899;
// Console.WriteLine($"{n} -> {SecondDigit(n)}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
void Find3dDigit(int num){
    if (num > 99)
    {
        int divNum = num;
        int reduse = 0;
        while(divNum > 99)
        {
            reduse = divNum % 10;
            divNum = divNum / 10;
        }
        Console.WriteLine($"3-d digit is {reduse}, number is {num}");
    } else{
        Console.WriteLine("3-d digit is empty in this number");
    } 
}

Find3dDigit(101);
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// bool WeekDay(int day){
//     if (day == 6 || day == 7)
//     {
//         return true;
//     }else
//     {
//         return false;
//     }
// }

// Console.WriteLine(WeekDay(1));