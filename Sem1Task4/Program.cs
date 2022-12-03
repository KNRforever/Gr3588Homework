// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


///Считываем числа с консоли
string? Lnum1 = Console.ReadLine(); 
string? Lnum2 = Console.ReadLine();
string? Lnum3 = Console.ReadLine();

//проверяем числа не пустые 
if(Lnum1!=null&&Lnum2!=null&&Lnum3!=null)
{
    //переводим ввёденное в численный формат
    int num1 = int.Parse(Lnum1);
    int num2 = int.Parse(Lnum2);
    int num3 = int.Parse(Lnum3);

    //сравниваем числа max = Math.Max(n1, Math.Max(n2, n3));
    int max = Math.Max(num1, Math.Max(num2, num3));
    
    //выводим на консоль максимальное
    Console.Write ($"максимальное число равно {max}");


}