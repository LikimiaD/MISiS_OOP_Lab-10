/*
 * Вариант: 8
 * Уровень: 3
 */
namespace Level_3
{
    public class Program
    {
        public static Random rnd = new Random();
        public static int random_value;
        public static int min_value = 0;
        public static int range;
        public static int max_value = 36;

        public static int player1;
        public static int player2;
        public static int player1_count;
        public static int player2_count;
        public static int player1_win;
        public static int player2_win;
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Русская локализация
            player1_count = 0;
            player2_count = 0;
            Console.WriteLine("Сколько раз будет повторяться игра?");
            range = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Возможные комбинации\n" +
                "a)	выпадает четное или нечетное число;\n" +
                "b)	число попадает в интервал [1, 18] или [19, 36];\n" +
                "c)	число попадает в одну из трех дюжин [1, 12], [13, 24], [25, 36];\n" +
                "d)	число попадает в одну из четырех девяток: [1, 9], [10, 18], [19, 27], [28, 36];\n" +
                "e)	число попадает в одну из шестерок: [1, 6], [7, 12], [13, 18], [19, 24], [25, 30], [31, 36];\n" +
                "f)	число попадает в одну из троек: [1, 3], [4, 6], ..., [34, 36];\n" +
                "g)	число попадает в одну из пар: [1, 2], [3, 4], ..., [35, 36];\n" +
                "h)	выпадет число K от 1 до 36.\n");
            Console.WriteLine("Игра началась");
            for (int i = 0; i < range; i++)
            {
                if (i != 0)
                    Console.WriteLine("Cледующий раунд\n");
                player1 = 0;
                player2 = 0;
                player1_win = 0;
                random_value = rnd.Next(min_value, max_value);
                Console.WriteLine("Игрок1 введите букву для раунда {0}", i);
                player1 = win(1, Console.ReadLine());
                Console.WriteLine("Игрок2 введите букву для раунда {0}", i);
                player2 = win(2, Console.ReadLine());
                Console.WriteLine("Игрок1 выйграл за раунд - {0}, Игрок2 выйграл за раунд - {1}", player1, player2);
                player1_count = player1;
                player2_count = player2;
                Console.WriteLine("Рандомное число было - {0}", random_value);
            }
            Console.WriteLine("Общая сумма:\n" +
                "Игрок1 - {0}\n" +
                "Игрок2 - {1}\n", player1_count, player2_count);
            Console.ReadKey();

        }
        public static int win(int num, string player1)
        {
            Console.WriteLine("Игрок{0} выбирает", num);
            player1_win = 0;
            switch (player1)
            {
                case "a":
                    Console.WriteLine("Число будет четным или нет?\n" +
                        "Да - 0\n" +
                        "Нет - 1\n");
                    if (Console.ReadLine() == "0")
                    {
                        if (random_value % 2 == 0)
                            player1_win = 1;
                        else
                            player1_win = 0;
                    }
                    else
                    {
                        if (random_value % 2 != 0)
                            player1_win = 1;
                        else
                            player1_win = 0;
                    }
                    break;
                case "b":
                    Console.WriteLine("Число будет в интервале от:?\n" +
                                        "[1-18] - 0\n" +
                                        "[19-36] - 1\n");
                    if (Console.ReadLine() == "0")
                    {
                        if (1 <= random_value && random_value <= 18)
                            player1_win = 1;
                        else
                            player1_win = 0;
                    }
                    else
                    {
                        if (19 <= random_value && random_value <= 36)
                            player1_win = 1;
                        else
                            player1_win = 0;
                    }
                    break;
                case "c":
                    Console.WriteLine("Число будет в интервале от:?\n" +
                                        "[1-12] - 0\n" +
                                        "[13-24] - 1\n" +
                                        "[25-36] - 2\n");
                    if (Console.ReadLine() == "0")
                    {
                        if (1 <= random_value && random_value <= 12)
                            player1_win = 2;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "1")
                    {
                        if (13 <= random_value && random_value <= 24)
                            player1_win = 2;
                        else
                            player1_win = 0;
                    }
                    else
                    {
                        if (25 <= random_value && random_value <= 36)
                            player1_win = 2;
                        else
                            player1_win = 0;
                    }
                    break;
                case "d":
                    Console.WriteLine("Число будет в интервале от:?\n" +
                                        "[1-9] - 0\n" +
                                        "[10-18] - 1\n" +
                                        "[19-27] - 2\n" +
                                        "[28-36] - 3\n");
                    if (Console.ReadLine() == "0")
                    {
                        if (1 <= random_value && random_value <= 9)
                            player1_win = 3;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "1")
                    {
                        if (10 <= random_value && random_value <= 18)
                            player1_win = 3;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "2")
                    {
                        if (19 <= random_value && random_value <= 27)
                            player1_win = 3;
                        else
                            player1_win = 0;
                    }
                    else
                    {
                        if (28 <= random_value && random_value <= 36)
                            player1_win = 3;
                        else
                            player1_win = 0;
                    }
                    break;
                case "e":
                    Console.WriteLine("Число будет в интервале от:?\n" +
                                        "[1-6] - 0\n" +
                                        "[7-12] - 1\n" +
                                        "[13-18] - 2\n" +
                                        "[19-24] - 3\n" +
                                        "[25-30] - 4\n" +
                                        "[31-36] - 5\n");
                    if (Console.ReadLine() == "0")
                    {
                        if (1 <= random_value && random_value <= 6)
                            player1_win = 5;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "1")
                    {
                        if (7 <= random_value && random_value <= 12)
                            player1_win = 5;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "2")
                    {
                        if (13 <= random_value && random_value <= 18)
                            player1_win = 5;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "3")
                    {
                        if (19 <= random_value && random_value <= 24)
                            player1_win = 5;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "4")
                    {
                        if (25 <= random_value && random_value <= 30)
                            player1_win = 5;
                        else
                            player1_win = 0;
                    }
                    else
                    {
                        if (31 <= random_value && random_value <= 36)
                            player1_win = 5;
                        else
                            player1_win = 0;
                    }
                    break;
                case "f":
                    Console.WriteLine("Число будет в интервале от:?\n" +
                                        "[1-3] - 0\n" +
                                        "[4-6] - 1\n" +
                                        "[7-9] - 2\n" +
                                        "[10-12] - 3\n" +
                                        "[13-15] - 4\n" +
                                        "[16-18] - 5\n" +
                                        "[19-21] - 6\n" +
                                        "[22-24] - 7\n" +
                                        "[25-27] - 8\n" +
                                        "[28-30] - 9\n" +
                                        "[31-33] - 10\n" +
                                        "[34-36] - 11\n");
                    if (Console.ReadLine() == "1")
                    {
                        if (1 <= random_value && random_value <= 3)
                            player1_win = 11;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "1")
                    {
                        if (4 <= random_value && random_value <= 6)
                            player1_win = 11;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "2")
                    {
                        if (7 <= random_value && random_value <= 9)
                            player1_win = 11;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "3")
                    {
                        if (10 <= random_value && random_value <= 12)
                            player1_win = 11;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "4")
                    {
                        if (13 <= random_value && random_value <= 15)
                            player1_win = 11;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "5")
                    {
                        if (16 <= random_value && random_value <= 18)
                            player1_win = 11;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "6")
                    {
                        if (19 <= random_value && random_value <= 21)
                            player1_win = 11;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "7")
                    {
                        if (22 <= random_value && random_value <= 24)
                            player1_win = 11;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "8")
                    {
                        if (25 <= random_value && random_value <= 27)
                            player1_win = 11;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "9")
                    {
                        if (28 <= random_value && random_value <= 30)
                            player1_win = 11;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "10")
                    {
                        if (31 <= random_value && random_value <= 33)
                            player1_win = 11;
                        else
                            player1_win = 0;
                    }
                    else
                    {
                        if (34 <= random_value && random_value <= 36)
                            player1_win = 11;
                        else
                            player1_win = 0;
                    }
                    break;
                case "g":
                    Console.WriteLine("Число будет в интервале от:?\n" +
                                        "[1-2] - 0\n" +
                                        "[3-4] - 1\n" +
                                        "[5-6] - 2\n" +
                                        "[7-8] - 3\n" +
                                        "[9-10] - 4\n" +
                                        "[11-12] - 5\n" +
                                        "[13-14] - 6\n" +
                                        "[15-16] - 7\n" +
                                        "[17-18] - 8\n" +
                                        "[19-20] - 9\n" +
                                        "[21-22] - 10\n" +
                                        "[23-24] - 11\n" +
                                        "[25-26] - 12\n" +
                                        "[27-28] - 13\n" +
                                        "[29-30] - 14\n" +
                                        "[31-32] - 15\n" +
                                        "[33-34] - 16\n" +
                                        "[35-36] - 17\n");
                    if (Console.ReadLine() == "1")
                    {
                        if (1 <= random_value && random_value <= 2)
                            player1_win = 17;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "1")
                    {
                        if (3 <= random_value && random_value <= 4)
                            player1_win = 17;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "2")
                    {
                        if (5 <= random_value && random_value <= 6)
                            player1_win = 17;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "3")
                    {
                        if (7 <= random_value && random_value <= 8)
                            player1_win = 17;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "4")
                    {
                        if (9 <= random_value && random_value <= 10)
                            player1_win = 17;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "5")
                    {
                        if (11 <= random_value && random_value <= 12)
                            player1_win = 17;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "6")
                    {
                        if (13 <= random_value && random_value <= 14)
                            player1_win = 17;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "7")
                    {
                        if (15 <= random_value && random_value <= 16)
                            player1_win = 17;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "8")
                    {
                        if (17 <= random_value && random_value <= 18)
                            player1_win = 17;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "9")
                    {
                        if (19 <= random_value && random_value <= 20)
                            player1_win = 17;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "10")
                    {
                        if (21 <= random_value && random_value <= 22)
                            player1_win = 17;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "11")
                    {
                        if (23 <= random_value && random_value <= 24)
                            player1_win = 17;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "12")
                    {
                        if (25 <= random_value && random_value <= 26)
                            player1_win = 17;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "13")
                    {
                        if (27 <= random_value && random_value <= 28)
                            player1_win = 17;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "14")
                    {
                        if (29 <= random_value && random_value <= 30)
                            player1_win = 17;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "15")
                    {
                        if (31 <= random_value && random_value <= 32)
                            player1_win = 17;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "16")
                    {
                        if (33 <= random_value && random_value <= 34)
                            player1_win = 17;
                        else
                            player1_win = 0;
                    }
                    else if (Console.ReadLine() == "17")
                    {
                        if (35 <= random_value && random_value <= 36)
                            player1_win = 17;
                        else
                            player1_win = 0;
                    }

                    else
                    {
                        Console.WriteLine("Ошибка!");
                        player1_win = 0;
                    }
                    break;
                case "h":
                    Console.WriteLine("Введите число");
                    if (random_value == Convert.ToInt32(Console.ReadLine()))
                        player1_win = 35;
                    else
                        player1_win = 0;
                    break;

                default:
                    Console.WriteLine("Такого варианта не существует");
                    break;
            }
            return player1_win;
        }
    }
}

