Console.Clear();
int firstNumber = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int secondNumber = GetNumberFromUser("Введите целое число B: ", "Ошибка ввода!");
int getNumber = GetNumber(firstNumber, secondNumber);
Console.WriteLine($"{firstNumber}, {secondNumber} -> {getNumber}");

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

int GetNumber(int firstNumber, int secondNumber)
{
    int result = 1;

    for (int i = 1; i <= secondNumber; i++)
    {
        result = result * firstNumber;
    }
    return result;
}