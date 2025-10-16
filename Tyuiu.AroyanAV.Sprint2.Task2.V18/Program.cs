using Tyuiu.AroyanAV.Sprint2.Task2.V18.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнила: Ароян А. В. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор if - полная и краткая форма записи                       *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #18                                                             *");
Console.WriteLine("* Выполнила: Ароян Армине Вачагановна | ИСТНб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *");
Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в                     *");
Console.WriteLine("* заштрихованной области.                                                 *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение переменной X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение переменной Y: ");
int y = Convert.ToInt32(Console.ReadLine());

bool res = ds.CheckDotInShadedArea(x, y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
if (res)
{
    Console.WriteLine("Точка находится в заштрихованной области");
}
else
{
    Console.WriteLine("Точка не находится в заштрихованной области");
}

Console.ReadKey();