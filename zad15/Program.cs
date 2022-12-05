/*Напишите программу, которая принимает на вход цифру, обозначающую
день недели, и проверяет, является ли этот день выходным

645->5
78-> третьей цифры нет
*/

// Метод проверки вводимых данных на число
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
            return result;
        else
            Console.WriteLine("Вы ввели не число");
    }
    return result;
}

//Метод проверки диапазона от 1 до 7
void CheckNumber(int number)
{
    if (number < 1 || number > 7)
        Console.Write($"Ошибка.Введенное число {number} не соответствует дню редели (вне диапазона)!");
    else ShowNumber(number);
}

//Метод проверяет выходной или нет
void ShowNumber(int num)
{
    if (num == 6 || num == 7)
        Console.WriteLine($"День № {num} - выходной!");
    else Console.WriteLine($"День № {num} - рабочий!");
}

int num = GetNumber("Введите число от 1 до 7: ");
CheckNumber(num);