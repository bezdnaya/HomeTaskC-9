//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int Sum (int num1, int num2)
{
    if (num1 == num2) return num1; 
    else if (num1 > num2) return num1 + Sum(num1-1, num2);
    else
        return num1 + Sum(num1+1, num2);
}
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от {M} до {N} = {Sum(M, N)}");

