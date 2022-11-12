Console.Clear();
int size = 5;
int a = 3;
string[] arrayarrayFirst = new string[size];

Console.WriteLine($" введите набор символов {size} раза, которые обозначают значения элементов массива, через Enter ");
FillArray(arrayarrayFirst);
Console.Clear();
PrintArray(arrayarrayFirst);
Console.WriteLine();
Console.WriteLine("Созданный массив, содержащий нужные элементы :");
if (SizeMassivArray(arrayarrayFirst)==0)
{
    Console.Write($" из {size} введенных наборов символов, нет тех, которые меньше либо равны {a} ");
}
else
{
    string[] arraySecond = GoMassiv(arrayarrayFirst);
    PrintArray(arraySecond);
}

int SizeMassivArray(string[] arr)
{
    int tempSize = 0;
    for (int i = 0; i < size; i++)
    {
        if(arr[i].Length <= a)
        {
            tempSize++;
        }
    }
    return tempSize;

}




void FillArray (string[] arr)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine() ?? "";
    }

}

void PrintArray(string[] arr)
{
    int arrLen = arr.Length;
    Console.Write(" [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ; ");
    }
    Console.Write("] ");
}

string[] GoMassiv(string[] arr)
{
    string[] arraySecond = new string[SizeMassivArray(arrayarrayFirst)];
    for (int i = 0, j = 0; i < size; i++)
    {
        if(arr[i].Length <= a)
        {
            arraySecond[j] = arr[i];
            j++;
        }
    }
    return arraySecond;
}