using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Виберіть програму для виконання (1-6):");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Task1();
                break;
            case 2:
                Task2();
                break;
            case 3:
                Task3();
                break;
            case 4:
                Task4();
                break;
            case 5:
                Task5();
                break;
            case 6:
                Task6();
                break;
            default:
                Console.WriteLine("Невірний вибір програми.");
                break;
        }

        Console.ReadLine(); // Щоб консольне вікно не закривалося відразу
    }

    static void Task1()
    {
        Console.Write("Введіть внутрішній радіус (r1): ");
        double r1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть зовнішній радіус (r2): ");
        double r2 = Convert.ToDouble(Console.ReadLine());

        if (r1 < 0 || r2 < 0 || r1 >= r2)
        {
            Console.WriteLine("Некоректні вхідні дані. Внутрішній радіус повинен бути не менше 0, зовнішній - більше внутрішнього.");
            return;
        }

        double area = CalculateRingArea(r1, r2);

        Console.WriteLine($"Площа кільця з внутрішнім радіусом {r1} і зовнішнім радіусом {r2} дорівнює {area}");
    }

    static double CalculateRingArea(double innerRadius, double outerRadius)
    {
        double area = Math.PI * (outerRadius * outerRadius - innerRadius * innerRadius);
        return area;
    }

    static void Task2()
    {
        Console.WriteLine("Введіть тризначне число:");

        string input = Console.ReadLine();

        if (input.Length != 3)
        {
            Console.WriteLine("Введіть тризначне число!");
            return;
        }

        char[] digits = input.ToCharArray();

        if (digits[0] == digits[1] || digits[1] == digits[2] || digits[0] == digits[2])
        {
            Console.WriteLine("Серед цифр є однакові.");
        }
        else
        {
            Console.WriteLine("Усі цифри різні.");
        }
    }

    static void Task3()
    {
        Console.WriteLine("Task3 !");
        Console.Write("x = ");
        float x = float.Parse(Console.ReadLine());

        Console.Write("y = ");
        float y = float.Parse(Console.ReadLine());

        if (x * x + y * y < 144 && x > y)
            Console.WriteLine("Yes");
        else if (x * x + y * y > 144 && x < y)
            Console.WriteLine("No");
        else Console.WriteLine("On");
    }

    static void Task4()
    {
        Console.WriteLine("Введіть стать (м - чоловік, ж - жінка):");
        char gender = Console.ReadKey().KeyChar;

        Console.WriteLine(); // Перехід на новий рядок для зручності

        if (gender == 'м')
        {
            Console.WriteLine("Чоловічі імена:");
            DisplayMaleNames();
        }
        else if (gender == 'ж')
        {
            Console.WriteLine("Жіночі імена:");
            DisplayFemaleNames();
        }
        else
        {
            Console.WriteLine("Введена невірна стать.");
        }
    }

    static void DisplayMaleNames()
    {
        string[] maleNames = { "Іван", "Петро", "Олександр", "Михайло", "Віталій" };

        foreach (string name in maleNames)
        {
            Console.WriteLine(name);
        }
    }

    static void DisplayFemaleNames()
    {
        string[] femaleNames = { "Марія", "Ольга", "Тетяна", "Юлія", "Анастасія" };

        foreach (string name in femaleNames)
        {
            Console.WriteLine(name);
        }
    }

    static void Task5()
    {
        Console.Write("Введіть перше число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = SquareOfQuotient(num1, num2);
        Console.WriteLine($"Квадрат частки {num1} і {num2} дорівнює: {result}");
    }

    static double SquareOfQuotient(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Помилка: Друге число не повинно бути рівним нулю.");
            Environment.Exit(1);
        }

        double quotient = a / b;
        double square = Math.Pow(quotient, 2);
        return square;
    }

    static void Task6()
    {
        Console.WriteLine("Введіть значення a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть значення b:");
        double b = Convert.ToDouble(Console.ReadLine());

        double result = CalculateExpression(a, b);

        Console.WriteLine($"Результат виразу: {result}");
    }

    static double CalculateExpression(double a, double b)
    {
        double expressionResult = a + (a + b - 1) / (Math.Pow(a, 2) + 1) - a * b;
        return expressionResult;
    }
}
