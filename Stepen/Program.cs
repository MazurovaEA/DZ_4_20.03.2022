// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
int A = Prompt("Введите число A => ");
int B = Prompt("Введите число B => ");
int degree = Degree(A, B);
Console.WriteLine($"Число {A} в степени {B} равно {degree}");

int Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

int Degree(int aNumber, int bNumber)
{
    int degreeNumber = 1;
    for (int i = 1; i <= bNumber; i++)
    {
        degreeNumber = degreeNumber * aNumber;
    }
    return degreeNumber;
}
