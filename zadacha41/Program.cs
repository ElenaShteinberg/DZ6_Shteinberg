// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2-> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

void NewArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write("Введите значение элемента массива: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] numbers)
{
    int length = numbers.Length;
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
}

int NumberSearch(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
            sum++;
    }
    return sum;
}
Console.Write("Укажите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
NewArray(array);
PrintArray(array);
Console.WriteLine("Чисел больше 0: " + NumberSearch(array));

