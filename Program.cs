//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
//а какое меньшее.

/*Console.WriteLine("ВВедите число а");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("ВВедите число b");
int b = int.Parse(Console.ReadLine());
if (a > b) { Console.WriteLine($"max = {a}");}
else{ Console.WriteLine($"max = {b}");}*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int max;
Console.WriteLine("ВВедите число а");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("ВВедите число b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("ВВедите число c");
int c = int.Parse(Console.ReadLine());
if (a > b) { max = a;}
else{ max = b;}
if (c > max) { max = c;}
Console.WriteLine($"max = {max}");
