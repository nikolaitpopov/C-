Console.WriteLine("Введите номер задания:");
int N;
int A = 0;
int B = 0;
int len = 0;
string str = "";
bool CorrectInput = false;
N = int.Parse(Console.ReadLine());
int m = 0;
int n = 0;

void Task47()
{
    while (!CorrectInput)
    {
        Console.WriteLine("Введите число m:");
        str = Console.ReadLine();
        if ((CorrectInput = int.TryParse(str, out m)))
        {
            CorrectInput = true;
        }
        else
        {
            Console.WriteLine("некорректный ввод.");
        }
    }
    CorrectInput = false;
    {
        Console.WriteLine("Введите число n:");
        str = Console.ReadLine();
        if ((CorrectInput = int.TryParse(str, out n)))
        {
            CorrectInput = true;
        }
        else
        {
            Console.WriteLine("некорректный ввод.");
        }
    }
    Random rnd = new Random();

    List<List<float>> array_mn = new List<List<float>>();

    for (int i = 0; i < m; i++)
    {
        List<float> array_n = new List<float>();
        for (int j = 0; j < n; j++)
        {
            array_n.Add(rnd.Next(-9999, 9999) / 100);
            Console.WriteLine(array_n.ElementAt(j));
        }
        array_mn.Add(array_n);
    }
}
void Task41()
{
    int c=0;
    float f = 0;
    while (!CorrectInput)
    {
        Console.WriteLine("Введите число m:");
        str = Console.ReadLine();
        if ((CorrectInput = int.TryParse(str, out m)))
        {
            CorrectInput = true;
        }
        else
        {
            Console.WriteLine("некорректный ввод.");
        }
    }
    for (int i = 0; i < m; i++)
    {
        CorrectInput = false;
        while (!CorrectInput)
        {
            Console.WriteLine("Введите " + i + "-е число:");
            str = Console.ReadLine();
            if ((CorrectInput = float.TryParse(str, out f)))
            {
                CorrectInput = true;
            }
            else
            {
                Console.WriteLine("некорректный ввод.");
            }
        }
    if (f>0) {c++;}
    }
    Console.WriteLine("Вами было накалупыцкано " + c + " положительных чисел. Так то.");   
}

void Task43(){

}

void Task50(){
    while (!CorrectInput)
    {
        Console.WriteLine("Введите число m:");
        str = Console.ReadLine();
        if ((CorrectInput = int.TryParse(str, out m)))
        {
            CorrectInput = true;
        }
        else
        {
            Console.WriteLine("некорректный ввод.");
        }
    }
    CorrectInput = false;
    {
        Console.WriteLine("Введите число n:");
        str = Console.ReadLine();
        if ((CorrectInput = int.TryParse(str, out n)))
        {
            CorrectInput = true;
        }
        else
        {
            Console.WriteLine("некорректный ввод.");
        }
    }
    Random rnd = new Random();

    List<List<float>> array_mn = new List<List<float>>();

    for (int i = 0; i < m; i++)
    {
        List<float> array_n = new List<float>();
        for (int j = 0; j < n; j++)
        {
            array_n.Add(rnd.Next(-9999, 9999) / 100);
            Console.WriteLine(array_n.ElementAt(j));
        }
        array_mn.Add(array_n);
    }
    CorrectInput = false;
     while (!CorrectInput)
    {
        Console.WriteLine("Введите номер строки:");
        str = Console.ReadLine();
        if ((CorrectInput = int.TryParse(str, out m)))
        {
            CorrectInput = true;
        }
        else
        {
            Console.WriteLine("некорректный ввод.");
        }
    }
    CorrectInput = false;
    {
        Console.WriteLine("Введите номер столбца:");
        str = Console.ReadLine();
        if ((CorrectInput = int.TryParse(str, out n)))
        {
            CorrectInput = true;
        }
        else
        {
            Console.WriteLine("некорректный ввод.");
        }
    } 
    if ((m>array_mn.Count)|(n>array_mn[1].Count)) {
        Console.WriteLine("Ах..Такого элемента в массиве нету...");
    }
    else {
        Console.WriteLine(array_mn[m][n]);
    }
}


void Task52(){
    while (!CorrectInput)
    {
        Console.WriteLine("Введите число m:");
        str = Console.ReadLine();
        if ((CorrectInput = int.TryParse(str, out m)))
        {
            CorrectInput = true;
        }
        else
        {
            Console.WriteLine("некорректный ввод.");
        }
    }
    CorrectInput = false;
    {
        Console.WriteLine("Введите число n:");
        str = Console.ReadLine();
        if ((CorrectInput = int.TryParse(str, out n)))
        {
            CorrectInput = true;
        }
        else
        {
            Console.WriteLine("некорректный ввод.");
        }
    }
    Random rnd = new Random();

    List<List<float>> array_mn = new List<List<float>>();

    for (int i = 0; i < m; i++)
    {
        List<float> array_n = new List<float>();
        for (int j = 0; j < n; j++)
        {
            array_n.Add(rnd.Next(0, 99));

        }
        array_mn.Add(array_n);
        Console.WriteLine("Среднее значение строки "+ i + " : "+ array_n.Average());
    }

}



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
    case 34:
        int[] array2 = new int[100];
        Random rnd2 = new Random();
        int counter = 0;
        for (int i = 0; i < 100; i++)
        {
            array2[i] = rnd2.Next(100, 999);
            if (array2[i] % 2 == 0)
            { counter++; }
        }
        Console.WriteLine(counter);
        break;
    case 36:
        int[] array3 = new int[100];
        Random rnd3 = new Random();
        int counter1 = 0;
        for (int i = 0; i < 100; i++)
        {
            array3[i] = rnd3.Next(100, 999);
            if (i % 2 == 1)
            { counter1 += array3[i]; }
        }
        Console.WriteLine(counter1);
        break;
    case 38:
        float[] array4 = new float[100];

        Random rnd4 = new Random();
        array4[0] = rnd4.Next(100, 9999) / 100;
        float min = array4[0];
        float max = array4[0];
        for (int i = 1; i < 100; i++)
        {
            array4[i] = rnd4.Next(100, 9999) / 100;
            if (min > array4[i])
            { min = array4[i]; }
            if (max < array4[i])
            { max = array4[i]; }
        }
        Console.WriteLine(max - min);
        break;
    case 47:
        Task47();
    break;
    case 41:
        Task41();
    break;
    case 43:
        Task43();
    break;
    case 50:
Task50();

    break;

    case 52:
Task52();
    break;
}