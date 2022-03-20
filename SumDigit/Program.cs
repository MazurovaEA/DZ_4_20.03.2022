// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int[] arr = Prompt("Введите число => ");
Console.WriteLine($"Сумма цифр в введенном числе равна {Sum()}.");

int[] Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int[] arr = new int[strInput.Length];
    for (int i = 0; i < strInput.Length; i++)
    {
        arr[i] = Convert.ToInt32(strInput.Substring(i, 1));
    }
    return (int[])arr;
}

int Sum()
{
    int sum = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        sum = sum + arr[j];
    }
    return sum;
}