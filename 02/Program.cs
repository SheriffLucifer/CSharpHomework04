Console.Clear();
int number = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
int getNumber = GetNumber(number);
Console.WriteLine($"{number} -> {getNumber}");

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetNumber(int number)
{
    int result = 0;

    while (number > 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}