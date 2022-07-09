//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

Console.WriteLine("Напишите число, которое хотите возвести в степень");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите степень в которую хотите возвести");
int B = int.Parse(Console.ReadLine());
int Pow(int x, int n)
{
    int res = 1;
    for (int count = 1; count<= n; count++)
 {
    res = res * x;
}
return res;
}
if (B < 1);
Console.WriteLine("Введены некорректные данные");
Console.WriteLine(Pow(A, B));
