//  Написать программу, которая из имеющегося массива 
//  строк формирует массив из строк, длина которых меньше 
//  либо равна 3 символа. Первоначальный массив можно ввести 
//  с клавиатуры, либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.
//  Примеры:
// ["hello", "2", "world", -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []
Console.Clear();

string[] arrBegin = WriteArray();
PrintArray(arrBegin);

string[] WriteArray()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}