// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите номер задания:");
int N = int.Parse(Console.ReadLine());

if (N==2)
{
Console.WriteLine("Введите a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b:");
int b = int.Parse(Console.ReadLine());
if (a>b){Console.WriteLine("Max: "+ a);}
else {Console.WriteLine("Max: '"+b);}
}


if (N==4)
{
Console.WriteLine("Введите a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите c:");
int c = int.Parse(Console.ReadLine());
if (a>b)
{
    max=a;
    }
else 
{
    max=b;
    }
if (max>c)
{
    Console.WriteLine("Max: "+ max);
    }
else 
{
    Console.WriteLine("Max: '"+c);
    }
}