int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 32;
int b1 = 45;
int c1 = 35;
int a2 = 23;
int b2 = 345;
int c2 = 543;
int a3 = 345;
int b3 = 23;
int c3 = 354;

Console.WriteLine(Max(Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3)));