// Упорядочить массив
void fillArray(int[] collection)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(-100, 101);
    }
}

void printArray(int[] array)
{
    int count = array.Length;
    for (int position = 0; position < count; position++)
    {
        Console.Write($"{array[position]} ");
    }
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

int[] arr = new int[9];
fillArray(arr);
printArray(arr);
Console.WriteLine();
SelectionSort(arr);
printArray(arr);