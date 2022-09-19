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

Console.WriteLine("Введите размер массива через пробел от 1 до N: ");
string[] array;
string elements = Console.ReadLine();

array = elements.Split(" ");

string[] newArray = new string[array.Length];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i+1} элемент:");
    array[i] = Console.ReadLine();
}
Console.WriteLine($"[{String.Join(", ", array)}]");

//string[] newArray;
if (array.Length <= 3)
{
   int i = 0;
   Console.WriteLine($"[{String.Join(", ", newArray)}]");;
   i++;
} 
//Console.WriteLine($"[{String.Join(", ", newArray)}]");
Console.ReadLine();


