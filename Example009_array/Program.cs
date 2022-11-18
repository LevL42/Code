int Max(int arg1, int arg2, int arg3)
{

    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//Индекс массива 0   1   2   3   4   5   6   7   8  всегда считается с 0.
int[] array = { 11, 21, 13, 41, 51, 16, 71, 18, 91 };
//array[0] = 12;                   // здесь мы оброщаемся к массиву и записываем в него значение.
//Console.WriteLine(array[5]); // здесь мы оброщаемся к массиву и получаем значение элемента по индексу

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));
Console.WriteLine(result);
/*int max = Max(Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));   Возможна ещё такая запись. 
В одной переменной три или больше действий
Console.WriteLine(max);*/
