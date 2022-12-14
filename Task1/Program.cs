//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите количество чисел");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа");
int[] num = new int[a];
int count = 0;

void CreateArray()
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = Convert.ToInt32(Console.ReadLine());
        if (num[i] > 0) count++;
    }
    string x = string.Join(", ", num);
    Console.WriteLine(x);
    System.Console.WriteLine($"Количество положительных чисел равно {count}");
}
CreateArray();

//Console.WriteLine(num.Length);