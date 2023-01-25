string[] arrayInitial = new string[7] {"^@^", "45", "hello", "task", "yes", "378", "/*"};
string[] arrayFinal = new string[arrayInitial.Length];
void InputArray(string[] arrayInitial, string[] arrayFinal)
{
    int count = 0;
    for (int i = 0; i < arrayInitial.Length; i++)
    {
    if(arrayInitial[i].Length <= 3)
        {
        arrayFinal[count] = arrayInitial[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}
InputArray(arrayInitial, arrayFinal);
PrintArray(arrayFinal);