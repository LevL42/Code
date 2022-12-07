// 1 Метод который не чего не принемает и не возвращает.
/*
void Method()
{
    Console.WriteLine("Автор ");
}

Method();
*/

// 2 Метод который не чего не возвращает но пронемает аргумент.

/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("text");
*/
// 2.1 Также этот метод может использовать несколько аргументов.
//     Такие аргументы называются именованными.
//     Вызвать его можно еще так Method21(msg: "Text", count: 4)
/*
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Text", 5);
*/

// 3 Группа методов которые что то возвращают но ничего не принемают.

/*
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
*/

// 4 Это метод который что то принемает и что то возвращает.

/*
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

string res = Method4(10, "qwerty ");
Console.WriteLine(res);
*/

// Цикл for(int i = 0; i < 10; i++)
/*
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "qwerty ");
Console.WriteLine(res);
*/
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
*/

// Задача 1 
// Дан текст. В тексте нужно все пробелы заменить черточками, 
//маленькие буквы "к" заменить на большие "К", а большие "С" на маленькие "с"
/*
string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
*/

// 1 Найти позицию минимального элемента в неотсортированной части массива.
// 2 Произвести обмен этого значения со значением первой неотсортированной позиции.
// 3 Павторять пока есть не отсортированные элементы.

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

}

void Sort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minposition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minposition]) minposition = j;
        }
        int temporary = array[i];
        array[i] = array[minposition];
        array[minposition] = temporary;

    }
}

PrintArray(arr);
Sort(arr);

PrintArray(arr);

