string[] array = { "hello", "2 ", "world", ":-)" };
string[] array1 = { "1234", "1567", "-2", "computer science"};
string[] array2 = { "Russia", "Denmark ", "Kazan"};
string [] CopyArray = new string [array.Length];
string [] CopyArray1 = new string [array1.Length];
string [] CopyArray2 = new string [array2.Length];
Array.Copy(array, CopyArray, array.Length);
Array.Copy(array1, CopyArray1, array1.Length);
Array.Copy(array2, CopyArray2, array2.Length);
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
PrintElement(CopyArray);
Console.WriteLine();
PrintElement(CopyArray1);
Console.WriteLine();
PrintElement(CopyArray2);