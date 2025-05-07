
int count = 0;

Console.Write("Что означает слово 'cat'? [кошка, собака]");
string answer = Console.ReadLine();
if (string.Equals(answer.Trim(), "кошка", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Всё верно! 😎");
    count ++;
}
else
{
    Console.WriteLine("Нужно подумать ещё 🫣");
}

Console.Write("Что означает слово 'dog'? [кошка, собака]");
answer = Console.ReadLine();
if (string.Equals(answer.Trim(), "собака", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Всё верно! 😎");
    count ++;
}
else
{
    Console.WriteLine("Нужно подумать ещё 🫣");
}


Console.WriteLine($"Счёт: {count}");
