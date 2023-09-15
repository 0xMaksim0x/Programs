//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Enter number: ");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.WriteLine("Enter number: ");
strNum = Console.ReadLine();
int num2 = int.Parse(strNum);

Console.WriteLine("Enter number: ");
strNum = Console.ReadLine();
int num3 = int.Parse(strNum);

int max = num1;

if (num1 > num2) max = num1;

if (max < num3) max = num3;

if (num1 < num2) max = num2;

if (max < num3) max = num3;

Console.WriteLine(max);