// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число => ");
string strInput = Console.ReadLine();
int[] arr = new int[strInput.Length];
    for (int i = 0; i < strInput.Length; i++)
    {
        arr[i] = Convert.ToInt32(strInput.Substring(i, 1));
    }
Console.WriteLine($"Сумма цифр в введенном числе равна {Sum()}.");

int Sum()
{
    int sum = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        sum = sum + arr[j];
    }
    return sum;
}
