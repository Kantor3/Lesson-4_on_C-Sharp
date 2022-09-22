/*
Урок 4. Функции продолжение
*/

bool CheckExit(dynamic num)
{
    if (num == 0)
    {
        Console.WriteLine("\nРабота с программой завершена, До встречи!\n");
        return true;
    }
    return false;
}

/*-----------------------------------------------------------------
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
-------------------------------------------------------------------
*/
// Осночное тело программы
// =======================
Console.WriteLine("Задача-25. возводим число A в натуральную степень B = {A, B} ");
Console.WriteLine("---");
Console.WriteLine($@"Для получения A^B введите два числа: 1-е - A
                                     2-е - B, 
                                     '0' - для завершения:");
int i = 0;
char AB_txt = '?';
double[] arr_pow = new double[2];

while (true)
{
    Console.WriteLine("");
    for (i = 0; i < 2; i++)
    {
        AB_txt = i == 0 ? 'A' : 'B';
        Console.Write($"{AB_txt} => ");
        arr_pow[i] = Convert.ToInt16(Console.ReadLine());
    }
    if (CheckExit(arr_pow[0]*arr_pow[1]))
        break;
    Console.Write($"A = {arr_pow[0]}, B = {arr_pow[1]}: A^B = {Math.Pow(arr_pow[0], arr_pow[1])}\n");

}
// *** Конец Задачи 25 ***


/*-----------------------------------------------------------------
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
-------------------------------------------------------------------
*/
// Осночное тело программы
// =======================
Console.WriteLine("Задача-27. Подсчитываем сумму цифр в числе");
Console.WriteLine("---");
Console.WriteLine($@"Введите число, или '0' - для завершения:");

while (true)
{
    Console.WriteLine("");
    int number = Convert.ToInt32(Console.ReadLine()), number_save = number;
    int sum_digits = 0;

    if (CheckExit(number))
        break;

    while (number > 1)
    {
        sum_digits += number % 10;
        number /= 10;
    }
        
    Console.Write($"Сумма цифр числа {number_save} = {sum_digits}\n");
}
// *** Конец Задачи 27 ***


/*-----------------------------------------------------------------
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
-------------------------------------------------------------------
*/
dynamic[] GetArr_elem(int size)
{
    dynamic[] arr = new dynamic[size];
    int i;
    for (i = 0; i < size; i++)
    {
        Console.Write($"{i+1} => ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

// Осночное тело программы
// =======================
Console.WriteLine("Задача-29. Вводим данные для заполнения и вывод его на экран");
Console.WriteLine("---");
Console.WriteLine("'0' - для завершения:");

while (true)
{
    Console.Write("\nУкажите размер массива Size = ");
    int dim = Convert.ToInt32(Console.ReadLine());

    if (CheckExit(dim))
        return;

    bool one_item = true;
    string sep;
    foreach (var item in GetArr_elem(dim))
    {
        sep = one_item ? "[" : ", ";
        one_item = false;
        Console.Write($"{sep}{item}");
    }
    Console.Write("]");
}
// *** Конец Задачи 29 ***