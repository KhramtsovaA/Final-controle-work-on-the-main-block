System.Console.Write($"Введите, пожалуйста, значения через запятую в одну строчку для использования в массиве: ");

string? word = Console.ReadLine();

string[] CreateArray()      // Создаем массив из введенных элементов.
{
   
    string[] arrayAll = word.Split(",");
    return arrayAll;
}

string[] FinalArray()  // Метод для создания массива cогласно условиям.
{
    string[] array = CreateArray();
    string Finalstring = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Finalstring = Finalstring + array[i] + ",";
        }
        else
        {
            Finalstring = " ";
        }
    }
    Finalstring = Finalstring.Remove(Finalstring.Length - 1); 
    string[] NewArray = Finalstring.Split(",");
    return NewArray;
}

string[] array = CreateArray();
System.Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]"); // Исходный массив.

System.Console.WriteLine($"Массив согласно условиям: [{string.Join(", ", FinalArray())}]");


