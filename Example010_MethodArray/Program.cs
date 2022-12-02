int[] array = { 234, 445, 546, 6, 33, 65, 68, 35 };

int n = array.Length;
int find = 68;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}