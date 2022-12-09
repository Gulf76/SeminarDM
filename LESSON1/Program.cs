/*Статические,динамические типизация данных.С# относится кязыку  с статической типизацией данных,в отличии 
от python,java script (пример в С# переменная вводится int i = 0; т.е мы сразу выделяем тип данных(int) ,выделяем 
ячейку памяти (int относится к определенной группе типа данных,а значит отдельнная часть памяти) 
внутри оперативной памяти ).А в динамических(i=0) память сначало обращается к типу данных и только потом будет 
ссылаться на определенную ячейку памяти т.е они хороши например для разработки веб приложений,аналитика,тестирование.
Статические языки компелируются(динамические-инерпритируются).Мы не можем напрямую создать  
программу в C# и запустить,для этого нужна программа например в C# это dotnet,т.е с помощью неё мы запускаем 
программный код который мы написали и для того чтобы она могла компелироваться(тестироваться,запускаться),мы должны 
создать dotnet new console.Это файлы которые позволяют нашей программе вообще запускаться,и файл с которым мы будем работать непосредственно
это Programm.cs.Но сначало надо войти в нее с помощью команды cd.. и dotnet new console
 */ 

 /*Массивы это колекция данных ,в которых  хранится элементы данных только одного типа*/

 //  TRUE   FALSE  1 или 0

// Console.Clear();
// Console.Write("Введите число " );
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine( n > 5 );
// Console.Write(Convert.ToInt32( n > 5 ));

//^ (*)- конъюнкция     v (+) -дизъюнкция    


/*Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
на само себя).
*/

// //Например:
// //4 -> 16 
// //-3 -> 9 
// //-7 -> 49


// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
// Console.WriteLine(n * n);

/*
Задача 1 
Напишите программу, которая на вход
принимает два числа и проверяет, является ли
первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет
*/

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine()); // ввод чисел
// if (m * m == n)
//     Console.Write("yes");
// else
//     Console.Write("no");


// 
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine()); // ввод чисел
// if (m * m == n)
//     Console.Write("yes");
// else
//     Console.Write("no");
// 


/*
Задача 3 
Напишите программу, которая будет выдавать
название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/


// Console.Clear();
// Console.Write("Введите день недели: ");
// int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
// while (n < 1 || n > 7)
// {
//     Console.Write("Вы ошиблись!\nВведите день недели: ");
//     n = Convert.ToInt32(Console.ReadLine());    
// }
// if (n == 1)
//     Console.WriteLine("Понедельник");
// else if (n == 2)
//     Console.WriteLine("Вторник");
// else if (n == 3)
//     Console.WriteLine("Среда");
// else if (n == 4)
//     Console.WriteLine("Четверг");
// else if (n == 5)
//     Console.WriteLine("Пятница");
// else if (n == 6)
//     Console.WriteLine("Суббота");
// else
//     Console.WriteLine("Воскресенье");

/*
Задача 5 
Напишите программу, которая на вход
принимает одно число (N), а на выходе
показывает все целые числа в промежутке от -
N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
*/
  // Console.Clear();
  // Console.Write("n: ");
  // int n = Convert.ToInt32(Console.ReadLine());
  // Console.Write("m: ");
  // int m = Convert.ToInt32(Console.ReadLine());
  //   Console.Write("m: ");
  // int l = Convert.ToInt32(Console.ReadLine());
  //  if (m < n && n >l)
  //     Console.Write($"max={n}");
  //   if (n<= m && m  >l)
  //     Console.Write($"max={m}");
  //  if  (n <= l && l  > m) 
  //      Console.Write($"max={l}" );

   //int i = n%10 ;
  //   while ( i <= n)
  //  {    i++;
       //Console.Write($"{}  " );
  //  }


 //task 5
//  Console.Clear();
//  Console.Write("Введите число: ");
//  int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
//  int i = n * (-1);
//  while (i <= n)
//  {
//     Console.Write ( i+" " );
     //Console.Write($"{i} ");
//      i = i + 1; // i++;
//  }
// task 5
//  Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
// for (int i = (-1) * n; i <= n; i++)
//     Console.Write($"{i} ");

// // task 5
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
// for (int i = (-1) * n; i <= n; i++)
//     Console.Write(i + "  ");

    //LESSON 2 


