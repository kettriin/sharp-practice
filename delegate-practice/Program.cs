// хотим в один метод передавать другой 
// для этого опишем тип метода 

// bool IsEven(int x)
// {
//     return x % 2 == 0;
// }

// хотим дальше понять какого типа этот метод, чтобы его передать
// для этого используем сигнатуру метода - набор типов, которые принимает метод 
// + тот тип/ы который он возвращает 
// в нашем случае сигнатура метода - int bool 

// теперь у нас есть тип данных MyMethDelegate
// создаем переменную такого типа и работаем с ней как с методом
// MyMethDelegate methodToUse = IsEven;
// var r = methodToUse(2);
// Console.Write(r);

//теперь хотим метод, который принимает массив чисел + метод их проверки, обрабатывает данные массива по этому мктоду и возвращает новый массив обработанных чисел 

int[] CheckArray(int[] nums, Func<int, bool> logitToUse)
{
    int count = nums.Length;
    int countEven = 0;

    for (int i = 0; i < count; i++)
    {
        if (logitToUse(nums[i])) countEven++;
    }

    int[] evenNums = new int[countEven];
    int pos = 0;
    for (int i = 0; i < count; i++)
    {
        if (logitToUse(nums[i]))
        {
            evenNums[pos] = nums[i];
            pos++;
        }
    }

    return evenNums;
}

// int[] ints = CheckArray(new int[] { 2, 3, 4, 50 }, IsEven); //можнос делать анонимный метод

// int[] ints = CheckArray(new int[] { 2, 3, 4, 50 }, delegate (int x)
// {
//     return x % 2 == 0;
// });

// делаем через Такое что
// int[] ints = CheckArray(new int[] { 2, 3, 4, 50 }, (int x) =>
// {
//     return x % 2 == 0;
// });

// если тело метода состоит из одного оператора то фиг скобки не нужны
// int[] ints = CheckArray(new int[] { 2, 3, 4, 50 }, (int x) => x % 2 == 0;);

//в делегате уже описаны все типы, поэтому типы можнм отсюда убрать 
// так приходим к лямбда выражению
int[] ints = CheckArray(new int[] { 2, 3, 4, 50 }, x => x % 2 == 0);
//переписываем делегат на системный тип шарпа и сразу запихать его как аргумент метода выше, где прописывали делегат
// Func<int, bool> m = x % 2 == 0;

Console.WriteLine(String.Join(", ", ints));


// delegate bool MyMethDelegate(int value); // описали переменную которая содержит ссылку на метод. Делегат мы воспроизвели по сигнатуре метода. Делегат полностью повторяет эту сигнатуру 

