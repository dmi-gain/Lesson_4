/*

Задача 2: Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12

*/


int Prompt(string message) // Функция вызова приглашения
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}

int numberInt = Prompt("Введите число => ");
int result = 0;

while (numberInt != 0)
{
    result = result + numberInt % 10; 
    numberInt = numberInt / 10;

}

System.Console.WriteLine(result);