//     // task 7
 //Console.Clear();
 //Console.Write("Введите число: ");
 // Для того, чтобы найти последнюю цифру любого числа, необходимо найти остаток при делении на 10
 //int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
 //Console.Write(n % 2);

//task
// int n = new Random().Next(10, 100);
// Console.WriteLine($"Случайное число: {n}");
// int n1 = n / 10; // кол-во десятков
// int n2 = n % 10; // кол-во единиц(последняя цифра числа)
// if (n1 > n2)
//     Console.Write(n1);
// else
//     Console.Write(n2);
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// task 11
// Console.Clear();

// int n = new Random().Next(100, 1000); // [100, 999]
// Console.WriteLine($"Случайное число: {n}");
// int n1 = n / 100; // кол-во сотен
// int n3 = n % 10; // кол-во единиц(последняя цифра числа)
// Console.Write(n1 * 10 + n3);


//task12
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//  

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// int n = new Random().Next(100, 1000); // [100, 999]
// Console.WriteLine($"Случайное число: {n}");
// int n1 = n / 100; // кол-во сотен
// int n3 = n % 10; // кол-во единиц(последняя цифра числа)
// Console.Write(n1 * 10 + n3);


// task 12

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

//  Console.Clear();

// Console.Write("Введите 1-ое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// //if (n % m == 0)
//     //Console.Write("yes");
//      //if (n % 2 == 0)
//      //int n =5;
//      Console.Write(4 % 2);



//else
   // Console.Write($"не кратно, остаток {n % m}");
  

  //https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=3&id_topic=35&id_problem=223

//task 14
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да
// task 14
// Console.Clear();

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if ((n % 7) + (n % 23) == 0) // (n % 7) && (n % 23)
//     Console.Write("yes");
// else
//     Console.Write("no");


// task 16
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Console.Clear();

// Console.Write("Введите 1-ое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// if (n * n == m || m * m == n)
//     Console.Write("yes");
// else
//     Console.Write("no");


// LESSON 3


/*ЗАДАЧА 17
Напишите программу, которая принимает на
вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
0 и выдаёт номер четверти плоскости, в которой
находится эта точка.
*/

// Console.Clear();
// Console.Write("Введите 1-ое число:  ");
// int x= Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число:  ");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x > 0 && y > 0 )
//  Console.Write("I");
//  else if (x > 0 && y < 0 )
//  Console.Write("IV");
//   else if (x < 0 && y < 0 )
//  Console.Write("III");
//   else 
//  Console.Write("II");
 


// С ДРОБНЫМИ ЧИСЛАМИ 

// task 17
// Console.Clear();
// Console.Write("Ведите координату X: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Ведите координату Y: ");
// double y = Convert.ToDouble(Console.ReadLine());

// if (x > 0 && y > 0)
//     Console.WriteLine("I");
// else if (x < 0 && y > 0)
//     Console.WriteLine("II");
// else if (x < 0 && y < 0)
//     Console.WriteLine("III");
// else
//     Console.WriteLine("IV");


/*     
Задача 18: 
Напишите программу, которая по
заданному номеру четверти, показывает
диапазон возможных координат точек в этой
четверти (x и y).
*/

// Console.Clear();
// Console.Write("Ведите номер четверти: ");
// int n= Convert.ToInt32(Console.ReadLine());

// if ( n == 1)
// Console.Write("x > 0 and y > 0");

// else if ( n == 2)
// Console.Write("x > 0 and y < 0");

// else if ( n == 3)
// Console.Write("x < 0 and y < 0");
 
// else  
// Console.Write("x < 0 and y > 0"); 


// Task21
/*
Задача 21: Напишите программу,
которая принимает на вход координаты
двух точек и находит расстояние между
ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

// Console.Clear();
// Console.Write("Ведите координату X1: "); 
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Ведите координату Y1: "); 
// double y1 = Convert.ToDouble(Console.ReadLine()); 
// Console.Write("Ведите координату X2: "); 
// double x2 = Convert.ToDouble(Console.ReadLine()); 
// Console.Write("Ведите координату Y2: "); 
// double y2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));



// Task22

/*
Задача 22: Напишите программу,
которая принимает на вход число (N) и
выдаёт таблицу квадратов чисел от 1 до
N.
5 -> 1, 4, 9, 16, 25
2 -> 1,4
*/

