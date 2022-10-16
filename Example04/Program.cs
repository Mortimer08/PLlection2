void FillArray(int[] collection) // void - метод без возврата данных
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;      // Length - метод, возвращающий длину массива
    int position = 0;           // Для объявления переменной нужно присваивать ей значение
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

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

int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[7] = 4;
PrintArray(array);

Console.WriteLine("");
int pos = IndexOf(array, 44);
Console.WriteLine(pos);