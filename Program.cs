﻿/*
Задача: Написать программу, которая из имеющегося массива 
строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/



int LengthNewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}


void ReleaseMass(string[] array)
{
    string[] new_array = new string[LengthNewArray(array)];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            new_array[j] = array[i];
            j++;
        }
    }
    Console.WriteLine($"[{string.Join(", ", new_array)}]");
}


Console.Clear();
string[] array = Console.ReadLine()!.Split(" ").ToArray();
ReleaseMass(array);
