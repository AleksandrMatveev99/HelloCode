// Собрать строку с числами от a до b, a <= b

// string NumbersRec(int a, int b)
// {
//     if (a < b) return $"{a} " + NumbersRec(a + 1, b);
//     else return $"{b}";
// }

// Console.Write(NumbersRec(10, 1));

// Собрать строку с числами от b до a, a >= b

string NumbersRec(int a, int b)
{
    if (b < a) return NumbersRec(a, b + 1) + $"{b} ";
    else return $"{a} ";
}

Console.Write(NumbersRec(10, 1));