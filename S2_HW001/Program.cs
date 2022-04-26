// Задача 7. Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.


int Perevorot(int N2)// Метод переворота заданного числа
{
    int M = Math.Abs(N2);
    int q = 0;
    int newN = 0; // для переворота числа наоборот
    while (M > 0)
    {
        q = M % 10;
        newN = newN * 10 + q; // для переворота числа наоборот
        M = M / 10;
    }
    return newN;
}
int LengthNumber(int N2)// Метод определения количества разрядов заданного числа
{
    int M = Math.Abs(N2);
    int n = 0;
    while (M > 0)
    {
        M = M / 10;
        n++;
    }
    return n;
}
int MathPowInt(int a, int b)// Метод преобразования метода MathPow в тип данных int
{
    int d = a;
    while (b > 1)
    {
        d = d * a;
        b = b - 1;
    }
    return d;
}
//===========================================================
int N = new Random().Next();
int npp = 3; // Возможность определять разные цифры числа
int T = 0;
int T2 = 0;
int newN = Perevorot(N);
int n = LengthNumber(N);
if (n < npp)
{
    System.Console.WriteLine($"{npp}-й ЦИФРЫ НЕТ");
}
else
{
    T = newN % MathPowInt(10, npp) / MathPowInt(10, npp-1);// 1 вариант вычисления
    T2 = newN / MathPowInt(10, npp-1) % 10;// 2 вариант вычисления
}

System.Console.WriteLine($"У числа {N} {npp}-я цифра {T}");
System.Console.WriteLine($"У числа {N} {npp}-я цифра {T2}");


