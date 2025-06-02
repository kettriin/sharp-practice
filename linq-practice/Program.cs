
//linq - язык запросов для фильтрации группировки и тд
List<int> ints = Enumerable.Range(0, 10)
    .Select(item => Random.Shared.Next(10))
    .Where(item => item % 2 == 0)
    .ToList();

Console.WriteLine(String.Join(", ", ints));
