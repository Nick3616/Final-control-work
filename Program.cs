string[] ImputArray(int length)
{

}

string[] CheckArray(string[] array)
{ 

}

int CheckNumbersArray(string[] array)
{ 
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

