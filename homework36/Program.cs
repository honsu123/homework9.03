int[] GetArray()
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 20);
    }
    return array;
}
void SearchArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0);
        else
            count = count + array[i];
    }
    Console.WriteLine("Сумма элементов: " + count);
}
int[] newArray = GetArray();
SearchArray(newArray);
Console.WriteLine(String.Join(" ", newArray));
