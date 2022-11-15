// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {numM}, N = {numN} -> ");

int Sum = sumNaturalElements(numM, numN);
Console.Write(Sum);

int sumNaturalElements (int numb1, int numb2)
{
    if (numb2 == numb1) return 0;
    return sumNaturalElements(numb1, numb2 -1) * (numb2 - numb1 + 1) / 2;
}

// через тернарный оператор
// int DegreeNumber (int numb1, int numb2)
// {
//     return numb2 == 0 ? 1 : numb1 * DegreeNumber (numb1, numb2-1);
// }