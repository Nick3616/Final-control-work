string[] ImputArray(int length)
{

}

string[] CheckArray(string[] array)
{ 

}

int CheckNumbersArray(string[] array)
{ 

}

Console.Write("Введите количество элементов массива: ");
int length = int.Parse(Console.ReadLine()!);
if(length < 0)
{
    Console.Write("Вы ошиблись!\nВведиет положительное количество элементов массива :");
    length = int.Parse(Console.ReadLine()!);
}

