int[] array = { 111, 22, 39, 7, 34, 25, 66, 7, 38, 93 };

int n = array.Length; // Длина массива
int find = 7;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}