using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Menu
    {
        private int selector;
        private int insideSelector;

        public void MainMenu()
        {
            #region MainMenu
            //Кодування UTF8 для корректного відображення кирилиці
            Console.OutputEncoding = Encoding.UTF8;

            //Цикл, в якому задаєм "селектор" для взаємодії з пунктами меню
            do
            {
                try
                {
                    //Графічний розділювач, для покращеної "читабельності" тексту меню
                    Console.Write(new string('-', 45));

                    //Пункти головного меню на екран
                    Console.WriteLine(
                                     "\n1: додати нового працівника" +
                                     "\n2: переглянути дані працівника" +
                                     "\n3: редагувати існуючого працівника" +
                                     "\n4: видалити існуючого працівника" +
                                     "\n5: згенерувати звіт" +
                                     "\n\n0: Вийти з програми");

                    //Задаєм "селектор"
                    Console.Write("\nОберіть пункт котрий потрібно виконати: ");
                    selector = int.Parse(Console.ReadLine());

                    //Якщо "селектор"=0, тоді виходим з методу, для подальшого завершення програми
                    if (selector == 0)
                        break;

                    //Якщо "селектор" приймає значення від 1 до 5 включно, переходим у відповідні підменю
                    switch (selector)
                    {
                        case 1:
                            Console.WriteLine("\nДодали нового користувача\n");
                            Delay();
                            break;
                        case 2: SubMenuInfo(); break;
                        case 3: SubMenuEdit(); break;
                        case 4: SubMenuDelete(); break;
                        case 5: SubMenuReport(); break;
                        default:
                            //Якщо "селектор" число, але не підпало під діапазон меню, тоді повідомлення про це і буде спроба ввести ще раз
                            Console.WriteLine("\nНемає такого пункту!\n");
                            Delay();
                            break;
                    }
                }
                catch (FormatException)
                {
                    //Якщо "селектор" не число, отримаємо не вірне значення і буде спроба ввести ще раз
                    Console.WriteLine("Не вірне значення");
                    Delay();
                }
            }
            // Крутим цикл поки "селектор" не дорівнює 0
            while (true);
            #endregion
        }

        public void SubMenuInfo()
        {
            #region CASE2
            //Масив для тесту
            string[] empl = new string[4];
            empl[1] = "Працівник1";
            empl[2] = "Працівник2";
            empl[3] = "Працівник3";
            do
            {
                //Вивід тестового масиву на екран
                for (int i = 1; i < empl.Length; i++)
                    Console.WriteLine("{0}. {1}", i, empl[i]);

                //Змінна exit, яка при набуванні значення 0 вийде з циклу і даного методу
                int exit = -1;
                if (exit == 0)
                    break;
                try
                {
                    //Задаєм "селектор" для підменю
                    Console.Write("\nОберіть працівника для отримання інформації або натисніть <0> для повернення у попереднє меню: ");
                    insideSelector = int.Parse(Console.ReadLine());

                    //Якщо "селектор дорівнює 0, присвоюєм змінній exit це значення
                    if (insideSelector == 0)
                    {
                        exit = insideSelector;
                        break;
                    }
                    //Перевіряєм чи значення "селектору" не перевищує кількості елементів тестового масиву
                    if (insideSelector < empl.Length)
                        Console.WriteLine("\nІнформація про існуючого користувача:\n{0}\n", empl[insideSelector]);

                    //Якщо значення "селектору" перевищує кількість елементів тестового масиву
                    else Console.WriteLine("Немає такого працівника");
                    Delay();
                }
                catch (FormatException)
                {
                    //Якщо "селектор" не число, отримаємо не вірне значення і буде спроба ввести ще раз
                    Console.WriteLine("Не вірне значення");
                    Delay();
                }
            }
            while (true);
            #endregion
        }

        public void SubMenuEdit()
        {
            #region CASE3
            string[] empl = new string[4];
            empl[1] = "Працівник1";
            empl[2] = "Працівник2";
            empl[3] = "Працівник3";
            do
            {
                for (int i = 1; i < empl.Length; i++)
                    Console.WriteLine("{0}. {1}", i, empl[i]);
                int exit = -1;
                if (exit == 0)
                    break;
                try
                {
                    Console.Write("\nОберіть працівника для редагування або натисніть <0> для повернення у попереднє меню: ");
                    insideSelector = int.Parse(Console.ReadLine());

                    if (insideSelector == 0)
                    {
                        exit = insideSelector;
                        break;
                    }

                    if (insideSelector < empl.Length)
                        Console.WriteLine("\nВідредагували існуючого користувача:\n{0}\n", empl[insideSelector]);
                    else Console.WriteLine("Немає такого працівника");
                    Delay();
                }

                catch (FormatException)
                {
                    //Console.Clear();
                    Console.WriteLine("Не вірне значення");
                    Delay();
                }
            }
            while (true);
            #endregion
        }

        public void SubMenuDelete()
        {
            #region CASE4
            string[] empl = new string[4];
            empl[1] = "Працівник1";
            empl[2] = "Працівник2";
            empl[3] = "Працівник3";
            do
            {
                for (int i = 1; i < empl.Length; i++)
                    Console.WriteLine("{0}. {1}", i, empl[i]);
                int exit = -1;
                if (exit == 0)
                    break;
                try
                {
                    Console.Write("\nОберіть працівника для видалення або натисніть <0> для повернення у попереднє меню: ");
                    insideSelector = int.Parse(Console.ReadLine());

                    if (insideSelector == 0)
                    {
                        exit = insideSelector;
                        break;
                    }

                    if (insideSelector < empl.Length)
                    {
                        Console.Write("\nВи дійсно хочете видалити " + empl[insideSelector] + "?" +
                           "\n1: так" + "\n2: ні");
                        Console.Write("\nВаріант: ");
                        selector = int.Parse(Console.ReadLine());
                        switch (selector)
                        {
                            case 1: Console.WriteLine("\nВидалили користувача\n{0}\n", empl[insideSelector]); break;
                            case 2: Console.WriteLine("\nОперація по видаленню працівника відмінена!"); break;
                            default: Console.WriteLine("\nОбраний варіант не існує!"); break;
                        }
                    }
                    else Console.WriteLine("Немає такого працівника");
                    Delay();
                }

                catch (FormatException)
                {
                    //Console.Clear();
                    Console.WriteLine("Не вірне значення");
                    Delay();
                }
            }
            while (true);
            #endregion
        }

        public void SubMenuReport()
        {
            #region Case 5
            Console.WriteLine(
               "\n1. Сформувати звіт по всім працівникам" +
               "\n2. Сформувати звіт по фільтру");
            Console.Write("\nОберіть пункт котрий потрібно виконати: ");

            try
            {
                insideSelector = int.Parse(Console.ReadLine());

                switch (insideSelector)
                {
                    case 0: break;
                    case 1:
                        Console.WriteLine("\nЗгенерували звіт по всім працівникам\n");
                        break;
                    case 2:
                        Console.WriteLine("\nЗгенерували звіт по фільтру\n");
                        break;
                    default:
                        Console.WriteLine("\nНемає такого пункту!\n");
                        break;
                }
                Delay();
            }

            catch (FormatException)
            {
                Console.WriteLine("Не вірне значення");
                Delay();
            }
            #endregion
        }

        public void ExitProject()
        { Environment.Exit(0); }

        //Метод, для затримки після виконня опирації, для кращої читабельності програми
        public void Delay()
        {
            Console.Write("Натисніть <Enter> для продовження..."); //36 символів
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            //Затираємо весь рядок, на випадок, якщо користувач замість Enter
            //буде ліпити інші символи, і щоб вони не залишились після натискання Enter
            Console.Write(new string(' ', 119));
            Console.Write("\r");
        }
    }
}