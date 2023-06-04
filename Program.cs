//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
 Console.Write("Введите число A: ");
  int numberA = int.Parse(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = int.Parse(Console.ReadLine());
  
int NumberInNaturalDegree(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
   result = result * numberA;
  }
    //int result = Math.Pow(numberA, numberB);
    return result;
}
  int numberindegree = NumberInNaturalDegree(numberA, numberB);
  Console.WriteLine("Число А в натуральной степени В:" + numberindegree);

  // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());

  int SumNumber(int numberN){
    int result = 0;
    for (int i = 0; numberN >0; i++){
        result += numberN %10;
      numberN = numberN / 10;
    }
   return result;
  }
int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.Write("Введите число обозночающее колличество элементов массива: ");
int length =int.Parse(Console.ReadLine());
int[]array = GetRandomArray(length);
Console.WriteLine("Выведенный массив:");
PrintArry(array);
Console.WriteLine();
Console.WriteLine("Заданный массив:");
Console.Write(string.Join(",",array));
int[]GetRandomArray(int length)
{
    int[]array = new int[length];
    Random random = new Random();
    for(var i=0;i<array.Length;i++)
    {
        array[i]=random.Next(0,100);
    }
    return array;
}

void PrintArry(int[] arr)
{
  int count = arr.Length;
  int index = 0;
  Console.Write("[");
  while(index < count)
  {
    Console.Write(arr[index]);
    index++;
    if (index < count)
    {
      Console.Write(", ");
    }
   }
Console.Write("]");
}