// Console.Clear();
// Console.Write("Ведите число: ");
// int n= Convert.ToInt32(Console.ReadLine());

// for ( i = 1; i <= n; i++)
// Console.Write($"{i*i}  " );
// task 19

// Console.Clear();
// Console.Write("Введите пятизначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// while (n < 10000 || n > 99999)
// {
//     Console.Write("Вы ошиблись!\nВведите пятизначное число: ");
//     n = Convert.ToInt32(Console.ReadLine());
// }
// int n1 = n / 10000;
// int n2 = (n / 1000) % 10;
// int n4 = (n % 100) / 10;
// int n5 = n % 10;

// if (n1 == n5 && n2 == n4)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");
 
 // task 19

// Console.Clear();
// Console.Write("Введите пятизначное число: ");
// string? n = Console.ReadLine();
// if (n[0] == n[4] && n[1] == n[3])
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");


// task 19

// Console.Clear();
// Console.Write("Введите пятизначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int result = n;
// int newNumber = 0, i = Convert.ToString(n).Length - 1;
// while (i >= 0)
// {
//     newNumber = newNumber + (n % 10 * Convert.ToInt32(Math.Pow(10, i)));
//     n = n / 10;
//     i--;
// }
// Console.WriteLine(newNumber == result);
//   ХОРОШИЙ КОД

//   Console.Clear();
// Console.Write("Введите кол-во элементов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write("Введите элемент массива: ");
//     int x = Convert.ToInt32(Console.ReadLine());
//     array[i] = x;
// }
// Console.WriteLine($"[{string.Join(", ", array)}]");
   

   //               LESSON  4

/*ЗАДАЧА ИЗ ДОМАШНЕЙ РАБОТЫ*/

// Console.Clear();
// Console.Write("Введите кол-во кустов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arrayFirst = new int[n];
// int resultSumma = 0;

// for (int i = 0; i < arrayFirst.Length; i++)
//     arrayFirst[i] = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i < arrayFirst.Length - 1; i++)
// {
//     if (arrayFirst[i - 1] + arrayFirst[i] + arrayFirst[i + 1] > resultSumma)
//         resultSumma = arrayFirst[i - 1] + arrayFirst[i] + arrayFirst[i + 1];
// }
// if (arrayFirst[0] + arrayFirst[1] + arrayFirst[n - 1] > resultSumma)
//     resultSumma = arrayFirst[0] + arrayFirst[1] + arrayFirst[n - 1];
    
// if (arrayFirst[0] + arrayFirst[n - 1] + arrayFirst[n - 2] > resultSumma)
//     resultSumma = arrayFirst[0] + arrayFirst[n - 1] + arrayFirst[n - 2];

// Console.WriteLine(resultSumma);





