int programm, number;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("-----------------------------------------------------------------------------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода: ");
    Console.WriteLine("1. Напишите программу, которая на вход принимает пятизначное число и проверяет, является ли оно палиндромом.");
    Console.WriteLine("2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
    Console.WriteLine("3. Напишите программу, которая принимает на вход число(N) и выдает таблицу чисел от 1 до N.");
    programm = Convert.ToInt32(Console.ReadLine());
    
    switch (programm)
    {
        case 1:
            // Задача 19. Напишите программу, котора на вход принимает пятизначное число и проверяет, является ои оно палиндромом.
            /*  14212-> нет
                12821-> да
                23432-> да  */                      

            Console.WriteLine("Введите пятизначное число: ");
            string number1 = Console.ReadLine();
            int len = number1.Length;

            if (len == 5)
            {
                if (number1[0] == number1[4] && number1[1] == number1[3])
                {
                    Console.WriteLine($"{number1} - Является палендромом");
                }
            
                else
                {
                    Console.WriteLine($"{number1} - НЕ является палендромом");
                }
            }
            
            else
            {
                Console.WriteLine($"ОШИБКА: {number1} - неверный ввод");
            }

            break;

        case 2:
            // Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
            /*  А(3,6,8); В(2,1,-7), -> 15.84
                А(7,-5,0); В(1,-1,9), -> 11,53 */

            int x1 = ReadInt("Введите координату X первой точки: ");
            int y1 = ReadInt("Введите координату Y первой точки: ");
            int z1 = ReadInt("Введите координату Z первой точки: ");
            int x2 = ReadInt("Введите координату X второй точки: ");
            int y2 = ReadInt("Введите координату Y второй точки: ");
            int z2 = ReadInt("Введите координату Z второй точки: ");

            int A = x2 - x1;
            int B = y2 - y1;
            int C = z1 - z2;

            double length = Math.Sqrt(A * A + B * B + C * C);
            Console.WriteLine($"Длинна отрезка {length}");

            int ReadInt(string message)
            {
                Console.Write(message);
                return Convert.ToInt32(Console.ReadLine());
            }

            break;


        case 3:
            // Задача 23. Напишите программу, которая принимает на вход число(N) и выдает таблицу чисел от 1 до N.
            /*  3-> 1, 8, 27
                5-> 1, 8, 27, 125 */
            
            Console.WriteLine(NumberToN(ReadInt3(" ")));

            int ReadInt3(string argument)
            {
                Console.Write($"Введите число: {argument}");
                int number;
    
                while(!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Это не число");
                }

                return number;
            }

            int NumberToN(int number)
            {
                for (int a = 0; a < number; a++)
                {   
                    Console.Write($"{a}");                  
                }        

                return number;
            }
            


            break;
    }
}