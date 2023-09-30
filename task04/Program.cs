// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
int n1 = int.Parse(Console.ReadLine());
Console.Write("1st n");
int n2 = int.Parse(Console.ReadLine());
Console.Write("2st n");
int n3 = int.Parse(Console.ReadLine());
Console.Write("3st n");
int maxN = 0;
if (n1 > maxN) maxN = n1;
if (n2 > maxN) maxN = n2;
if (n3 > maxN) maxN = n3;
Console.Write("Максимальное значение имеет число " + maxN);