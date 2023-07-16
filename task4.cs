Console.WriteLine("Введите номер задания:");
int N;
int A = 0;
int B = 0;
int len = 0;
string str = "";
bool CorrectInput = false;
N = int.Parse(Console.ReadLine());
switch (N)
{
    case 25:
        while (!CorrectInput)
        {
            Console.WriteLine("Введите число A:");
            str = Console.ReadLine();
            if ((CorrectInput = int.TryParse(str, out A)))
            {
                CorrectInput = true;
            }
            else
            {
                Console.WriteLine("некорректный ввод.");
            }
        }
        CorrectInput = false;
        while (!CorrectInput)
        {
            Console.WriteLine("Введите число B:");
            str = Console.ReadLine();
            if ((CorrectInput = int.TryParse(str, out B)))
            {
                CorrectInput = true;
            }
            else
            {
                Console.WriteLine("некорректный ввод.");
            }
        }
        Console.WriteLine(Math.Pow(A, B));
        break;
    case 29:
        int[] array1 = new int[8];
        Random rnd = new Random();
        str = "[";
        for (int i = 0; i < 7; i++)
        {
            array1[i] = rnd.Next(10, 1000);
            str = str + array1[i] + ", ";
        }
        array1[7] = rnd.Next(10, 1000);
        str = str + array1[7] + "]";        
        Console.WriteLine(str);
        break;
}