// Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// Функция ввода с консоли и преобразования в целое
// Возвращает целое, введенное пользователем
// Параметр строка подсказки
//int ReadInt(string message) // int - тип возвращаемого значения, ReadInt - название функции, message - параметр
//{
//    Console.Write($"{message} >");                      // Вызов функции печати в консоль
//    int value = Convert.ToInt32(Console.ReadLine());    // Ввод строки из консоли и преобразование в целое
//    return value;                                       // Возвращаемое значение
//}
//
//int number = ReadInt("Введите число");      // Вызов функции ввода числа
//int lastDigit = number % 10;                // Определение последней цифры числа
//System.Console.WriteLine($"Последняя цифра числа {number} равна {lastDigit}"); // Вывод результата



//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8 
//12-> 2 
//85 -> 8

//int MaxNumber(int number)
//{
//    int dec = number / 10;
//    int det = number % 10;
//    int result = dec;
//
//    if(det > result)
//    {
//        result = det;
//    }
//    return result;
//}
//
//int num = new Random().Next(10, 100);
//System.Console.WriteLine($"Max number of {num} is {MaxNumber(num)}");


//3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деление.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно


//int ReadInt(string message)
//{
//    System.Console.WriteLine($"{message} >");
//    int value = Convert.ToInt32(Console.ReadLine());
//    return value;
//}
//
//int num1 = ReadInt("Input 1st number");
//int num2 = ReadInt("Input 2nd number");
//int ostatok = num1 % num2;
//
//if(ostatok == 0)
//{
//    System.Console.WriteLine("Число 2 кратно числу 1");
//}
//else
//{
//    System.Console.WriteLine($"Число 2 не кратно числу 1, остаток от деления равен {ostatok}");
//}

//4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да

//int ReadInt(string message)
//{
//    System.Console.WriteLine($"{message} >");
//    int value = Convert.ToInt32(Console.ReadLine());
//    return value;
//}
//
//int num1 = ReadInt("Input 1st number");
//int num2 = ReadInt("Input 2nd number");
//int ostatok1 = num1 % num2;
//int ostatok2 = num2 % num1;
//
//if(ostatok1 == 0)
//{
//    System.Console.WriteLine("Число 2 кратно числу 1");
//}
//else if(ostatok2 == 0)
//{
//    System.Console.WriteLine("Число 1 кратно числу 2");
//}
//else
//{
//    System.Console.WriteLine($"Числа не кратны, остаток от деления числа 2 на число 1 равен {ostatok1}, остаток от деления числа 1 на число 2 равен {ostatok2}");
//}



//4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да

//int ReadInt(string message)
//{
//    System.Console.WriteLine($"{message} >");
//    int value = Convert.ToInt32(Console.ReadLine());
//    return value;
//}
//
//int num = ReadInt("Input a number");
//
//if(num % 7 == 0 && num % 23 == 0)
//{
//    System.Console.WriteLine($"Число {num} кратно 7 и 23");
//}
//else
//{
//    System.Console.WriteLine($"Число {num} НЕ кратно 7 и 23");
//}


//Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.
//7812 -> 8 
//1213-> 3 
//845 -> 8


// int MaxDigit(int number)
// {
//     int max = 0;

//     while (number > 0)
//     {
//         int ostatok = number % 10;
//         if (max < ostatok)
//         {
//             max = ostatok;
//         }
//         number /= 10;
//     }
//     return max;
// }

// int num = new Random().Next(10, 10000);
// System.Console.WriteLine($"Max digit of {num} is {MaxDigit(num)}");


