int[] CreateArray(int n)
{
    return new int[n];
}

void Fill(int[] elements)
{
    int len = elements.Length;
    int index = 0;

    while (index < len)
    {
        int current = Random.Shared.Next(30);
        elements[index] = current;
        Console.WriteLine(elements[index]);
        index ++;
    }
}

int GetSum(int[] array)
{
    int len = array.Length;
    int sum = 0;
    int count = 0;

    while (count < len)
    {
        int cur = array[count];
        if (cur >= 10 && cur <= 99)
        {
            sum += cur;
        }
        count ++;
    }

    return sum;
}


int[] chisla = CreateArray(10);
Fill(chisla);
Console.WriteLine(GetSum(chisla));