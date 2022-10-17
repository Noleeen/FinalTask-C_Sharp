// финальная задача C#

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
    for(int i = 0; i < size; i++)
    {
        if(array[i].Length < 4)
        {
            newArray[i] = array[i];
        }
    }
    return newArray;
}

string[] MyArray = Array();
Console.WriteLine();
ShowArray(MyArray);
Console.WriteLine();
ShowArray(FinalArray(MyArray));
