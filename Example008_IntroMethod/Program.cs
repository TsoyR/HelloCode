int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}


int a1 = 2;
int b1 = 3;
int c1 =5;
int a2 = 144;
int b2 = 3000;
int c2 =6;
int a3 = 6;
int b3 = 5;
int c3 =5;

// int max1 = Max(a1, b1, c1);

// int max2 = Max(a2, b2, c2);

// int max3 = Max(a3, b3, c3);



/*
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;
*/

//int result = Max(max1, max2, max3);
int result = Max(Max(a1, b1, c1),
Max(a2, b2, c2), Max(a3, b3, c3));


Console.WriteLine(result);

