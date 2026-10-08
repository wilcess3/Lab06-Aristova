// for (int i = 1; i <= 5; i++)
// {
//     Console.WriteLine(i);
// }

// int n = 1;
// while (n <= 5)
// {
//     Console.WriteLine(n);
//     n++;
// }

// int answer;
// do
// {
//     Console.Write("Введите число больше 0: ");
//     answer = Convert.ToInt32(Console.ReadLine());
// }
// while (answer <= 0);

// for (int i = 1; i <= 10; i++)
// {
//     if (i == 3) continue;
//     if (i == 7) break;
//     Console.WriteLine(i);
// }
//Задание 1.1
// for (int i = 10; i > 0; i--)
// {
//     Console.WriteLine(i);
// }
// //Задание 1.2
// for (int i = 2; i <= 50; i += 2)
// {
//     Console.WriteLine(i);
// }
// //Пример 2
// int sum = 0;
// for (int i = 1; i <= 10; i++)
// {
//     sum += i;
// }
// Console.WriteLine($"Сумма: {sum}");

// int count = 0;
// for (int i = 1; i <= 20; i++)
// {
//     if (i % 5 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Чисел, кратных 5: {count}");


// Задание 2
// int count3 = 0;
// int count7 = 0;
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0) count3+=i;
//     if (i % 7 == 0) count7++;
// }
// Console.WriteLine($"Сумма чисел кратных 3: {count3}");
// Console.WriteLine($"Количество чисел кратных 7: {count7}");



//пример 3
// int number = Convert.ToInt32(Console.ReadLine());
// int total = 0;

// while (number != 0)
// {
//     total += number;
//     number = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"Сумма: {total}");

//Задание 3
// int count1 = 0;
// int count2 = 0;
// int number = Convert.ToInt32(Console.ReadLine());
// int total = 0;
// while (number >= 1)
// {
//     total += number;
//     if (number > 0) count1++;
//     else count2++;
//     number = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"Введено положительных чисел: {count1}");
// Console.WriteLine($"Введено отрицательных чисел чисел: {count2}");


//Пример 4
// string password;
// do
// {
//     Console.Write("Введите пароль: ");
//     password = Console.ReadLine();
// }
// while (password != "qwerty");
// Console.WriteLine("Доступ разрешен");


//Задание 4
// string password;
// bool proVerka = false;
// for (int i = 1; i <= 3; i++)
// {
//      Console.Write("Введите пароль: ");
//     password = Console.ReadLine();
//     if (password == "qwerty")
//     {
//         Console.WriteLine("Доступ разрешен");
//         proVerka = true;
//         break;
//     }
// }
// if (proVerka == false)
// {
//     Console.WriteLine("Доступ заблокирован");
// }


//Задание 5
Console.Write("Введите число (1 - 9): ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n} x {i} = {n * i}");
}


//Задание 6
// for (int i = 1; i <= 30; i++)
// {
//     if (i % 3 == 0) continue;
//     if (i % 10 == 0 && i > 20) break;
//     Console.WriteLine(i);
// }


//Угадай число
// int secret = 26;
// int popitki = 5;
// bool a = false;
// for (int i = 1; i <= popitki; i++)
// {
//     Console.Write($"Попытка:  {i}");
//     int chislo = Convert.ToInt32(Console.ReadLine());

//     if (chislo == secret)
//     {
//         Console.WriteLine($"Победа! Попыток : {i}");
//         a = true;
//         break;
//     }
//     else if (chislo > secret)
//     {
//         Console.WriteLine("Меньше!!!");
//     }
//     else
//     {
//         Console.WriteLine("Больше!!!");
//     }
// }
// if (a == false)
// {
//     Console.WriteLine($"Вы проиграли, число было {secret}");
// }


//Доп задание 
Console.WriteLine("Введите целое полож число: ");
int num = Convert.ToInt32(Console.ReadLine());

int suumm = 0;
int countt = 0;
while (num > 0)
{
    suumm += num % 10;
    num /= 10;
    countt++;
}
Console.WriteLine($"Сумма чисел: {suumm} ");
Console.WriteLine($"Количество цифр: {countt} ");


