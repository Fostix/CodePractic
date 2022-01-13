Console.Write("Enter size array: ");
int sizeArray = int.Parse(Console.ReadLine());
int[] array = new int[sizeArray];

void FillArray(int[] fill)
{
    for (int column = 0; column < fill.Length; column++)
    {
        fill[column] = new Random().Next(0, 10) * 2;
    }
}

void PrintArray(int[] print)
{
    for (int column = 0; column < print.Length; column++)
    {
        Console.Write(print[column] + " ");
    }
}

int HowManyEven(int[] even)
{
    int howEven = 0;
    for (int column = 0; column < even.Length; column++)
    {
        if (0 == even[column] % 2)
        {
            howEven++;
        }
    }
    return howEven;
}

int[] MrEven(int[] array, int many)
{
    int[] newArray = new int[many];
    int index = 0;
    for (int column = 0; column < array.Length; column++)
    {
        if (0 == array[column] % 2)
        {
            newArray[index] = array[column];
            index++;
        }
    }
    return newArray;
}





FillArray(array);
PrintArray(array);
int many = HowManyEven(array);
int[] newArray = MrEven(array, many);
Console.WriteLine();
PrintArray(newArray);


