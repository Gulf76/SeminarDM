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

