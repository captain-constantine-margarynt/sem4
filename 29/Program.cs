//  Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//  и выводит их на экран.
//  1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//  6, 1, 33 -> [6, 1, 33]

void arrInit (int n){
int [] arr = new int [n];
for (int i = 0; i < arr.Length; i++) {
    arr[i] = new Random().Next(0, 100);
    Console.Write($"{arr[i]},  ");
}
Console.WriteLine($"{arr[arr.Length-1]}");
}

Console.Clear();
Console.Write("Задайте размер массива: ");
int n = int.Parse(Console.ReadLine());
arrInit(n);