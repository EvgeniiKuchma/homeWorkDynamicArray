using System;

namespace homeWorkDynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandSum = "sum";
            const string CommandExit = "exit";

            bool isWork = true;

            string userInput;

            int sum = 0;

            int[] array = new int[0];
            int[] tempArray;

            while (isWork)
            {
                Console.Write("Ваш массив выглядит как-то так: ");

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }

                Console.WriteLine("\nВыберете пункт меню: \n");
                Console.WriteLine($"{CommandSum}. Сложить все числа массива.");
                Console.WriteLine($"{CommandExit}. Выход.");
                Console.Write("\nИли введите число: ");

                userInput = Console.ReadLine();

                if (userInput == CommandSum)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += array[i];
                    }

                    Console.WriteLine("Cумма всех чисел массива равна " + sum + "\n\n");
                }
                else if (userInput == CommandExit)
                {
                    isWork = false;
                }
                else
                {
                    tempArray = new int[array.Length + 1];

                    for (int i = 0; i < array.Length; i++)
                    {
                        tempArray[i] = array[i];
                    }

                    tempArray[tempArray.Length - 1] = Convert.ToInt32(userInput);
                    array = tempArray;
                }
            }
        }
    }
}

