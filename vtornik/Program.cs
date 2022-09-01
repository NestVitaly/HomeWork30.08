//выведу все числа от 0 до x
 //               int i = 0;
 //               while (i<=x) 
 //                   {
 //                       Console.Write (i+", "); 
 //                       i++; 
//                    }

//Console.WriteLine("ВВедите целое число");
//try
//{
//    int x = Convert.ToInt32 (Console.ReadLine());
//    int b = -x;
//    while (b<=x) 
//        {
//            Console.Write (b+","); 
//            b++; 
//        }
//}
//catch
//{
//    Console.WriteLine("Увы");
//}


//Console.WriteLine("ВВедите целое число");
//try
//{
//    int x=Convert.ToInt32 (Console.ReadLine());
 //
//                int b=x%10;
//
 //               Console.WriteLine("Третья цифра этого числа это "+b);
//
//        }
//}
//catch
//{
//    Console.WriteLine("Увы");
//}

//Домашняя работа: Задача 2

//Console.WriteLine("Введите два целых числа");
//int x=Convert.ToInt32 (Console.ReadLine());
//int y=Convert.ToInt32 (Console.ReadLine());
//if (x>y)
//{
//    Console.Write(x+" большее число,а "+y+" меньшее");
//}
//else if (x<y)
//{
//    Console.Write(y+" большее число,а "+x+" меньшее");
//}
//else 
//{
//    Console.WriteLine("Введённые данные не отвечают требованиям, либо числа равны");
//}

//Домашняя работа: Задача 4

//Console.WriteLine("Введите три целых числа");

//int a=Convert.ToInt32 (Console.ReadLine());
//int b=Convert.ToInt32 (Console.ReadLine());
//int c=Convert.ToInt32 (Console.ReadLine());
//if (a > b && a > c)
//{
//     Console.WriteLine("Максимальное число "+a);
//}
//else if (b > c && b > a)
//{
//     Console.WriteLine("Максимальное число "+b);
//}
//else if (c > a && c > b)
//{
//     Console.WriteLine("Максимальное число "+c);
//}
//else 
//{
//    Console.WriteLine("Введены некорректные данные");
//}

//Домашняя работа: Задача 6

// Console.Write("Введите целое число ");
// int x=Convert.ToInt32 (Console.ReadLine());
// if (x%2==0)
// {
//     Console.WriteLine("Число "+x+" является чётным");
// }
// else
// {
//     Console.WriteLine("Число нечетное");
// }

//Домашняя работа: Задача8

Console.Write("Введите целое число ");
int x=Convert.ToInt32 (Console.ReadLine());
int i=2;
while (i<x)
{
   Console.WriteLine(i+",");
   i = i +2;
}