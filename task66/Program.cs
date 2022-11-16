// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Для нахождения суммы чисел от M до N используется формула: (M+N)×(N-M+1)/2

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {numM}, N = {numN} -> ");

int Sum = sumNaturalElements(numM, numN);
Console.Write(Sum);

int sumNaturalElements(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else if (m < n)
    {
        return m + sumNaturalElements(m + 1, n);
    }
    else
    {
        return m + sumNaturalElements(m, n + 1);
    }
}





// int sumNaturalElements(int m, int n)
// {
//     return m == n ? 0 : m + sumNaturalElements(m +1, n);
// }
