int a;
int b;

Console.Write($"Введите первое число: ");
int.TryParse(Console.ReadLine()!, out a); 
Console.Write($"Введите второе число: ");
int.TryParse(Console.ReadLine()!, out b); 

int index = 0;

while (index <= 5)
{Console.Write($"{index} ");
index ++;}

Console.Write($"\n");
for (int index2 = 0; index < 5; index ++ )

{Console.Write($"{index2} ");
}