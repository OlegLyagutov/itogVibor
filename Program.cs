// Задача: Написать программу, которая из имеющегося массива
// строк формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с
// клавиатуры, либо задать на старте выполнения алгоритма. При
// решении не рекомендуется пользоваться коллекциями, лучше
// обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



string[] array = new string[] { "Hello", "132", "Russia", "4", "Yes" };

void PrintArray(string[] Array)
{

    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine();
}

void Resultarray(string[] Array)
{
       for (int i = 0; i < Array.Length; i++)
    {
        string element = Array[i];
        if (element.Length <= 3)
        {
            Array[i] = element;
        }
        else Array[i] =  string.Empty;

    }
}

PrintArray(array);

Resultarray(array);

Console.WriteLine(" ");

PrintArray(array);


