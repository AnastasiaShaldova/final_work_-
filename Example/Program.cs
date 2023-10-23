using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива, разделенные запятой: ");
        string input = Console.ReadLine();

        string[] arr = input.Split(',');

        string[] newArr = FilterArray(arr);

        Console.WriteLine("Новый массив: ");
        foreach (string str in newArr)
        {
            Console.WriteLine(str);
        }

        Console.ReadLine();
    }

    static string[] FilterArray(string[] arr)
    {
        int count = 0;
        foreach (string str in arr)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] newArr = new string[count];

        int index = 0;
        foreach (string str in arr)
        {
            if (str.Length <= 3)
            {
                newArr[index] = str;
                index++;
            }
        }

        return newArr;
    }
}