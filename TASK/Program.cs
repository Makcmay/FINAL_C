Console.Clear();

Console.WriteLine("Введите массив символов через пробел");
string stroka = Console.ReadLine();

string[] array = stroka.Split(" ").ToArray();

if (stroka.Length != 0)
{
    string[] result = new string[array.Length];
    int size = 0;

    foreach (var element in array)
    {
        if (element.Length <= 3)
        {
            result[size] = element;
            size++;
        }
    }
    Console.WriteLine(string.Join(Environment.NewLine, result, 0, size));
    Console.ReadKey(true);
}
else Console.WriteLine($"Вы ничего не ввели! Запустите программу заново.");