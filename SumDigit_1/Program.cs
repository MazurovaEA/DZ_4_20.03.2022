// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int[] arr = Prompt("Введите число => ");
Console.WriteLine($"Сумма цифр в введенном числе равна {Sum(arr)}.");

int[] Prompt (string message)
{
Console.Write(message);
string strInput = Console.ReadLine();
int[] arr = new int[strInput.Length];
    for (int i = 0; i < strInput.Length; i++)
    {
        arr[i] = Convert.ToInt32(strInput[i]);
    }
return (int[])arr;
}

int Sum(int[] arr)
{
    int sum = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        sum = sum + arr[j];
    }
    return sum;
}


//strInput.Substring(i, 1) можно написать так strInput[i]

//Метод int Sum() должен принимать на вход параметр массив, то есть мы передаем в фугкцию массив: int Sum(int[] arr)
//ну и не забываем при вызове функции Console.WriteLine($"Сумма цифр в введенном числе равна {Sum(arr)}.");