/*       
      ЗАДАЧА 24     
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/
// Console.Clear();
// Console.Write("Введите число: ");
// double n = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Результат: {(n + 1) / 2 * n}");


/*      
       ЗАДАЧА 26
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

// Console.Write("Введите число: ");
//  int n = Convert.ToInt32(Console.ReadLine());
     
//     void Array (int [] array) ;
//      for ( int i = 0;i < array.Length; i++)
//      int k = 0 ;
//      int l = k+array.Length ;
//           Console.Write(l);  // НЕ ЗНАЮ ОТ КУДА ЭТО ВЗЯЛ


//  Console.Clear();
//  Console.Write("Введите число: ");
//  int n = Convert.ToInt32(Console.ReadLine());
//  int i  = 1;
//      while ( n /10 != 0)
//             {n /=10;
//                 i++;}
//     Console.Write(i);

//                                  ЗАДАЧА 28      
// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
  

//   Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), result = 1;
// for (int i = 1; i <= n; i++)
//     result *= i; // result = result * i
// Console.WriteLine($"Результат: {result}");   

//                               ЗАДАЧА 30

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном 
// порядке.
// [1,0,1,1,0,1,0,0]

// Console.Clear();
// int[] array = new int[8];
// for (int i = 0; i < 8; i++)
//     array[i] = new Random().Next(0, 2);
// Console.WriteLine($"Результат: [{string.Join(", ", array)}]");

      //    ДОМАШНЯЯ РАБОТА LESSON 4

//От Денис Макарцев всем 10:22 AM
// task dop

// Console.Clear();
// Console.Write("Введите кол-во элементов массивва: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// int[] arrayHelp = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"[{string.Join(", ", array)}]");
// int k = Convert.ToInt32(Console.ReadLine());
// k = k % n;
// if (k > 0)
// {
//     for (int i = 0; i < k; i++)
//         arrayHelp[i] = array[array.Length - k + i];
//     for (int i = 0; i < array.Length - k; i++)
//         arrayHelp[k + i] = array[i];
    
//     Console.WriteLine($"[{string.Join(", ", arrayHelp)}]");
// }
// else
// {
//     k = (-1) * k;
//     for (int i = 0; i < k; i++)
//         arrayHelp[array.Length - k + i] = array[i];
//     for (int i = 0; i < array.Length - k; i++)
//         arrayHelp[i] = array[k + i];
//     Console.WriteLine($"[{string.Join(", ", arrayHelp)}]");
// }



/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
НЕ ИСПОЛЬЗОВАТЬ MATH.POW
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/



// Console.Clear();
// Console.Write("Введите число a =  ");
// int a = Convert.ToInt32(Console.ReadLine()) ; 
// Console.Write("Введите число b =  ");
// int b = Convert.ToInt32(Console.ReadLine()) ; 
// int c = a;
//  for( int i = 1; i < b; i++ )
//      {
//         c = c * a;
//      }
// Console.Write($"Число с = {c}");

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12


// ПЕРВЫЙ ВАРИАНТ

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), result = 0;
// while (n > 0)
// {
//     int x = n % 10;
//     result = result + x;
//     n = n / 10;
// }
// Console.WriteLine(result);

// ВТОРОЙ ВАРИАНТ    ЧЕРЕЗ STRING


Console.Clear();
Console.Write("Введите число: ");
string? n = Console.ReadLine();
int result = 0;
for (int i = 0; i < n.Length; i++)
    result = result + int.Parse(n[i].ToString());

Console.WriteLine(result);

ТРЕТИЙ ВАРИАНТ 

*/
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int p = 0;
// int sum = 0;
    
// while ( n / 10 != 0)
// {
//      p = n % 10;
//      n /=10; 
//      sum = sum + p;
// }
//    if ( n / 10 == 0)
// { 
//      p = n % 10 ;
//      sum = sum + p;
// }

// Console.WriteLine($"{sum} ");

     




/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов, предоставить возможность пользователю 
ввести числа и вывести их на экран.

1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]    
*/   


// Console.Write("Введите число злементов в массиве  ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] array = new int  [n] ;

// for ( int i = 0; i < array.Length; i++)
//      {
//      Console.Write("Введите число  ");
//      int x = Convert.ToInt32(Console.ReadLine());
//      array[i] = x ;
//    
// Console.WriteLine($"[{string.Join(", ", array)}]"); 
  


// Console.Clear();
// int [] array = new int [8];
//  for ( int i = 0; i < 8 ; i++ )
//    {
//      array [i] = new Random().Next(0,35);
//    }
// Console.WriteLine($"[{string.Join(",", array)}]");
 

 //СОРТИРОВКА ЧИСЕЛ

//  int [] arr = {2,6,4,9,15,3,45,17};
//    void PrintArray ( int [] array)
// {
//       for ( int i = 0; i < array.Length; i++ )
//           {
//             Console.Write($"{array[i] } " );
//           }
//        Console.WriteLine();   
// }
//     PrintArray(arr);

//     void SelectionSort ( int [] array)
// {  
//     for ( int i = 0; i < array.Length; i++ )
//         {
//           int minPosition = i;
//            for ( int j =i + 1; j < array.Length; j++ )
//                {
//                 if ( array[j] < array [minPosition]) minPosition = j ;
//                }
//                int temp = array [i];
//                array [i] = array [minPosition];
//                array [minPosition] = temp;
//          }
// }
//    SelectionSort(arr);
//     PrintArray(arr);


