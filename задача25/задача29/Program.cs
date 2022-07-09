// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

int [] GetArray(int dimension)
{
int[] arr = new int[dimension];
Random randomizer = new Random();

for(int i=0; i < arr.Length; i++)
{
arr[i] = randomizer.Next(1, 9);
}

return arr;
}

void PrintArray(int [] arr)
{
for (int i = 0; i < arr.Length; i++)
{
Console.Write($"{arr[i]} ");
}
}
