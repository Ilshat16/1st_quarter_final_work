// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// 1. Создать 2 пустых массива из num элементов. Назовем их firstArray, secondArray
// 2. Заполнить массив firstArray строками, пусть будет, с клавиатуры.
// 3. Найти среди элементов первого массива строки, состоящих из 3 или меньше символов.
// 4. Последовательно заполнить второй массив найденными строками.
// 5. Удалить пустые элементы второго массива.

string[] FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{i+1}. ");
        array[i] = EnterData("Введите текст: ");
    }
    return array;
}

string EnterData(string text)
{
    Console.Write(text);
    string str = Console.ReadLine();
    return str;
}

int num = 10;
string[] firstArray = new string[num];
string[] secondArray = new string[num];
FillArray(firstArray);
Console.WriteLine($"[{string.Join(", ", firstArray)}]");
// SearchElems(firstArray, secondArray);
// DeleteEmptyElems();