/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
// Console.Clear();
// int sum = 0;
// int [] array = new int [8];
//  for ( int i = 0; i < 8 ; i++ )
//    {
//      array [i] = new Random().Next(99,1000);
//       if ( array[i] % 2 == 0)
//         sum = sum + 1 ;
//    }
// Console.WriteLine($"[{string.Join(",", array)}]");
// Console.WriteLine($"СУММА ЧЕТНЫХ ЧИСЕЛ = {sum}  ");


/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на 
нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

// Console.Clear();
// int sum = 0;
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [8];
//  for ( int i = 0; i < 8 ; i++ )
//    {
//      array [i] = new Random().Next(99,1000);
//      if ( i % 2 == 1)
//      {
//             sum = sum + array[i];
//      }
//    }
//    Console.WriteLine($"[{string.Join(",", array)}]");
//    Console.WriteLine($"СУММА НЕЧЕТНЫХ ЭЛЕМЕНТОВ = {sum}  ");


/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/


   // LESSON 5 0512202

 /*  
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма 
отрицательных равна -20.
*/



// task 31

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10);
// }


// void ReleaseArray(int[] array)
// {
//     int sumPositive = 0, sumNegative = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//             sumPositive += array[i];
//         else
//             sumNegative += array[i];
//     }
//     Console.WriteLine($"Сумма положительных чисел в массиве {sumPositive}");
//     Console.WriteLine($"Сумма отрицательных чисел в массиве {sumNegative}");
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// ReleaseArray(array);
   





  /*
   Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие 
   отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/


// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10);
// }


// void ReleaseArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] *= (-1);
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
// ReleaseArray(array);
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");


/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10);
// }


// string ReleaseArray(int[] array, int k)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == k)
//             return "yes";
//     }
//     return "no";
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
// Console.Write("Введите число, которое Вы хотите найти в массиве: ");
// int k = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ReleaseArray(array, k));

/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения 
которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
  // task 35

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100, 101);
// }


// int ReleaseArray(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] <= 99)
//             count++;
//     }
//     return count;
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// // int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[123];
// InputArray(array);
// Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Результат: {ReleaseArray(array)}");

// task 37
 /*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/ 

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 11);
// }


// void ReleaseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
//         Console.Write($"{array[i] * array[array.Length - i - 1]} ");
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
//ReleaseArray(array);

 
// ДОМАШНЯЯЯ РАБОТА УРОК 5
/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

// void InputArray (int[] array )
// {
//      for ( int i = 0; i < array.Length; i++)
//      array[i] = new Random().Next(100, 1000); 
// }
 
//  int EvenNumbers (int[] array )
//  {
//       int count = 0 ;
//       for ( int i = 0; i < array.Length; i++)
//       {
//           if (array[i] % 2 == 0)
//           count++;
//       }
//       return count;
//  }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Kоличество чётных чисел: [{EvenNumbers(array)}]");

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих 
на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
//   
//
// ВАРИАНТ 1
//
//
// void InputArray (int[] array )
// {
//      for ( int i = 0; i < array.Length; i++)
//      array[i] = new Random().Next(100, 1000); 
// }
 
//  void OddSum (int[] array )
//  {
//       int sum = 0 ;
//       for ( int i = 0; i < array.Length; i++)
//       {
//           if (i % 2 == 1)
//           sum += array[i] ;
//       }
//       Console.WriteLine($"Сумма элементов, на нечётных позициях: [{sum}]");
 //  }
 //      ВАРИАНТ 2
//
//
//      int sum = 0 ;
//       for ( int i = 1; i < array.Length; i+=2)
//       {
//          sum += array[i] ;
//           return sum; 
//       } 
//

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
// OddSum(array);
 
/*
 Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

// void InputArray (double[] array )
// {
//      Random rand = new Random();
//      for ( int i = 0; i < array.Length ; i++)
//      array[i] = rand.Next(-5, 5) + Math.Round(rand.NextDouble(),1);
     
// }
//   void MaxMin ( double[] array) 
//   {
//     for ( int i = 0; i < array.Length-1; i++) 
//     { int MinPos = i;
    
//           for ( int j = i + 1; j < array.Length; j++)
//                 {
//                   if ( array [j] <  array [MinPos]) MinPos = j; 
                  
//                 }  
//                       double temp = array [i] ;
//                       array [i] = array [MinPos] ;
//                       array [MinPos] =  temp;
//                  }
//               }
// 
//              ДРУГОЙ ВАРИАНТ

//     double MaxArray ( double[] array) 
//   {
//      double maxArray = array [0];
//     for ( int i = 0; i < array.Length-1; i++) 
//        {
//          if ( maxArray < array [i])
//            maxArray  = array [i];
//         }
//          return maxArray;
//    } 


//      //     double MinArray ( double[] array) 
//   {
//      double minArray = array [0];
//     for ( int i = 0; i < array.Length-1; i++) 
//        {
//          if ( minArray > array [i])
//            minArray  = array [i];
//         }
//          return minArray;
//    } 
// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[n];
//  InputArray(array);
//  Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
//  MaxMin(array);
//  Console.WriteLine($"Текущий массив:  [{string.Join(", ", array)}]");
//  Console.WriteLine($"Разность max и min: [{array[array.Length-1] - array[0]}]");
//для другого варианта
//  Console.WriteLine($"Разность max и min: [{MaxArray(array) - MinArray(array)}]");


/*
Вася не любит английский язык, но каждый раз старается получить хотя бы четверку за четверть, чтобы оставаться 
ударником. В текущей четверти Вася заметил следующую закономерность: по нечетным дням месяца он получал тройки, а 
по четным – четверки. Так же он помнит, в какие дни он получал эти оценки. Поэтому он выписал на бумажке все эти дни 
для того, чтобы оценить, сколько у него троек и сколько четверок. Помогите Васе это сделать, расположив четные и 
нечетные числа в разных строчках. Вася может рассчитывать на оценку 4, если четверок не меньше, чем троек.
Входные данные
В первой строке входного файла INPUT.TXT записано единственное число N – количество элементов целочисленного 
массива (1 ≤ N ≤ 100). Вторая строка содержит N чисел, представляющих заданный массив. Каждый элемент массива – 
натуральное число от 1 до 31. Все элементы массива разделены пробелом.

Выходные данные
В первую строку выходного файла OUTPUT.TXT нужно вывести числа, которые соответствуют дням месяцев, в которые 
Вася получил тройки, а во второй строке соответственно расположить числа месяца, в которые Вася получил четверки. 
В третьей строке нужно вывести «YES», если Вася может рассчитывать на четверку и «NO» в противном случае. 
В каждой строчке числа следует выводить в том же порядке, в котором они идут во входных данных. При выводе числа 
отделяются пробелом
*/




