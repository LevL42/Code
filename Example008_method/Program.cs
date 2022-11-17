/*int a1 = 12;
int a2 = 17;
int a3 = 40;

int b1 = 8;
int b2 = 17;
int b3 = 30;

int c1 = 4;
int c2 = 17;
int c3 = 10;

int max = a1;

if (max < a2) max = a2;
if (max < a3) max = a3;

if (max < b1) max = b1;
if (max < b2) max = b2;
if (max < b3) max = b3;

if (max < c1) max = c1;
if (max < c2) max = c2;
if (max < c3) max = c3;

Console.WriteLine(max);
*/

int Max(int arg1, int arg2, int arg3)
{

    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 112;
int a2 = 17;
int a3 = 40;

int b1 = 8;
int b2 = 17;
int b3 = 30;

int c1 = 4;
int c2 = 111;
int c3 = 10;

//int max1 = Max(a1, a2, a3);
//int max2 = Max(b1, b2, b3);
//int max3 = Max(c1, c2, c3);
//int max4 = Max(max1, max2, max3);

int max = Max(Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));  /* Возможна ещё такая запись. 
В одной переменной три или больше действий*/
Console.WriteLine(max);