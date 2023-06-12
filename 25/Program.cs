//  Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//   и возводит число A в натуральную степень B.
//  3, 5 -> 243 (3⁵)
//  2, 4 -> 16

int degree (int a, int b) {
    int result = a;
    for (int i = 1; i < b; i++) {
         result *= a;
}
return result;
}

Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите степень: ");
int b = int.Parse(Console.ReadLine());

int result = degree(a , b);
Console.WriteLine($"Число {a} в степени {b} равно {result}");