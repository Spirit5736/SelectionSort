int[] list = { 8, 15, 16, 42, 4, 23 };

foreach (var item in SelectionSort(list))
{
    Console.WriteLine(item.ToString());
}

int[] SelectionSort(int[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        int smallest = i;
        for (int j = 0; j < list.Length; j++)
        {
            if (list[j] > list[smallest])
            {
                smallest = j;
                Swap(ref list[i], ref list[smallest]);
            }
        }
    }
    return list;
}

void Swap(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}