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

Console.WriteLine("Введите два целых числа");
int x=Convert.ToInt32 (Console.ReadLine());
int y=Convert.ToInt32 (Console.ReadLine());
if (x>y)
{
    Console.Write(x+" большее число,а "+y+" меньшее");
}
else if (x<y)
{
    Console.Write(y+" большее число,а "+x+" меньшее");
}
else 
{
    Console.WriteLine("Введённые данные не отвечают требованиям, либо числа равны");
}