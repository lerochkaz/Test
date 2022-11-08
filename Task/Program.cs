int numberOfCharacters = 3;
int sizeArray = 6;
string[] arrayOne = new string[sizeArray];


Console.WriteLine($"Введите набор символов, обозначающих элемент массива, {sizeArray} раз через энтер без пробелов и запятых: ");
FillArray(arrayOne);
Console.Clear();
PrintArray(arrayOne);
Console.WriteLine();

if (CountingElements(arrayOne) == 0) Console.WriteLine($"В массиве нет элементов с длиной больше или равной {numberOfCharacters} символам");
else
{
    Console.Write($"Получившийся массив из элементов, длина которых меньше или равна {numberOfCharacters} символам: ");
    string[] arrayTwo = FillNewArray(arrayOne);
    PrintArray(arrayTwo);
}


void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine()!;
    }
}


void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write(array[i] + " ");
        else Console.Write(array[i] + ", ");
    }
    Console.Write("]");
}


int CountingElements(string[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= numberOfCharacters) counter++;
    }
    return counter;
}


string[] FillNewArray(string[] array)
{
    string[] newArray = new string[CountingElements(arrayOne)];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= numberOfCharacters)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}
