// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());


string[] Array()
{
    string[] newArray = new string[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"введите элемент {i + 1}: ");
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < size; i++) Console.Write($"{array[i]} ");
}

string[] FinalArray(string[] array)
{
    string[] newArray = new string[array.Length];
    int j = 0;
    for(int i = 0; i < size; i++)
    {
        if(array[i].Length < 4)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

string[] MyArray = Array();
Console.WriteLine();
ShowArray(MyArray);
Console.WriteLine();
ShowArray(FinalArray(MyArray));
