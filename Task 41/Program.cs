// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int count = 0; 

// функция расчёта > 0
int NumberGreaterZero(int [] array)
    {
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    count++;
                }
            }

        return count;        
    }


Console.Write("Введите чисела через пробел или запятую: "); // Ввод чисел
var array = Array.ConvertAll(Console.ReadLine().Split(' ', '.', ','), int.Parse); // отсекаем пробелы запятые и точки

NumberGreaterZero(array); // вызываем функцию

Console.WriteLine($"Чисел больше 0 = {count}"); // выводим результат

