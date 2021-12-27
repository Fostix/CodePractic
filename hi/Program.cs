// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.




int[] somethingArray = new int[20];




void FillArray(int[] fill)
{
    for (int row = 0; row < fill.Length; row++)
    {
        fill[row] = new Random().Next(-10, 10);
    }
    fill[4] = 1;
}


int[] ForCopyMethod(int[] array)
{
    int temp;
    int count = 0;
    for (int row = 0; row < array.Length; row++)
    {
        if (0 == array[row] % 2)
        {
            temp = array[row];
            for (int howRow = 0; howRow < array.Length; howRow++)
            {
                if (0 != array[howRow] % 2)
                {
                    array[howRow] = temp;
                    count++;
                    break;
                }
            }
        }
    }

    int[] newArray = new int[count];

    for (int row = 0; row < count; row++)
    {
        newArray[row] = array[row];
    }

    return newArray;
}

void PrintArray(int[] print)
{
    for (int row = 0; row < print.Length; row++)
    {
        Console.Write(print[row] + " ");
    }
}


FillArray(somethingArray);
PrintArray(somethingArray);
int[] mrArray = ForCopyMethod(somethingArray);
Console.WriteLine();
PrintArray(mrArray);


