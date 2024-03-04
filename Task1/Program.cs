static void ArrayToString(char[,] array)
{
    string superstring = "";

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            superstring += array[i, j];
        }
    }

    Console.WriteLine(superstring);
}

char[,] array = {{'a', 'b', 'c'}, {'d', 'e', 'f'}};
ArrayToString(array);
