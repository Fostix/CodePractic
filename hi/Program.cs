// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
int arrayLengthz = 5;
int[] first = new int[arrayLengthz];




void FillArray(int[] fill)
{
    for (int row = 0; row < fill.Length; row++)
    {
        fill[row] = new Random().Next(1, 10);
    }
}
FillArray(first);
for (int i = 0; i < first.Length; i++)
{
    //Console.Write(first[i]);
}



(int[], int) ForShift(int[] first)
{
    int temp;
    int count = 0;
    for (int row = 0; row < first.Length; row++)
    {
        if (0 == first[row] % 2)
        {
            temp = first[row];
            first[row] = 0;
            for (int howRow = 0; howRow < first.Length; howRow++)
            {
                if (0 != first[howRow] % 2 | 0 == first[howRow])
                {
                    first[howRow] = temp;
                    count++;
                    break;
                }
            }
            Console.Write(temp + " темп");
        }
    }
    return (first, count);
}


(int[], int) lol = ForShift(first);
int[] array = lol.Item1;
int count = lol.Item2;


for (int i = 0; i < count; i++)
{

    Console.Write(array);
}


//Console.WriteLine(count);


//int[] arrayCopy = new int[count];






// for (int row = 0; row < arrayCopy.Length; row++)
// {
//     arrayCopy[row] = first[row];
// }

// Console.WriteLine();

// for (int row = 0; row < first.Length; row++)
// {
//     Console.WriteLine(first[row] + "ар");
// }
// //Console.WriteLine(count);
// Console.WriteLine();

// for (int row = 0; row < arrayCopy.Length; row++)
// {
//     Console.WriteLine(arrayCopy[row] + "ар");
// }

