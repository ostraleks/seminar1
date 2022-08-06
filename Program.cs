/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int number = Convert.ToInt32(Console.ReadLine ());
int squre = number * number;
int result = Convert.ToInt32(Math.Pow(number,2));
Console.WriteLine("квадрат от числа" + number + "=" + squre);
Console.WriteLine("квадрат от числа" + number + "=" + result);
Console.Write("введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("введите первое число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB * numberB == numberA) { Console.WriteLine("первое число квадрат второго");}
else Console.WriteLine("первое число не квадрат второго");*/
Console.Write("введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
int neg = numberA * (-1);
while (neg <= numberA)
{
    Console.Write(neg +" ");
    neg++;}