/* Task: Write a program that from an array of strings forms an array of strings with a length of no more than 3 characters.
1. Create method for print arrays.
2. Create method to generate result array.
3. Create start array and fill it with strings.
4. Create variable for result array and call a method(from step 2) and pass an array(from step 3) to it.
5. Call a method(from step 1) and pass an array(from step 4) to it.
*/

string[] ArrayElementsLessThan3Char(string[] arr)
{
    int resultArrayLength = 0;
    int resultArrayIndex = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 3) resultArrayLength++;
    }

    string[] result = new string[resultArrayLength];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 3)
        {
            result[resultArrayIndex] = arr[i];
            resultArrayIndex++;
        }
    }

    return result;
}

void PrintArray(string[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            Console.Write($"{arr[i]}");
            break;
        }
        Console.Write($"{arr[i]}, ");
    }

    Console.Write("]");
}