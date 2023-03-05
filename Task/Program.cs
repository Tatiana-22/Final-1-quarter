/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше или равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
коллекциями, лучше обойтись исключительно массивами.*/


string[] worldsArray = new []{"hello","world","678",":)"}; 
Console.WriteLine("Исходный массив строк");
PrintArray(worldsArray);
string[] newArray1 = CheckArray(worldsArray);
Console.WriteLine("Новый массив строк");
PrintArray(newArray1);

void PrintArray(string[] arr)
{
    for (int i=0; i<arr.GetLength(0); i++)
    {
        Console.Write($"{arr[i]} ");
        System.Console.WriteLine();
    }
}

string[] CheckArray(string[] arr)
{
    string[] newArray = new string []{};
    for (int i=0; i<arr.Length; i++)
    {
        if(arr[i].Length <= 3)
        {
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[newArray.Length - 1] = arr[i];
        }
    }
    return newArray;
}
