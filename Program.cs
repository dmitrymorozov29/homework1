﻿// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90]

int [] array = new int[10]; // создаем массив array с количеством элементов - целых чисел - 10
System.Console.Write("для массива, состоящего из 10 случайных чисел: "); // выводим пояснение в ответ
for(int i=0; i<array.Length; i++) // создаем цикл заполнения массива значениями элементов случайными числами
{
  array[i]=new Random().Next(0,101); // используем генератор случайных чисел, вводим диапазон значений от 0 до 101 (чтобы число 100 попало)
  System.Console.Write(array[i] + "  "); // выводим список элементов массива в ответе
}
int count = 0; // создаем счетчик чисел, удовлетворяющих условию
for(int i=0; i <array.Length; i++) // создаем цикл подсчета чисел, подходящих под условие
{
  
  if(array[i]<90) // вводим первую часть условия (ограничитель по макс значению)
  {
    if(array[i]>20) // вводим вторую часть условия (ограничитель по миним значению)
    {
      count++; // работа счетчика при выполнении условия
    }
               
  }

}

Console.WriteLine(", количество чисел, удовлетворяющих условию, равно: " + count); // вывод последней части ответа