// void InputArray (int[] array )
// {
//      for ( int i = 0; i < array.Length; i++)
//      array[i] = new Random().Next(1,32); 
// }
// int count4 = 0; 
// int CountEven (int[] array)
// {   
 
//    for ( int i = 0; i < array.Length; i++)
//       {
//              if ( array[i] % 2 == 0 )
//           {
//            Console.Write($" {string.Join(", ", array [i]  )} ");
//            count4 ++;
//           }
//       }
//    return count4;
//   }

// int count3 = 0;
// int CountOdd (int[] array)

// {
//   for ( int i = 0; i < array.Length; i++)
//       {
//              if ( array[i] % 2 == 1 )
//          {
//           Console.Write($" {string.Join(", ",   array [i]  )} ");
//           count3 ++;
//          }
//       }
//       return count3;
// }
// void FinalResult (int[] array )
//    {
//    if (count4 > count3)
//       Console.Write("Вася может рассчитывать на оценку 4");
//    else
//        Console.Write("Вася может рассчитывать на оценку 3");
//     }
// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Исходный массив: [{string.Join(", ", array )}]");
// CountEven (array);
// Console.WriteLine();
// CountOdd (array);
// Console.WriteLine();
// FinalResult (array);



//  УРОК 6 08122022
 
 
//   ПРОВЕРКА ДОМАШНЕГО  ЗАДАНИЯ

//   КАК ВВОДИТЬ ДРОБНЫЕ ЧИСЛА

// Console.Clear();
// int i = 0;
// while ( i <= 10)
//  ВАРИАНТ 1
// {
//  double val = new Random().NextDouble() * (10 - 1) + 1;
//  Console.WriteLine(Math.Round(val,2));
//  i++;
//  }
// ВАРИАНТ 2
//      Random rand = new Random();
//      array[i] = rand.Next(-5, 5) + Math.Round(rand.NextDouble(),1);

