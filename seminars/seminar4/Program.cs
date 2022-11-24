// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// int FindSum(int a){
//     int sum = 0;
//     for (int i = 1; i <= a; i++){
//         sum += i;
//     }
//     return sum;
// }

// Console.WriteLine("Input number");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = FindSum(number);
// Console.WriteLine(result);

// int Digits(){
//     Console.Write("Введите число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     int count = 0;
//     //while (a > 0) {
//       //  count++;
//        // a = a / 10;
//     //}
//     for (count = 0; a > 0; count++){
//         a = a / 10;
//     }
//     return count;
// }
// Console.Write(Digits());

int [] CreateRandomArray(int size, int minValue, int maxValue){
    int [] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

 void ShowArray (int[] array)
 {
    Console.Write("Получившийся массив ->");
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
   // Console.WriteLine();
 }
 Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(a,min,max);
ShowArray(myArray);
