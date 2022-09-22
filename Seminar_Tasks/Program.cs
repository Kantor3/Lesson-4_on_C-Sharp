/* Тема Урока-4 (семинар)
Функции продолжение
*/

/*
Задача-1. На вход дается число - 
на выходе получить сумму всех целых чисел от 1 до введенного числа A
*/
/*
int FindSum(int a)
{
    int sum = 0;
    for (int current = 1; current <= a; current++)
        sum += current;

    return sum;
}

Console.Write("Input position integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"sum of numbers from 1  to {num} is {FindSum(num)}");
*/
// *** Конец Задачи 1 семинара ***


/*
Задача-2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
*/
int CheckNumber(string str)
{
    if (!Int32.TryParse(str, out int number))
    {
        number = -1;
        Console.WriteLine($"Введенная строка '{str}' не являются числом\nПопробуйте еще раз\n");
    }
    if (number > 0)
        Console.WriteLine($"Будет анализироваться число => {number}");
    return number;
}

bool CheckExit(int num)
{
    if (num == 0)
    {
        Console.WriteLine("\nРабота с программой завершена, До встречи!\n");
        return true;
    }
    return false;
}

// Осночное тело программы
// =======================
Console.WriteLine("Задача-1. Сколько цифр в числе?");
Console.WriteLine("---");
int maxlen_number = 9;
Console.WriteLine($@"Введите любое число (не более {maxlen_number} цифр, 
                число длинее {maxlen_number} цифр будет обрезано!), или '0' для завершения:");

while (true)
{
    string? str_number = Convert.ToString(Console.ReadLine());
    int number = CheckNumber(str_number.Substring(0, Math.Min(maxlen_number, str_number.Length)));
    string? str_CropNumber = Convert.ToString(number);
    if (number < 0)
        continue;
    if (CheckExit(number))
        break;

    Console.WriteLine($"В числе {str_CropNumber} {str_CropNumber.Length} цифр\n");
}
// *** Конец Задачи 2 семинара ***


/*
Задача-3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
*/
int GetFactorial(int number)
{
    int i, factorial = 1;
    for (i = 1; i <= number; i++)
        factorial *= i;
    return factorial;
}

// Осночное тело программы
// =======================
Console.WriteLine("Задача-2. Считаем факториал (![numer])");
Console.WriteLine("---");
Console.WriteLine($@"Введите число, или '0' для завершения:");
while (true)
{
    int numb1 = Convert.ToInt32(Console.ReadLine());
    if (CheckExit(numb1))
        break;

    Console.WriteLine($"{numb1}! = {GetFactorial(numb1)}");
}
// *** Конец Задачи 3 семинара ***


/*
Задача-4. Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке
*/
int[] GetArr_Rnd(int size)
{
    int[] arr_bool = new int[size];
    Random binary_rnd = new Random();
    int i;
    for (i = 0; i < size; i++)
        arr_bool[i] = binary_rnd.Next(0, 2);
    return arr_bool;
}

// Осночное тело программы
// =======================
Console.WriteLine("Задача-3. Формируем массив случайных n элементов = {1, 0} ");
Console.WriteLine("---");
Console.WriteLine($@"Введите размер единичный массива, '0' - для завершения:");

while (true)
{
    Console.WriteLine("");
    int size = Convert.ToInt16(Console.ReadLine());
    if (CheckExit(size))
        break;

    foreach (var item in GetArr_Rnd(size))
        Console.Write($"{item}, ");
}
// *** Конец Задачи 3 семинара ***