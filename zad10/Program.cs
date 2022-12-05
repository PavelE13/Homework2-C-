/*Напишите программу, которая принимает на вход трехзначное число и на 
выходе показывает вторую цифру этого числа
456->5
782->8
918->1
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

//Метод возвращает 2 цифру числа
void ShowNumber(int num)
{
    string strnum=num.ToString();
    Console.WriteLine(strnum[1]);
}

int num = GetNumber("Введите 3-х значное число: ");
ShowNumber(num);