using System;

namespace ConsoleApplicationTask3var13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Home home = new Home(0, 0);
            
            while (true)
            {
                Console.WriteLine("Выберите действие:\n" +
                                  "\t1)Создать дом\n\t2)Открыть окно\n" +
                                  "\t3)Закрыть окно\n\t4)Открыть дверь\n" +
                                  "\t5)Закрыть дверь\n\t6)Открыть дверь с ключём\n" +
                                  "\t7)Закрыть дверь с ключём\n\t8)Вывести количество окон\n" +
                                  "\t9)Вывести количество дверей\n\t10)Вывести дом\n");
                
                int i = Convert.ToInt32(Console.ReadLine());
                
                if (i == 0) break;

                switch (i)
                {
                    case 1:
                        Console.WriteLine("Введите количество дверей (n>0)");
                        int doors = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите количество окон (n>0)");
                        int windows = Convert.ToInt32(Console.ReadLine());
                        if ((doors > 0) && (windows > 0))
                        {
                            home = new Home(doors, windows);
                            Console.WriteLine("Дом создан");
                            Console.WriteLine(home);
                        }
                        else
                        {
                            Console.WriteLine("Введены некорректные параметры");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введите номер окна");
                        int window1 = Convert.ToInt32(Console.ReadLine());
                        if ((window1 > 0) && (window1 <= home.windowsQ()))
                        {
                            home.openWindow(window1);
                        }
                        else
                        {
                            Console.WriteLine("Такого окна нет");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Введите номер окна");
                        int window2 = Convert.ToInt32(Console.ReadLine());
                        if ((window2 > 0) && (window2 <= home.windowsQ()))
                        {
                            home.closeWindow(window2);
                        }
                        else
                        {
                            Console.WriteLine("Такого окна нет");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Введите номер двери");
                        int door1 = Convert.ToInt32(Console.ReadLine());
                        if ((door1 > 0) && (door1 <= home.doorsQ()))
                        {
                            home.openDoor(door1);
                        }
                        else
                        {
                            Console.WriteLine("Такой двери нет");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Введите номер двери");
                        int door2 = Convert.ToInt32(Console.ReadLine());
                        if ((door2 > 0) && (door2 <= home.doorsQ()))
                        {
                            home.closeDoor(door2);
                        }
                        else
                        {
                            Console.WriteLine("Такой двери нет");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Введите номер двери");
                        int door3 = Convert.ToInt32(Console.ReadLine());
                        if ((door3 > 0) && (door3 <= home.doorsQ()))
                        {
                            home.openDoorWithKey(door3);
                        }
                        else
                        {
                            Console.WriteLine("Такой двери нет");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Введите номер двери");
                        int door4 = Convert.ToInt32(Console.ReadLine());
                        if ((door4 > 0) && (door4 <= home.doorsQ()))
                        {
                            home.closeDoorWithKey(door4);
                        }
                        else
                        {
                            Console.WriteLine("Такой двери нет");
                        }
                        break;
                    case 8:
                        Console.WriteLine($"Окон в доме :{home.windowsQ()}");
                        break;
                    case 9:
                        Console.WriteLine($"Дверей в доме :{home.doorsQ()}");
                        break;
                    case 10:
                        Console.WriteLine(home);
                        break;
                }
            }
        }
    }
}