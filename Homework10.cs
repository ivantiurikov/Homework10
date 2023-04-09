//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

string[] CreateArray(int size)
{
    string[] array = new string[size];
    for(int i=0; i<size; i++)
    {
        Console.WriteLine($"Input the element with index {i}");
        array[i] = Console.ReadLine();
    }
    return array;
}

void ShowArray (string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length != 0)
        Console.Write ($"'{array[i]}'," + " ");
    }
    Console.WriteLine ();
}

int Check(string[] array)
{
    int count = 0;
    for(int i=0;i<array.Length;i++)
    {
        if(array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] CreateNewArray(string[] array, int count)
{
    string[] Array = new string[count];
    int j = 0;
    for(int i=0;i<array.Length;i++)
    {
        if(array[i].Length <= 3)
        {
            Array[j] = array[i];
            j++;
        }
    }
    return Array;
}
