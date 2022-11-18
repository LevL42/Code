int[] array = { 10, 22, 33, 4, 9, 55, 60, 78, 83, 9 };

int n = array.Length;
int find = 9;

int index = 0;
while (index < find)
{

    if (array[index] == find)
    {

        Console.WriteLine(index);
        break;
    }

    index++;
}