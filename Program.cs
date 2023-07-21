/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*Console.Write("Input A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input B: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = 1;
int d = b;
if (b<1)
Console.Write("Error");
else
{
while (b!=0)
{
c = c * a;
b = b - 1;
}
Console.Write($"{a},{d} -> {c}");
}
*/
/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
/*Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
int len = Length(a);
Console.Write($"{a} -> {Sum(a,len)}");
int Length(int a)
{
int index = 0;
while (a > 0)
{
a /= 10;
index++;
}
return index;
}
int Sum(int a, int len)
{
int sum = 0;
for (int i = 1; i <= len; i++)
{
sum += a % 10;
a /= 10;
}
return sum;
}
*/
/*Напишите программу, которая задаёт массив из m элементов и выводит их на экран. Разработать метод CreateArray(int size), генерирующий массив на основе данных, вводимых пользователем.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
// задача в процессе
/*int lenArray = ReadInt("Enter the length of the array: ");

int[] CreateArray = new int[lenArray];
for (int i = 0; i < CreateArray.Length; i++)
{
 Console.WriteLine($"Enter the array: ");
 CreateArray[i] = new ReadInt().Next(1,9);
 Console.Write(CreateArray[i] + " ");
}

int ReadInt(string message)
{
 Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/
