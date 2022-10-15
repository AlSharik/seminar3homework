//Задача 1
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не применять строки!
//14212 -> нет
//12821 -> да
//23432 -> да

int Prompt()
{
    Console.WriteLine("Write number >");
    string inputString = Console.ReadLine();
    int value = Convert.ToInt32(inputString);
    return value;
}
bool Test( int number)
{
    if (number % 10 == number / 10000 && (number % 100) / 10 == (number / 1000) % 10)
    return true;
    else
    return false;
}

int number = Prompt();
if(Test( number))
{
    System.Console.WriteLine(" Полиндром");
}
else
{
    System.Console.WriteLine(" Не полиндром");
}