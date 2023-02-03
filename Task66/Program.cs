/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
int M = 1;
int N = 15;

int sum = SumNaturalElements(M, N);
Console.Write($"M = {M}; N = {N}; - >  ");
Console.Write(sum);

int SumNaturalElements(int m, int n)
{
    if (n == m) return m;
    return m + SumNaturalElements(m + 1, n);
    
}