
Console.Write("Введите сумму счета: ");
if(!double.TryParse(Console.ReadLine(), out double summaScheta))
{
    Console.WriteLine("Ошибка ввода");
}
Console.Write("Введите процент чаевых: ");
if(!int.TryParse(Console.ReadLine(), out int procentChaevikh))
{
    Console.WriteLine("Ошибка ввода");
}
Console.Write("Введите количество человек: ");
if(!int.TryParse(Console.ReadLine(), out int gosti))
{
    Console.WriteLine("Ошибка ввода");
}


Console.WriteLine($"Общий счёт: {summaScheta + (summaScheta/100*procentChaevikh)}");
Console.WriteLine($"Процент чаевых: {procentChaevikh}%");
Console.WriteLine($"С каждого: {Math.Round((summaScheta + (summaScheta/100*procentChaevikh))/gosti, 3)}");

