/* Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Write("Enter number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0) 
{
    Console.WriteLine("Entered a negative number.");
    return;
}
int calculationAckermannFunction = CalculationAckermannFunction(m,n);
Console.Write($"m = {m}, n = {n} - > A(m,n) = {calculationAckermannFunction}");

int CalculationAckermannFunction(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else if (num1 > 0 && num2 == 0) return CalculationAckermannFunction(num1 - 1, 1);
    else if (num1 > 0 && num2 > 0) return CalculationAckermannFunction(num1 - 1,CalculationAckermannFunction(num1, num2 - 1)); 
    else return num2 + 1;
}
