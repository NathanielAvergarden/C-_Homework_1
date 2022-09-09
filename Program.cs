// Задача №2
int a = 5;
int b = 7;
int max = a;
if(a > b) max = a;
if(a < b) max = b;
Console.WriteLine(max);

// Задача №4
int a = 2;
int b = 3;
int c = 7;
int max = a;
if(b > max) max = b;
if(c > max) max = c;
Console.WriteLine(max);

// Задача №6
int number;
number = int.Parse(Console.ReadLine());
int temp = number % 2;
bool result = temp == 0;
if(result)
{
    Console.WriteLine("число четное");
}
else
{
    Console.WriteLine("число нечетное");
}