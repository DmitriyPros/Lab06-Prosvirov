//Задание 1.1
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
}

//Задание 1.2
for (int i = 2; i <= 50; i += 2)
{
    Console.WriteLine(i);
}

//Задание 2
int c3 = 0;
int c7 = 0;
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0)
    {
        c3 += i;
    }
    if (i % 7 == 0)
    {
        c7++;
    }
}
Console.WriteLine($"Сумма чисел, кратных 3: {c3}");
Console.WriteLine($"Чисел, делящихся на 7: {c7}");

//Задание 3
int number = Convert.ToInt32(Console.ReadLine());
int total1 = 0;
int total2 = 0;

while (number != 0)
{
    if (number > 0)
    {
        total1++;
    }
    if (number < 0)
    {
        total2++;
    }

    number = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Положительных чисел: {total1}");
Console.WriteLine($"Отрицательных чисел: {total2}");

//Задание 4
bool iss = false;

for (int i = 0; i < 3; i++)
{
    Console.Write("Введите пароль: ");
    String password = Console.ReadLine();

    if (password == "qwerty")
    {
        Console.WriteLine("Доступ разрешён");
        iss = true;
        break;
    }
}
if (iss == false)
{
    Console.WriteLine("Доступ запрещён");
}

//Задание 5
Console.Write("Введите число n (от 1 до 9): ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 1 || n > 9)
{
    Console.WriteLine("Введите корректное число!");
}

else
{
    for (int i = 1; i <= 10; i++)
    {
        int s = n * i;
        Console.WriteLine($"{n} * {i} = {s}");
    }
}

//Задание 6
for (int i = 1; i <= 30; i++)
{
    if (i % 3 == 0)
    {
        continue;
    }
    if (i % 10 == 0 && i > 20)
    {
        break;
    }
    Console.WriteLine(i);
}

//Итоговая задача. «Угадай число»
int secret = 42;
bool iss = false;

for (int i = 1; i <= 5; i++)
{
    Console.Write($"Попытка {i}. Введите число: ");
    int g = Convert.ToInt32(Console.ReadLine());

    if (g == secret)
    {
        Console.WriteLine($"Победа! Попыток: {i}");
        iss = true; 
        break;
    }
    else if (g > secret)
    {
        Console.WriteLine("Загаданное число меньше");
    }
    else
    {
        Console.WriteLine("Загаданное число больше");
    }
}
if (iss == false)
{
    Console.WriteLine($"Вы проиграли, число было {secret}");
}

//Дополнительное задание ★★★
int n = 4728;
int sum = 0;
int c = 0;
while (n > 0)
{
    int last = n % 10;
    sum += last;
    c++;
    n = n / 10;
}
Console.WriteLine($"Сумма цифр: {sum}");
Console.WriteLine($"Количество цифр: {c}");