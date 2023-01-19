// Ничего не принимает, ничего не возвращает
void Method1()
{
    Console.WriteLine("Автор ...");
}
// Method1();

// что-то принимают, ничего не возвращают
void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method2("Привет", 3); // или Method2(count: 3, msg: "Привет");

// ничего не принимают, что-то возвращают
int Method3()
{
    return DateTime.Now.Year;
}
//int year = Method3();
//Console.WriteLine(year);

// что-то принимают, что-то возвращают
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(3, "Га");
Console.WriteLine($"Гуси: {res}");