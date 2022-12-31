/*Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести
с клавиатуры, либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно
массивами.*/

Console.Clear();

string[] AskArray(string value) // Запоняем массив:
{
    Console.WriteLine(value);
    return Console.ReadLine().Split(" ");
}

void SelectingArrayElements(string[] oldArray, string[] newArray) // Извлечение из массива
// заданных элементов:
{
    int count = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
       if(oldArray[i].Length <= 3)
       {
            newArray[count] = oldArray[i];
            count++;           
       } 
    }
}

string[] oldArray = AskArray("Введите значения через пробел: ");
string[] newArray = new string[oldArray.Length];

SelectingArrayElements(oldArray, newArray);

Console.WriteLine($"[{string.Join(" ", oldArray)}] -> [{string.Join(" ", newArray)}]");
