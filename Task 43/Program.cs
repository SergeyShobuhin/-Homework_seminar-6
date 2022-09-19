// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


//функция вычесления
string GetIntersectionPoint(double b1, double k1, double b2, double k2)
    {
        string rez = "прямые не пересекаются ";
        double x = (-b2 + b1)/(-k1 + k2);
        double y = k2 * x + b2;
        string rezult = $"прямые пересекаются в точке: ({Math.Round(x, 2)} ; {Math.Round(y, 2)})";
                    
        return rezult;
        }
    
// Ввод чисел
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

//вызов функции
var checkPoint = GetIntersectionPoint(b1,k1,b2,k2);

//вывод значения
Console.WriteLine(checkPoint);
