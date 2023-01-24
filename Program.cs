// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// 1. Создать массив из num элементов. Назовем его firstArray
// 2. Заполнить массив firstArray строками, пусть будет, с клавиатуры.
// 3. Посчитать количество элементов массива, состоящих из 3 или меньше символов.
// 4. Создать второй массив и заполнить элементами из первого массива, состоящих из 3 или меньше символов.

string[] FillSecondArray(string[] firstArray, int count)
{
    string[] secondArray = new string[count];
    int j = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length < 4)
        {
            secondArray[j] = firstArray[i];
            j++;
        }
    }
    return secondArray;
}

int SearchElemsCount(string[] firstArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length < 4) count++;
    }
    return count;
}

string[] FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{i + 1}. ");
        array[i] = EnterData("Введите строку: ");
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
FillArray(firstArray);
int count = SearchElemsCount(firstArray);
string[] secondArray = FillSecondArray(firstArray, count);
Console.WriteLine();
Console.WriteLine("Массив из введенных строк, состоящих из 3 и менее символов:");
Console.WriteLine($"[{string.Join(", ", secondArray)}]");