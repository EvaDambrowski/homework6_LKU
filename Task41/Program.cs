Console.Write("Введите элементы массива(через запятую): ");
int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);
int count = 0;
PrintArray(arr);
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов больше нуля: {count}");

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.Write("]");
}