// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine($"введите число натуральное положительное число ");
string? LnumM = Console.ReadLine(); //считываем число M с консоли

Console.WriteLine($"введите ещё одно натуральное положительное число большее чем предидущее");
string? LnumN = Console.ReadLine(); //считывем число N с консоли

if(LnumM!=null&&LnumN!=null) //проверяем M и N не пустые 



{
    //переводим M и N в численный формат
    int M = int.Parse(LnumM); 
    int N = int.Parse(LnumN);

    int Summ = 0;
    while (N >= M) 
    {    Summ = Summ+N;
        N= N-1;
         }

Console.WriteLine($"сумма элементов равна {Summ}");} 




