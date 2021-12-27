// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
int arrayLengthz = 5;
int[] somethingArray = new int[arrayLengthz];




void FillArray(int[] fill)
{
    for (int row = 0; row < fill.Length; row++)
    {
        fill[row] = new Random().Next(1, 10);
    }
    // for(int row = 0; row < fill.Length; row++)
    // {
    //     Console.Write(fill[row] + " first");
    // }
}
FillArray(somethingArray);



int[] ForCopyMethod(int[] array)
{
    int temp;
    int count = 0;
    for (int row = 0; row < array.Length; row++)
    {
        if (0 == array[row] % 2)
        {
            temp = array[row];
            array[row] = 1;
            for (int howRow = 0; howRow < array.Length; howRow++)
            {
                if (0 != array[howRow] % 2 | 0 == array[howRow])
                {
                    array[howRow] = temp;
                    count++;
                    break;
                }
            }
            Console.Write(temp);
        }
    }

    int[] newArray = new int[count];

    for (int row = 0; row < count; row++)
    {
        newArray[row] = array[row];
    }

    Console.Write(count);
    return newArray;
}

int[] mrArray = ForCopyMethod(somethingArray);


PrintArray(mrArray);








// (int[], int) lol = ForShift(somethingArray);
// int[] newArray = lol.Item1;
// int count = lol.Item2;


// void forCopyMethod(int[] array, int count)
// {




// }



// forCopyMethod(int[] array)



// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array);
// }


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

