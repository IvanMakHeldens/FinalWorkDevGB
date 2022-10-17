// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:

// - [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// - [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// - [“Russia”, “Denmark”, “Kazan”] → []

int ReadNumber (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} 

string[] GetArray(int size)    // создаём массив, вводим размер и значения в терминале
{
    string[] arr = new string[size];
    Console.WriteLine("Введите строки для заполнения массива: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1}-ю строку: ");
        arr[i] = Console.ReadLine() ?? "";
    }
    return arr;
}

string[] NewArray(string[] arr)   // создаём второй массив
{
    int size = 0;
    for (int i = 0; i < arr.Length; i++)  // размер нового массива
    {
        if (arr[i].Length <= 3) 
        {
            size++;
        }
    }
    string[] arrNew = new string[size];
    int j = 0;
    for (int i = 0; i < arr.Length; i++) // заполнение нового массива
    {
        if (arr[i].Length <= 3)
        {
            arrNew[j] = arr[i];
            j++;
        }
    }
    return arrNew;
}

int arrSize = ReadNumber("Введите размер массива: ");
string [] arrayFirst = GetArray(arrSize);
Console.WriteLine($"Заданный массив: {string.Join (" ", arrayFirst)}");
string [] arrayNew = NewArray(arrayFirst);
Console.WriteLine($"Новый массив:    {string.Join (" ", arrayNew)}");
