string[] ImputArray(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i+1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] CheckArray(string[] array)
{ 
    int count = 0;
    string[] result = new string[CheckNumbersArray(array)];
for(int i = 0;  i < array.Length; i++)
    { 
        if (array[i].Length < 4)
        {
            result[count] = array[i];
            count++;
        }
    }
return result;
}

int CheckNumbersArray(string[] array)
{ 
    int count = 0;
for(int i = 0;  i < array.Length; i++)
    { 
        if (array[i].Length < 4)
        {
            count++;
        }
    }
return count;
}

Console.Write("Введите количество элементов массива: ");
int length = int.Parse(Console.ReadLine()!);
if(length < 0)
{
    Console.Write("Вы ошиблись!\nВведиет положительное количество элементов массива :");
    length = int.Parse(Console.ReadLine()!);
}

string[] array;
string[] result;
array = ImputArray(length);
result = CheckArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", result)}]");
