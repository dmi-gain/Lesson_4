/*

Задача 1: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16

*/

int Prompt(string message) // Функция вызова приглашения
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}

int numberInt = Prompt("Введите первое число => ");
int degreeInt = Prompt("Введите второе число => ");
int result = 1;

int Expo(int numberInt) // Функция возведения числа в степень
{   
    
    for(int i = 0; i < degreeInt; i++)
    {
        result = result * numberInt;
    }
    return result;
}

Expo(numberInt); // Вызов функции
Console.WriteLine($"При возведении числа {numberInt} в степень {degreeInt} результат равен {result}");


/*  // Решение без использования фунций
System.Console.Write("Введите первое число => ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);

System.Console.Write("Введите второе число => ");
string degree = Console.ReadLine();
int degreeInt = int.Parse(degree);
int result = 1;
for (int i = 0; i < degreeInt; i++)
{
    result = result * numberInt;
}

System.Console.WriteLine($"При возведении числа {numberInt} в степень {degreeInt} результат равен {result}");
*/