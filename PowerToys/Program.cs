using System;
using System.ComponentModel.Design;
using System.Reflection;

internal class Program
{
    public static class variables
    {
        public static int operation;
        public static int flag;
    }
    public static void Main(string[] args)
    {
        start();
        Programs();
    }
    public static void Programs()
    {
        Console.WriteLine("█                                                                                   █");
        Console.WriteLine("█          ██▓        ██▓ ██▓        ██▓ ██▓ ██▓          ██▓ ██▒   █▓              █");
        Console.WriteLine("█          ▓██▒       ▓██▒▓██▒       ▓██▒▓██▒▓██▒         ▓██▒▓██░   █▒             █");
        Console.WriteLine("█          ▒██▒       ▒██▒▒██▒       ▒██▒▒██▒▒██▒         ▒██▒ ▓██  █▒░             █");
        Console.WriteLine("█          ░██░       ░██░░██░       ░██░░██░░██░         ░██░  ▒██ █░░             █");
        Console.WriteLine("█          ░██░       ░██░░██░       ░██░░██░░██░         ░██░   ▒▀█░               █");
        Console.WriteLine("█          ░▓         ░▓  ░▓         ░▓  ░▓  ░▓           ░▓     ░ ▐░               █");
        Console.WriteLine("█          ▒ ░        ▒ ░ ▒ ░        ▒ ░ ▒ ░ ▒ ░          ▒ ░   ░ ░░                █");
        Console.WriteLine("█          ▒ ░        ▒ ░ ▒ ░        ▒ ░ ▒ ░ ▒ ░          ▒ ░     ░░                █");
        Console.WriteLine("█         ░          ░   ░          ░   ░   ░            ░        ░                 █");
        Console.WriteLine("█       GuessGame  Multiplytable      dividers               Exit                   █");
        Console.WriteLine("█████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("");
        variables.flag = 0;
        variables.operation = 5;
        while (variables.flag == 0)
        {
            ConsoleKeyInfo menuchoosekey = Console.ReadKey();
            string choosekey = (menuchoosekey.Key.ToString());
            int operate = 0;
            switch (choosekey)
            {
                case "D1":
                    Console.Clear();
                    faststart();
                    Console.WriteLine("█                                                                                   █");
                    Console.WriteLine("█           ██▓        ░░▓ ░░▓        ░░▓ ░░▓ ░░▓          ░░▓ ░░▒   ░▓             █");
                    Console.WriteLine("█          ▓██▒       ▓░░▒▓░░▒       ▓░░▒▓░░▒▓░░▒         ▓░░░░░░░   ░▒             █");
                    Console.WriteLine("█          ▒██▒       ▒░░▒▒░░▒       ▒░░▒▒░░▒▒░░▒         ▒░░▒ ▓░░  ░▒░             █");
                    Console.WriteLine("█          ░██░       ░░░░░░░░       ░░░░░░░░░░░░         ░░░░  ▒░░ ░░░             █");
                    Console.WriteLine("█          ░██░       ░░░░░░░░       ░░░░░░░░░░░░         ░░░░  ▒░░ ░░░             █");
                    Console.WriteLine("█          ░▓         ░░░░░░░░       ░░░░░░░░░░░░         ░░░░  ▒░░ ░░░             █");
                    Console.WriteLine("█          ▒ ░        ▒ ░ ▒ ░        ▒ ░ ▒ ░ ▒ ░          ▒ ░   ░ ░░                █");
                    Console.WriteLine("█          ▒ ░        ▒ ░ ▒ ░        ▒ ░ ▒ ░ ▒ ░          ▒ ░     ░░                █");
                    Console.WriteLine("█         ░          ░   ░          ░   ░   ░            ░        ░                 █");
                    Console.WriteLine("█       GuessGame  Multiplytable      dividers               Exit                   █");
                    Console.WriteLine("█████████████████████████████████████████████████████████████████████████████████████");
                    variables.operation = 1;
                    break;
                case "D2":
                    Console.Clear();
                    faststart();
                    Console.WriteLine("█                                                                                   █");
                    Console.WriteLine("█           ░░▓        ██▓ ██▓        ░░▓ ░░▓ ░░▓          ░░▓ ░░▒   ░▓             █");
                    Console.WriteLine("█           ░░▓       ▒██▒▒██▒       ▓░░▒▓░░▒▓░░▒         ▓░░░░░░░   ░▒             █");
                    Console.WriteLine("█           ░░▓       ▒██▒▒██▒       ▓░░▒▓░░▒▓░░▒         ▓░░░░░░░   ░▒             █");
                    Console.WriteLine("█           ░░▓       ▒██▒▒██▒       ▓░░▒▓░░▒▓░░▒         ▓░░░░░░░   ░▒             █");
                    Console.WriteLine("█           ░░▓       ▒██▒▒██▒       ▓░░▒▓░░▒▓░░▒         ▓░░░░░░░   ░▒             █");
                    Console.WriteLine("█           ░░▓       ▒██▒▒██▒       ▓░░▒▓░░▒▓░░▒         ▓░░░░░░░   ░▒             █");
                    Console.WriteLine("█           ░░▓       ▒██▒▒██▒       ▓░░▒▓░░▒▓░░▒         ▓░░░░░░░   ░▒             █");
                    Console.WriteLine("█          ▒ ░        ▒ ░ ▒ ░        ▒ ░ ▒ ░ ▒ ░          ▒ ░     ░░                █");
                    Console.WriteLine("█         ░          ░   ░          ░   ░   ░            ░        ░                 █");
                    Console.WriteLine("█       GuessGame  Multiplytable      dividers               Exit                   █");
                    Console.WriteLine("█████████████████████████████████████████████████████████████████████████████████████");
                    variables.operation = 2;
                    break;
                case "D3":
                    Console.Clear();
                    faststart();
                    Console.WriteLine("█                                                                                   █");
                    Console.WriteLine("█          ░░▓        ░░▓ ░░▓        ██▓ ██▓ ██▓          ░░▓ ░░▒   ░▓              █");
                    Console.WriteLine("█          ░░▓        ░░▓ ░░▓        ██▓ ██▓ ██▓          ░░▓ ░░▒   ░▓              █");
                    Console.WriteLine("█          ░░▓        ░░▓ ░░▓        ██▓ ██▓ ██▓          ░░▓ ░░▒   ░▓              █");
                    Console.WriteLine("█          ░░▓        ░░▓ ░░▓        ██▓ ██▓ ██▓          ░░▓ ░░▒   ░▓              █");
                    Console.WriteLine("█          ░░▓        ░░▓ ░░▓        ██▓ ██▓ ██▓          ░░▓ ░░▒   ░▓              █");
                    Console.WriteLine("█          ░▓         ░▓  ░▓         ░▓  ░▓  ░▓           ░▓     ░ ▐░               █");
                    Console.WriteLine("█          ▒ ░        ▒ ░ ▒ ░        ▒ ░ ▒ ░ ▒ ░          ▒ ░   ░ ░░                █");
                    Console.WriteLine("█          ▒ ░        ▒ ░ ▒ ░        ▒ ░ ▒ ░ ▒ ░          ▒ ░     ░░                █");
                    Console.WriteLine("█         ░          ░   ░          ░   ░   ░            ░        ░                 █");
                    Console.WriteLine("█       GuessGame  Multiplytable      dividers               Exit                   █");
                    Console.WriteLine("█████████████████████████████████████████████████████████████████████████████████████");
                    variables.operation = 3;
                    break;
                case "D4":
                    Console.Clear();
                    faststart();
                    Console.WriteLine("█                                                                                   █");
                    Console.WriteLine("█          ░░▓        ░░▓ ░░▓         ░░▓ ░░▓ ░░▓          ██▓ ██▒  █▓              █");
                    Console.WriteLine("█          ░░▓        ░░▓ ░░▓         ░░▓ ░░▓ ░░▓          ██▓ ██▒  █▓              █");
                    Console.WriteLine("█          ░░▓        ░░▓ ░░▓         ░░▓ ░░▓ ░░▓          ██▓ ██▒  █▓              █");
                    Console.WriteLine("█          ░░▓        ░░▓ ░░▓        ░░░░░░░░░░░░         ░██░  ▒██ █░              █");
                    Console.WriteLine("█          ░░▓        ░░▓ ░░▓        ░░░░░░░░░░░░         ░██░   ▒██░               █");
                    Console.WriteLine("█          ░▓         ░▓  ░▓         ░▓  ░▓  ░▓           ░▓     ░ ▐░               █");
                    Console.WriteLine("█          ▒ ░        ▒ ░ ▒ ░        ▒ ░ ▒ ░ ▒ ░          ▒ ░   ░ ░░                █");
                    Console.WriteLine("█          ▒ ░        ▒ ░ ▒ ░        ▒ ░ ▒ ░ ▒ ░          ▒ ░     ░░                █");
                    Console.WriteLine("█         ░          ░   ░          ░   ░   ░            ░        ░                 █");
                    Console.WriteLine("█       GuessGame  Multiplytable      dividers               Exit                   █");
                    Console.WriteLine("█████████████████████████████████████████████████████████████████████████████████████");
                    variables.operation = 4;
                    break;
                case "Enter":
                    variables.flag = 1;
                    break;
            }
        }
        switch (variables.operation)
        {
            case 1:
                guessgame();
                break;
            case 2:
                multiplytable();
                break;
            case 3:
                dividers();
                break;
            case 4:
                break;
        }
    }
    static void start()
    {
        Console.WriteLine("█████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("█                                                                                   █");
        Console.WriteLine("█  ██▓███   ▒█████   █     █░▓█████  ██▀███  ▄▄▄█████▓ ▒█████ ▓██   ██▓  ██████     █");
        Thread.Sleep(100);
        Console.WriteLine("█  ▓██░  ██▒▒██▒  ██▒▓█░ █ ░█░▓█   ▀ ▓██ ▒ ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██  ██▒▒██    ▒    █");
        Thread.Sleep(100);
        Console.WriteLine("█  ▓██░ ██▓▒▒██░  ██▒▒█░ █ ░█ ▒███   ▓██ ░▄█ ▒▒ ▓██░ ▒░▒██░  ██▒ ▒██ ██░░ ▓██▄      █");
        Thread.Sleep(100);
        Console.WriteLine("█  ▒██▄█▓▒ ▒▒██   ██░░█░ █ ░█ ▒▓█  ▄ ▒██▀▀█▄  ░ ▓██▓ ░ ▒██   ██░ ░ ▐██▓░  ▒   ██▒   █");
        Thread.Sleep(100);
        Console.WriteLine("█  ▒██▒ ░  ░░ ████▓▒░░░██▒██▓ ░▒████▒░██▓ ▒██▒  ▒██▒ ░ ░ ████▓▒░ ░ ██▒▓░▒██████▒▒   █");
        Thread.Sleep(100);
        Console.WriteLine("█  ▒▓▒░ ░  ░░ ▒░▒░▒░ ░ ▓░▒ ▒  ░░ ▒░ ░░ ▒▓ ░▒▓░  ▒ ░░   ░ ▒░▒░▒░   ██▒▒▒ ▒ ▒▓▒ ▒ ░   █");
        Thread.Sleep(100);
        Console.WriteLine("█  ░▒ ░       ░ ▒ ▒░   ▒ ░ ░   ░ ░  ░  ░▒ ░ ▒░    ░      ░ ▒ ▒░ ▓██ ░▒░ ░ ░▒  ░ ░   █");
        Thread.Sleep(100);
        Console.WriteLine("█  ░░       ░ ░ ░ ▒    ░   ░     ░     ░░   ░   ░      ░ ░ ░ ▒  ▒ ▒ ░░  ░  ░  ░     █");
        Thread.Sleep(100);
        Console.WriteLine("█               ░ ░      ░       ░  ░   ░                  ░ ░  ░ ░           ░     █");
        Thread.Sleep(100);
        Console.WriteLine("█                                                               ░ ░                 █");
        Console.WriteLine("█████████████████████████████████████████████ made by pihta inc ███ v. 0.1 █ beta ███");
    }
    static void faststart()
    {
        Console.WriteLine("█████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("█                                                                                   █");
        Console.WriteLine("█  ██▓███   ▒█████   █     █░▓█████  ██▀███  ▄▄▄█████▓ ▒█████ ▓██   ██▓  ██████     █");
        Console.WriteLine("█  ▓██░  ██▒▒██▒  ██▒▓█░ █ ░█░▓█   ▀ ▓██ ▒ ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██  ██▒▒██    ▒    █");
        Console.WriteLine("█  ▓██░ ██▓▒▒██░  ██▒▒█░ █ ░█ ▒███   ▓██ ░▄█ ▒▒ ▓██░ ▒░▒██░  ██▒ ▒██ ██░░ ▓██▄      █");
        Console.WriteLine("█  ▒██▄█▓▒ ▒▒██   ██░░█░ █ ░█ ▒▓█  ▄ ▒██▀▀█▄  ░ ▓██▓ ░ ▒██   ██░ ░ ▐██▓░  ▒   ██▒   █");
        Console.WriteLine("█  ▒██▒ ░  ░░ ████▓▒░░░██▒██▓ ░▒████▒░██▓ ▒██▒  ▒██▒ ░ ░ ████▓▒░ ░ ██▒▓░▒██████▒▒   █");
        Console.WriteLine("█  ▒▓▒░ ░  ░░ ▒░▒░▒░ ░ ▓░▒ ▒  ░░ ▒░ ░░ ▒▓ ░▒▓░  ▒ ░░   ░ ▒░▒░▒░   ██▒▒▒ ▒ ▒▓▒ ▒ ░   █");
        Console.WriteLine("█  ░▒ ░       ░ ▒ ▒░   ▒ ░ ░   ░ ░  ░  ░▒ ░ ▒░    ░      ░ ▒ ▒░ ▓██ ░▒░ ░ ░▒  ░ ░   █");
        Console.WriteLine("█  ░░       ░ ░ ░ ▒    ░   ░     ░     ░░   ░   ░      ░ ░ ░ ▒  ▒ ▒ ░░  ░  ░  ░     █");
        Console.WriteLine("█               ░ ░      ░       ░  ░   ░                  ░ ░  ░ ░           ░     █");
        Console.WriteLine("█                                                               ░ ░                 █");
        Console.WriteLine("█████████████████████████████████████████████ made by pihta inc ███ v. 0.1 █ beta ███");
    }
    static void loading()
    {
        string text = "██████████████████████████████████████████████████████████████████████████████████████\n";
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(text[i]);
            Thread.Sleep(30);
        }
        Thread.Sleep(30);
    }
    static void guessgame()
    {
        Console.Clear();
        faststart();
        Console.WriteLine("█                                                                                   █");
        Console.WriteLine("█   ▄████  █    ██ ▓█████   ██████   ██████      ▄████  ▄▄▄       ███▄ ▄███▓▓█████  █");
        Console.WriteLine("█  ██▒ ▀█▒ ██  ▓██▒▓█   ▀ ▒██    ▒ ▒██    ▒     ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀  █");
        Console.WriteLine("█ ▒██░▄▄▄░▓██  ▒██░▒███   ░ ▓██▄   ░ ▓██▄      ▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███    █");
        Console.WriteLine("█ ░▓█  ██▓▓▓█  ░██░▒▓█  ▄   ▒   ██▒  ▒   ██▒   ░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄  █");
        Console.WriteLine("█ ░▒▓███▀▒▒▒█████▓ ░▒████▒▒██████▒▒▒██████▒▒   ░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒ █");
        Console.WriteLine("█  ░▒   ▒ ░▒▓▒ ▒ ▒ ░░ ▒░ ░▒ ▒▓▒ ▒ ░▒ ▒▓▒ ▒ ░    ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░ █");
        Console.WriteLine("█   ░   ░ ░░▒░ ░ ░  ░ ░  ░░ ░▒  ░ ░░ ░▒  ░ ░     ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░ █");
        Console.WriteLine("█ ░ ░   ░  ░░░ ░ ░    ░   ░  ░  ░  ░  ░  ░     ░ ░   ░   ░   ▒   ░      ░      ░    █");
        Console.WriteLine("█         ░          ░   ░          ░   ░   ░            ░        ░                 █");
        Console.WriteLine("██████████████You must guess the number from 1 to 100. lets start████████████████████");
        {

            Random random = new Random();

            int randomnumber = random.Next(1, 100);
            int enterednumber = 0;
            Console.WriteLine("█                                                                                   █\n█                                                                                   █");
            int cursorheight = 25;
            while (randomnumber != enterednumber)
            {
                enterednumber = Convert.ToInt32(Console.ReadLine());
                Console.SetCursorPosition(42, cursorheight);
                Console.Write(enterednumber);
                Console.WriteLine();
                if (randomnumber > enterednumber)
                {
                    if (enterednumber > 9)
                    {
                        Console.WriteLine("█            no. the number is higher than " + enterednumber + ".                                      █");
                    }
                    else
                    {
                        Console.WriteLine("█            no. the number is higher than " + enterednumber + ".                                       █");
                    }
                cursorheight += 2;
                Console.WriteLine("█                                                                                   █");
                }
                else if (randomnumber < enterednumber)
                {
                    if (enterednumber > 9)
                    {
                        Console.WriteLine("█            no. the number is lower than " + enterednumber + ".                                       █");
                    }
                    else
                    {
                        Console.WriteLine("█            no. the number is lower than " + enterednumber + ".                                        █");
                    }
                cursorheight += 2;
                Console.WriteLine("█                                                                                   █");
                }
            }
            Console.WriteLine("█                            Well done! The answer was " + enterednumber +"                        █");
            Console.WriteLine("█                                                                                   █");
            Console.WriteLine("█████████████████████████████████████████████████████████████████████████████████████");
            Console.ReadLine();
            Console.Clear();
            congratulations();
            congratulations();
            congratulations();
            congratulations();
            Console.Clear();
            faststart();
            Programs();
        }
    }
    public static void multiplytable()
    {
        Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
        Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
        Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
        Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
        Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
        Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
        Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
        Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
        Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
        Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
        Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
        Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
        Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
        Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
        Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
        Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
        Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
        Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
        Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
        Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
        Console.WriteLine("█████████████████████████████████████████████████████████████████████████████████████");
        int cursorheight = 25;
        int cursorwidth = 20;
        Console.SetCursorPosition(cursorwidth, cursorheight);
        int[,] multiplytable = new int[10, 10];
        for (int i = 1; i <= multiplytable.GetLength(0); i++)
        {
            Console.SetCursorPosition(cursorwidth, cursorheight);
            for (int a = 1; a <= multiplytable.GetLength(1); a++)
            {
                multiplytable[i - 1, a - 1] = i * a;
                
                Console.Write($"{multiplytable[i - 1, a - 1],3} ");
                Thread.Sleep(20);
            }
            cursorheight += 2;
            Console.WriteLine();
            
        }
        string logoauthor = "█press any button to exit to menu...";
        for (int i = 0; i < 36; i++)
        {
            Console.Write(logoauthor[i]);
            Thread.Sleep(30);
        }
        Thread.Sleep(30);
        Console.ReadKey();
        Console.Clear();
        faststart();
        Programs();
    }
    static void dividers()
    {
        Console.Clear();
        faststart();
        Console.WriteLine("█                                                                                   █");
        Console.WriteLine("█                 ▓█████▄  ██▓ ██▒   █▓ ██▓▓█████▄ ▓█████  ██▀███                   █");
        Console.WriteLine("█                 ▒██▀ ██▌▓██▒▓██░   █▒▓██▒▒██▀ ██▌▓█   ▀ ▓██ ▒ ██▒                 █");
        Console.WriteLine("█                 ░██   █▌▒██▒ ▓██  █▒░▒██▒░██   █▌▒███   ▓██ ░▄█ ▒                 █");
        Console.WriteLine("█                 ░▓█▄   ▌░██░  ▒██ █░░░██░░▓█▄   ▌▒▓█  ▄ ▒██▀▀█▄                   █");
        Console.WriteLine("█                 ░▒████▓ ░██░   ▒▀█░  ░██░░▒████▓ ░▒████▒░██▓ ▒██▒                 █");
        Console.WriteLine("█                  ▒▒▓  ▒ ░▓     ░ ▐░  ░▓   ▒▒▓  ▒ ░░ ▒░ ░░ ▒▓ ░▒▓░                 █");
        Console.WriteLine("█                  ░ ▒  ▒  ▒ ░   ░ ░░   ▒ ░ ░ ▒  ▒  ░ ░  ░  ░▒ ░ ▒░                 █");
        Console.WriteLine("█                  ░ ░  ░  ▒ ░     ░░   ▒ ░ ░ ░  ░    ░     ░░   ░                  █");
        Console.WriteLine("█                    ░     ░        ░   ░     ░       ░  ░   ░                      █");
        Console.WriteLine("█                                   ░               ░        ░                      █");
        Console.WriteLine("█████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
        int cursorwidth = 1;
        Console.SetCursorPosition(cursorwidth, 25);
        string text = "enter the number to see all dividers of that ";
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(text[i]);
            Thread.Sleep(30);
            cursorwidth += 1;
            Console.SetCursorPosition(cursorwidth, 25);
        }
        Console.SetCursorPosition(1, 26);
        Thread.Sleep(30);
        int enterednumber = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        static string dividertext(int num)
        {
            string restext = "";
            for (int i = 1; i <= num; i++)
                if (num % i == 0)
                    restext += i + " ";
            return restext;
        }
        Console.WriteLine(dividertext(enterednumber));
        Console.WriteLine("press any button to exit to menu... ");
        Console.ReadKey();
        Console.Clear();
        faststart();
        Programs();
    }
    static void congratulations()
    {
        faststart();
        Console.WriteLine("█                                                                                   █");
        Console.WriteLine("█   ▄████  █    ██ ▓█████   ██████   ██████      ▄████  ▄▄▄       ███▄ ▄███▓▓█████  █");
        Console.WriteLine("█  ██▒ ▀█▒ ██  ▓██▒▓█   ▀ ▒██    ▒ ▒██    ▒     ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀  █");
        Console.WriteLine("█ ▒██░▄▄▄░▓██  ▒██░▒███   ░ ▓██▄   ░ ▓██▄      ▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███    █");
        Console.WriteLine("█ ░▓█  ██▓▓▓█  ░██░▒▓█  ▄   ▒   ██▒  ▒   ██▒   ░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄  █");
        Console.WriteLine("█ ░▒▓███▀▒▒▒█████▓ ░▒████▒▒██████▒▒▒██████▒▒   ░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒ █");
        Console.WriteLine("█  ░▒   ▒ ░▒▓▒ ▒ ▒ ░░ ▒░ ░▒ ▒▓▒ ▒ ░▒ ▒▓▒ ▒ ░    ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░ █");
        Console.WriteLine("█   ░   ░ ░░▒░ ░ ░  ░ ░  ░░ ░▒  ░ ░░ ░▒  ░ ░     ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░ █");
        Console.WriteLine("█ ░ ░   ░  ░░░ ░ ░    ░   ░  ░  ░  ░  ░  ░     ░ ░   ░   ░   ▒   ░      ░      ░    █");
        Console.WriteLine("█         ░          ░   ░          ░   ░   ░            ░        ░                 █");
        Console.WriteLine("█████████████████████████████████████████████████████████████████████████████████████");
        Thread.Sleep(500);
        Console.Clear();
        faststart();
        Console.WriteLine("█                                                                                   █");
        Console.WriteLine("█   *                                                            *                  █");
        Console.WriteLine("█                        *                               *                *         █");
        Console.WriteLine("█                                                                *                  █");
        Console.WriteLine("█     *                 *         *             *                             *     █");
        Console.WriteLine("█                 *                                       *                         █");
        Console.WriteLine("█                                      *                                   *        █");
        Console.WriteLine("█          *                                                                        █");
        Console.WriteLine("█                            *                       *                *             █");
        Console.WriteLine("█                                                                                   █");
        Console.WriteLine("█████████████████████████████████████████████████████████████████████████████████████");
        Thread.Sleep(500);
        Console.Clear();
    }
}

