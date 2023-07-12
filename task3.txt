using System.Collections;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
// using static System.Math;

static int GetSecondDigit(int ABC)
{
    Double Remainder1 = ABC%100;
    return Convert.ToInt16(Math.Truncate(Remainder1/10));
}

Console.WriteLine("Введите номер задания:");
int N;
int Num;
int len=0;
Num=0;
string str="";
bool CorrectInput = false;
N = int.Parse(Console.ReadLine());
switch(N)
{
case 10:
while (!CorrectInput)
    {
    Console.WriteLine("Введите трехзначное число:");
    Num = int.Parse(Console.ReadLine());
    if ((Num<1000)&(Num>99)) {
        CorrectInput = true;
        }
    else
        {
         Console.WriteLine("некорректный ввод.");   
        }
    }
Console.WriteLine(GetSecondDigit(Num));
break;
case 13:
while (!CorrectInput)
    {
    Console.WriteLine("Введите число <=10 цифр:");    
    str = Console.ReadLine();
    len = str.Length;
    CorrectInput = int.TryParse(str, out N)&(len<11);
    if (!CorrectInput) 
    {Console.WriteLine("некорректный ввод.");}
    }
if (len>2)
    {
    Console.WriteLine(str[2]);
    }
else
    {
     Console.WriteLine("Третьей цифры нету-ти!");
    }   
    
break;
case 15:
while (!CorrectInput)
    {
    Console.WriteLine("Введите номер дня недели");    
    str = Console.ReadLine();
    CorrectInput = int.TryParse(str, out N)&(N<8)&(N>0);
    if (!CorrectInput) 
    {Console.WriteLine("некорректный ввод.");}
    }
if ((N>0)&(N<6))
    {
    Console.WriteLine("Будний день!");
    }
    else
    {{Console.WriteLine("Выходной день!");}}
    
break;
}
