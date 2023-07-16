using System.Collections;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
// using static System.Math;

static string GetReversedString(string _str)
{
    string str_ = "";
    for (int i = 0; i < _str.Length; i++)
    {

        str_ = str_.Insert(i, _str[_str.Length - i - 1].ToString());
    }
    return str_;
}
var pa = new Dictionary<char, double>()
{
    ['x'] = 0,
    ['y'] = 0,
    ['z'] = 0
};
var pb = new Dictionary<char, double>()
{
    ['x'] = 0,
    ['y'] = 0,
    ['z'] = 0
};
Console.WriteLine("Введите номер задания:");
int N;
int Num;
int len = 0;
Num = 0;
string str = "";
bool CorrectInput = false;
N = int.Parse(Console.ReadLine());
switch (N)
{
    case 19:
        while (!CorrectInput)
        {
            Console.WriteLine("Введите пятизначное число:");
            str = Console.ReadLine();
            if ((str.Length == 5) & (CorrectInput = int.TryParse(str, out Num)))
            {
                CorrectInput = true;
            }
            else
            {
                Console.WriteLine("некорректный ввод.");
            }
        }
        string reversed_str = GetReversedString(str);
        if (reversed_str == str) { Console.WriteLine("Строка " + str + " - палиндром"); }
        else { Console.WriteLine("Строка " + str + " - НЕ палиндром"); }
        break;
    case 21:
        Console.WriteLine("Введите a.x:");
        pa['x'] = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите a.y:");
        pa['y'] = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите a.z:");
        pa['z'] = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите b.x:");
        pb['x'] = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите b.y:");
        pb['y'] = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите b.z:");
        pb['z'] = double.Parse(Console.ReadLine());

        Console.WriteLine("Расстояние между точками: " + Math.Sqrt(Math.Pow(pa['x'] - pb['x'], 2) + Math.Pow(pa['y'] - pb['y'], 2) + Math.Pow(pa['z'] - pb['z'], 2)));

        break;

    case 23:
        Console.WriteLine("Введите число от 1 до 20");
        str = Console.ReadLine();
        if ((CorrectInput = int.TryParse(str, out Num))&(Num>0)&(Num<21))
        {
            CorrectInput = true;
        }
        else
        {
            Console.WriteLine("некорректный ввод.");
        }
        str="";
        for (int i = 0;i<Num;i++){
            str = str + Math.Pow(i,3)+ ", ";
        }
        str = str + Math.Pow(Num,3);
        Console.WriteLine(str);
        break;
}
