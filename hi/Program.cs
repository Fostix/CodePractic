// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
int arrayLengthz = 5;
int[] array = new int[arrayLengthz];
int temp;
int count = 0;
void FillArray(int[] fill)
{
    for (int row = 0; row < fill.Length; row++)
    {
        fill[row] = new Random().Next(1, 10);
    }
}
FillArray(array);

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
}

for (int row = 0; row < array.Length; row++)
{
    if (0 == array[row] % 2)
    {
        temp = array[row];
        array[row] = 0;
        for (int howRow = 0; howRow < array.Length; howRow++)
        {
            if (0 != array[howRow] % 2 | 0 == array[howRow])
            {
                array[howRow] = temp;
                count++;
                break;
            }
        }
        Console.Write(temp + " темп");
    }
}



Console.WriteLine();

for (int row = 0; row < array.Length; row++)
{
    Console.WriteLine(array[row] + "ар");
}
Console.WriteLine(count);