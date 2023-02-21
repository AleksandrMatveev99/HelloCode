// Сумма чисел от 1 до N

int SumNumbers(int number)
{
    if (number == 1) return number;
    else return number + SumNumbers(number-1);
}

Console.Write(SumNumbers(10));