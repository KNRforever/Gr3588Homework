// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
string? Lnum1 = Console.ReadLine(); //считываем число а с консоли
string? Lnum2 = Console.ReadLine(); //считывем число b с консоли

if(Lnum1!=null&&Lnum2!=null) //проверяем а,b не пустые 
{
    //переводим a, b в численный формат
    int num1 = int.Parse(Lnum1); 
    int num2 = int.Parse(Lnum2);
    
    //переходим к условию и выводу на консоль большее число
    if(num1>num2)
    {
        Console.WriteLine ($"большее число = {num1}");
        Console.WriteLine ($"меньшее число = {num2}");
          }

    else 
    { Console.WriteLine ($"большее число = {num2}");
    Console.WriteLine ($"меньшее число = {num1}");
    
    }
   

}

