int[] array = { 13, 48, 798, 65, 25, 46, 27, 464, 25 };

int n = array.Length;
int find = 25;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}