//Задача 2
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
double Prompt()
{
    Console.WriteLine("Write number >");
    string inputString = Console.ReadLine();
    double value = Convert.ToInt32(inputString);
    return value;
}
double Distance( double[] array1, double[] array2)
{
    double distance = 0;
    int index = 0;
    double sum = 0;
    while(index < 3)
    {
        sum+=(array1[index]-array2[index])*(array1[index]-array2[index]);
        index++;
    }
    distance = Math.Sqrt(sum);
    return distance;
}
double[] array1 = {0,0,0};
double[] array2 = {0,0,0};
double distance = 0;

int index = 0;
while (index < 3)
{
    array1[index] = Prompt();
    index++;
}
index = 0;

while (index < 3)
{
    array2[index] = Prompt();
    index++;
}

distance = Distance(array1, array2);
System.Console.WriteLine(distance);