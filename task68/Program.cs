// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите значение m:  ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.Write($"m = {numM}, n = {numN} -> A(m,n) = ");

int Ack = ackerman(numM, numN);
Console.Write(Ack);

int ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return ackerman(m - 1, 1);
    }
    else
    {
        return ackerman(m - 1, ackerman(m, n - 1));
    }
}

