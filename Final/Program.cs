string[] array = { "hello", "2 ", "world", ":-)" };
string[] array1 = { "1234", "1567", "-2", "computer science"};
string[] array2 = { "Russia", "Denmark ", "Kazan"};
void PrintElement(string[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write(array[i] + " ");
        }
    }
}
PrintElement(array);
Console.WriteLine();
PrintElement(array1);
Console.WriteLine();
PrintElement(array2);
