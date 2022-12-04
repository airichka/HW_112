
int a;
int b;

Console.Write($"Введите первое число: ");
int.TryParse(Console.ReadLine()!, out a); 
Console.Write($"Введите второе число: ");
int.TryParse(Console.ReadLine()!, out b); 

if (a > b)
Console.Write("{0} наибольшее число", a);
else 
Console.Write("{0} наибольшее число", b);

Console.ReadLine();