string[] MyMassive = { "Cat","Dog","Pig","Rabbit","Horse","Duck" };

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"'{array[i]}', ");
        else Console.Write($"'{array[i]}'");
    }
    System.Console.Write("]");
}

string[] NewArray(string[] arr)
{
    int numberOfData = 0; 
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) numberOfData += 1;
    }
    
    string[] newArray = new string[numberOfData];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) newArray[i] = arr[i];
    }
    return newArray;
}

string[] result = NewArray(MyMassive);
PrintArray(result);