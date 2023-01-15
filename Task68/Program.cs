// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine($"введите число натуральное положительное число M ");
string? LnumM = Console.ReadLine(); //считываем число M с консоли

Console.WriteLine($"введите ещё одно натуральное положительное число N");
string? LnumN = Console.ReadLine(); //считывем число N с консоли

if(LnumM!=null&&LnumN!=null) //проверяем M и N не пустые 

{
    //переводим M и N в численный формат
    int M = int.Parse(LnumM); 
    int N = int.Parse(LnumN);


		
		int AkkermanFunc(int M, int N)
		{
			if(M == 0)
			{
				return N + 1;
			}
			if(M > 0 && N == 0)
			{
				return AkkermanFunc(M - 1, 1);
			}
			return AkkermanFunc(M - 1, AkkermanFunc(M, N - 1));
		}
		
		Console.WriteLine($"A(M,N) = {AkkermanFunc(M,N)}");
	}



