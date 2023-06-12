//  Задача 27: Напишите программу, которая принимает на вход число и 
//выдаёт сумму цифр в числе.
//  452 -> 11
//  82 -> 10
//  9012 -> 12

int getSum(int n) {
    int sum = 0;
for (int i = 0; i < n; i++) {
    sum += n % 10;
    n /=10; 
}
    return sum;
}

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

int result = getSum(n);
Console.WriteLine($"Сумма цифр в числе {n}  равна {result}");





