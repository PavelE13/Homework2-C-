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
        {
            return result;
        }
        else 
            Console.WriteLine("Вы ввели не число");
        if(Math.Abs(result)/1000<0)
        {
            return result;
        }
        else Console.WriteLine("Вы ввели не 3-х значное число");
    }
    return result;
}


int num = GetNumber("Введите 3-х значное число: ");

