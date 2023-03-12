int[] GetArray()
{
int[] array = new int[10];
    for (int i = 0; i< array.Length; i++ )
    {
        array[i]=new Random().Next(100, 1000);
    }
    return array;
}
void SearchArray(int[] array)
{
    int count = 0;
    for (int i = 0; i <array.Length; i++ )
    {
        if(array[i] % 2 == 0)
        count++;
    }
    Console.WriteLine("Колво чётныйх чисел:" + count + "\n");
}
int[] newArray = GetArray();
SearchArray(newArray);
Console.WriteLine(String.Join(" ", newArray));
// int a = Convert.ToInt32(Console.ReadLine());
// int b = a%2;
// Console.WriteLine(b);