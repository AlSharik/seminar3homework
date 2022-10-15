//Задача 3
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
int Prompt()
{
    Console.WriteLine("Write number >");
    string inputString = Console.ReadLine();
    int value = Convert.ToInt32(inputString);
    return value;
}
int number = Prompt();
int index = 1;
while(index <= number)
{
    System.Console.Write($"{index * index * index}, ");
    index++;
}