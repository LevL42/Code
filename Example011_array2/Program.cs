void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;

    }



}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;

    }
}

int Indexof(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // -1 выводится когда нет такого индекса в массиве.

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;

}
int[] array = new int[10]; // здесь мы говорим создай новый массив с 10 элементами

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = Indexof(array, 33);
Console.WriteLine(pos);