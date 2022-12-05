/*Напишите программу, которая выводит третью цифру заданного числа, 
или сообщает, что третей цифры нет

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

//Метод проверки на 3-х значность
void CheckNumber(int number)
{
    int checknum = Math.Abs(number) / 100;
    if (checknum < 1 )
        Console.Write("Третьей цифры нет!");
    else if (checknum > 10 )
    {
        Console.Write("Введено не 3-х значное число! Прерывание!");
    }
    else ShowNumber(number);
}

//Метод возвращает 3 цифру числа
void ShowNumber(int num)
{
    string strnum = num.ToString();
    Console.WriteLine(strnum[2]);
}

int num = GetNumber("Введите 3-х значное число: ");
CheckNumber(num);