//array[i] = Math.Round( new Random ().NextDouble() * (20 -10) + 10,2);

//    ДЛЯ ТОГО, ЧТОБЫ НЕ ПОВТОРЯЛИСЬ ЧИСЛА ПРИ ИСПОЛЬЗОВАНИИ RANDOM
// 
//  void InputArray ( int []array)
//{
//   for ( int i = 0; i < array.Length; i++)
//    {
//      int x =  new Random ().Next(100,1000);
//       while ( array.Contains(x))
//       x = new Random ().Next(100,1000);
//        array[i] = x;
//    }
//  }


//     LESSON 6


/*
Задача 39: Напишите программу, которая
перевернёт одномерный массив (последний элемент
будет на первом месте, а первый - на последнем и
т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/                   
//
//      void InputArray (int[] array)
//            {
//                  for ( int i = 0; i < array.Length; i++)
//                         array [i] = new Random ().Next(1,11);
//             }
                 
//                  int[] ReleaseArray ( int [] array)
//                  {  
//                    for ( int i = 0; i < array.Length / 2; i++)  
//                      {
//                       int temp = array [i] ;
//                       array [i] = array [array.Length - i - 1] ;
//                       array [array.Length - i - 1] =  temp;
//                      }
//                     return array;
//                  }
                
// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Исходный массив: [{string.Join(", ", array )}]");
// Console.WriteLine($"Исходный массив: [{string.Join(", ", ReleaseArray (array) )}]");



/*
Задача 40: Напишите программу, которая принимает на
вход три числа и проверяет, может ли существовать
треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.
*/
  
// Console.Clear();
// Console.Write("Введите число a =: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число b =: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число c =: ");
// int c = Convert.ToInt32(Console.ReadLine());
//  if ( a+b>c && b+c>a && a+c>b)
// Console.Write("может  существовать треугольник с сторонами такой длины. ");
// else
// {Console.Write(" Не может  существовать треугольник с сторонами такой длины. ");}


/*
Задача 42: Напишите программу, которая будет
преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/



// Console.Clear();
// Console.Write("Введите число a =: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string result = String.Empty;
// while ( n > 0 )
// {
//   result = Convert.ToString( n % 2 ) + result;
//   n/=2;
// }
// Console.WriteLine(result);



/*
Задача 44: Не используя рекурсию, выведите первые
N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и
1
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

// Console.Clear(); 
// Console.Write("Введите число: "); 
// int n = Convert.ToInt32(Console.ReadLine()); 
// int x, a0 = 0, a1 = 1; 
// for (int i = 0; i < n; i++) 
// {     Console.Write($"{a0} ");     
// x = a0 + a1;     
// a0 = a1;     
// a1 = x; 
// }


/*
Задача 45: Напишите программу, которая будет
создавать копию заданного массива с помощью
поэлементного копирования.
*/

// КАК ПРАВИЛЬНО КОПИРОВАТЬ МАССИВЫ

//  Clear(); 
// int[] a = {1, 2, 3, 4, 5}; 
// int[] b = new int[a.Length]; 
// for (int i = 0; i < a.Length; i++)     
// b[i] = a[i]; 
// b[0] = 5; 
// Console.WriteLine(string.Join(", ", a)); 
// Console.WriteLine(string.Join(", ", b));

// public class Sum{
//   private static void Main(){
//     int n = Convert.ToInt32(Console.ReadLine());
//         int countDel = 0, i, j, k, m;
//         for (i = 2; i <= n / 2; i++)
//         {
//             countDel = 0;
//             for (j = 2; j <= i / 2; j++)
//             {
//                 if (i % j == 0)
//                     countDel++;
//             }
//             if (countDel == 0)
//             {
//                 countDel = 0;
//                 m = n - i;
//                 for (k = 2; k <= (m + 1) / 2; k++)
//                 {
//                     if (m % k == 0)
//                         countDel++;
//                 }
//                 if (countDel == 0)
//                 {
//                     Console.WriteLine($"{i} {m}");
//                     return;
//                 }
//             }
//         }
//   }
// }



