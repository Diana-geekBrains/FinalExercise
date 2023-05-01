string[] array1 = new string[8] {"123", "love", "387", "world", "git", "pul", "94457", "мир"};
string[] array2 = new string[array1.Length];
void SecondArryWithElements(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArryWithElements(array1, array2);
PrintArray(array2);
