namespace ежеднивник1
{
    internal class Program
    {
        static DateTime dateTime = DateTime.Now;
        static string[] dela = new string[] { "Сходить в шарагу", "Сделать практосы", "спать", "Погулять", "Похавать", "Поспать", "Сходить в шарагу" };
        static void Main(string[] args)
        {
            int position = 1;
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                Console.Write("Выбрана дата: " + dateTime.ToShortDateString() + "\n");
                Menu();
                Strelki(position);
                position = Strelki(position);
                Dela(position);
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Q);
        }
        static void Data(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.LeftArrow)
            {
                Console.SetCursorPosition(0, 0);
                dateTime = dateTime.AddDays(-1);
                Console.Clear();
                Console.Write("Выбрана дата: " + dateTime.ToShortDateString() + "\n");
                Menu();
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                Console.SetCursorPosition(0, 0);
                dateTime = dateTime.AddDays(+1);
                Console.Clear();
                Console.Write("Выбрана дата: " + dateTime.ToShortDateString() + "\n");
                Menu();
            }
        }

        static int Strelki(int position)
        {
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");


                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    if (position == 0)
                        position = 2;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    if (position == 5)
                        position = 1;
                }
                Data(key);
            } while (key.Key != ConsoleKey.Enter);
            return position;
        }
        static void Dela(int position1)
        {
            if (position1 == 1 && dateTime.Date == new DateTime(2023, 10, 18))
            {
                Console.Clear();
                Console.WriteLine($"{dela[0]}\n------------------\nОписание: С первой по четвертую\nДата: " + dateTime);
            }
            else if (position1 == 1 && dateTime.Date == new DateTime(2023, 10, 19))
            {
                Console.Clear();
                Console.WriteLine($"{dela[1]}\n------------------\nОписание: Шарпы, БД, Питон\nДата: " + dateTime);
            }
            if (position1 == 2 && dateTime.Date == new DateTime(2023, 10, 19))
            {
                Console.Clear();
                Console.WriteLine($"{dela[2]}\n------------------\nОписание: С 18:00 по 20:00\nДата: " + dateTime);
            }
            else if (position1 == 1 && dateTime.Date == new DateTime(2023, 10, 22))
            {
                Console.Clear();
                Console.WriteLine($"{dela[3]}\n------------------\nОписание: С 17:00 по 20:00\nДата: " + dateTime);
            }
            else if (position1 == 1 && dateTime.Date == new DateTime(2023, 10, 23))
            {
                Console.Clear();
                Console.WriteLine($"{dela[4]}\n------------------\nОписание: Чипсеки\nДата: " + dateTime);
            }
            else if (position1 == 2 && dateTime.Date == new DateTime(2023, 10, 23))
            {
                Console.Clear();
                Console.WriteLine($"{dela[5]}\n------------------\nОписание: С 18:00 по 20:00\nДата: " + dateTime);
            }
            else if (position1 == 1 && dateTime.Date == new DateTime(2023, 10, 25))
            {
                Console.Clear();
                Console.WriteLine($"{dela[6]}\n------------------\nОписание: С 17:00 по 20:00\nДата: " + dateTime);
            }
        }

        static void Menu()
        {
            if (dateTime.Date == new DateTime(2023, 10, 18))
            {
                Console.Write($"  1. {dela[0]}");
            }
            else if (dateTime.Date == new DateTime(2023, 10, 19))
            {
                Console.WriteLine($"  1. {dela[1]}\n  2. {dela[2]}");
            }
            else if (dateTime.Date == new DateTime(2023, 10, 22))
            {
                Console.WriteLine($"  1. {dela[3]}");
            }
            else if (dateTime.Date == new DateTime(2023, 10, 23))
            {
                Console.WriteLine($"  1. {dela[4]}\n  2. {dela[5]}");
            }
            else if (dateTime.Date == new DateTime(2023, 10, 25))
            {
                Console.WriteLine($"  1. {dela[6]}");
            }
        }
    }
}
