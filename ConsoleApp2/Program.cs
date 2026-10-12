using System;
class Program
{
    static void Main()
    {

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\t\t\t\t\t\t====================");
        Console.WriteLine("\t\t\t\t\t       Shapeshifter Video Game");
        Console.WriteLine("\t\t\t\t\t\t====================\n");
        Console.ResetColor();
        Console.Write("Do you want to see The Rules of The Game ? (yes=4 or no=5)   ");
        string decision = Console.ReadLine();
        int yes = 4;
        int no = 5;
        if (decision == "4")
        {
            Console.WriteLine("1. The game is played on a 3*3 board. ");
            Console.WriteLine("                                               ");
            Console.WriteLine("2. The player is Human or Computer. ");
            Console.WriteLine("                                               ");
            Console.WriteLine("3. Game elements/symbols are A, B, C, D and E letters. ");
            Console.WriteLine("                                               ");
            Console.WriteLine("4. The aim of the game is to construct a 3*3 target board of letters and gain the highest game score. Player uses thr shift operations to obtain target board. A shift operation shifts all the symbols in the row/column until they reach a symbol or border. ");
            Console.WriteLine("                                               ");
            Console.WriteLine("5. NOTOS: Number of Types of Symbols");
            Console.WriteLine("                                               ");
            Console.WriteLine("6. NOS: Number of Symbols");
            Console.WriteLine("                                               ");
            Console.WriteLine("7. Board score is calculated according to the placed symbols (the right symbol at the right position). ");
            Console.WriteLine("                                               ");
            Console.WriteLine("Symbols have a value: A:1, B:2, C:3, D:4, E:5");
            Console.WriteLine("                                               ");
            Console.WriteLine("Also board positions have factors.");

            int v1 = 1;
            int v2 = 2;
            int v3 = 1;
            int v4 = 2;
            int v5 = 4;
            int v6 = 2;
            int v7 = 1;
            int v8 = 2;
            int v9 = 1;

            Console.WriteLine("                                               ");
            Console.WriteLine("+-------+");
            Console.WriteLine("| " + v1 + " " + v2 + " " + v3 + " |");
            Console.WriteLine("| " + v4 + " " + v5 + " " + v6 + " |");
            Console.WriteLine("| " + v7 + " " + v8 + " " + v9 + " |");
            Console.WriteLine("+-------+");
            Console.WriteLine("                                               ");
            Console.WriteLine(" PlacedSymbolScore = SymbolValue * PositionFactor ");
            Console.WriteLine("                                               ");
            Console.WriteLine("BoardScore = Sum of PlacedSymbolScores ");
            Console.WriteLine("                                               ");
            Console.WriteLine("GameScore = (10 * BoardScore) + (NOTOS * NOS * (BoardGenerationShifts - ActualNumOfShifts))");
            Console.WriteLine("                                               ");
            Console.WriteLine("Now you can go on ");
        }
        else if (decision == "5")
        {
            Console.WriteLine("You can go on");
        }
        else if (decision != "4" || decision != "5")
        {
            Console.WriteLine("Invalid input. You have caused and error!");
            return;
        }



        Console.Write("Computer,Player or Want to exit?(1 or 2 or 0): ");
        int input = Convert.ToInt32(Console.ReadLine());

        if (input == 0)
        {
            Console.WriteLine("You have left the game!");
            return;
        }
        if (input == 1 || input == 2)
        {
            Console.WriteLine("You are continuing the game.");
        }
        if (input != 1 && input != 2 && input != 0)
        {
            Console.WriteLine("Invalid input. You have caused and error!");
            return;
        }
        Console.Write("How many characters do you want to enter?: ");
        int adet = Convert.ToInt32(Console.ReadLine());
        if (adet >= 1 && adet <= 6)
        {
            Console.WriteLine("Valid input. You can go on.");
        }
        else
        {
            Console.WriteLine("Invalid input. We do not have enough characters...");
            return;
        }
        Console.Write("How many shifts do you want?(default=15): ");
        int shiftNumber = Convert.ToInt16(Console.ReadLine());


        Console.Write("How many types of characters do you want to enter?:");
        int numberTypes = Convert.ToInt16(Console.ReadLine());
        if (numberTypes >= 1 && numberTypes <=6 )
        {
            Console.WriteLine("Valid input. You can go on.");
        }
        else
        {
            Console.WriteLine("Invalid input. We do not have enough characters...");
            return;
        }



        // 2. TAHTA VE DEĞİŞKEN TANIMLARI

        Random rand = new Random();
        int kutuSecim, secim;


        char h1 = ' ', h2 = ' ', h3 = ' ', h4 = ' ', h5 = ' ', h6 = ' ';


        char t1 = ' ', t2 = ' ', t3 = ' ';
        char t4 = ' ', t5 = ' ', t6 = ' ';
        char t7 = ' ', t8 = ' ', t9 = ' ';


        char c1 = ' ', c2 = ' ', c3 = ' ';
        char c4 = ' ', c5 = ' ', c6 = ' ';
        char c7 = ' ', c8 = ' ', c9 = ' ';


        // 3. ORTAK TAŞLARI BELİRLEME 

        if (adet >= 1)
        {
            secim = rand.Next(1, numberTypes + 1);
            switch (secim)
            {
                case 1:
                    h1 = 'A';
                    break;
                case 2:
                    h1 = 'B';
                    break;
                case 3:
                    h1 = 'C';
                    break;
                case 4:
                    h1 = 'D';
                    break;
                case 5:
                    h1 = 'E';
                    break;
            }
        }
        if (adet >= 2)
        {
            secim = rand.Next(1, numberTypes + 1);
            switch (secim)
            {
                case 1:
                    h2 = 'A';
                    break;
                case 2:
                    h2 = 'B';
                    break;
                case 3:
                    h2 = 'C';
                    break;
                case 4:
                    h2 = 'D';
                    break;
                case 5:
                    h2 = 'E';
                    break;
            }
        }
        if (adet >= 3)
        {
            secim = rand.Next(1, numberTypes + 1);
            switch (secim)
            {
                case 1:
                    h3 = 'A';
                    break;
                case 2:
                    h3 = 'B';
                    break;
                case 3:
                    h3 = 'C';
                    break;
                case 4:
                    h3 = 'D';
                    break;
                case 5:
                    h3 = 'E';
                    break;
            }
        }
        if (adet >= 4)
        {
            secim = rand.Next(1, numberTypes + 1);
            switch (secim)
            {
                case 1:
                    h4 = 'A';
                    break;
                case 2:
                    h4 = 'B';
                    break;
                case 3:
                    h4 = 'C';
                    break;
                case 4:
                    h4 = 'D';
                    break;
                case 5:
                    h4 = 'E';
                    break;
            }
        }
        if (adet >= 5)
        {
            secim = rand.Next(1, numberTypes + 1);
            switch (secim)
            {
                case 1:
                    h5 = 'A';
                    break;
                case 2:
                    h5 = 'B';
                    break;
                case 3:
                    h5 = 'C';
                    break;
                case 4:
                    h5 = 'D';
                    break;
                case 5:
                    h5 = 'E';
                    break;
            }
        }
        if (adet == 6)
        {
            secim = rand.Next(1, numberTypes + 1);
            switch (secim)
            {
                case 1:
                    h6 = 'A';
                    break;
                case 2:
                    h6 = 'B';
                    break;
                case 3:
                    h6 = 'C';
                    break;
                case 4:
                    h6 = 'D';
                    break;
                case 5:
                    h6 = 'E';
                    break;
            }
        }


        //HEDEF TAHTA KISMI

        if (adet >= 1)
        {
            kutuSecim = rand.Next(1, 10);
            switch (kutuSecim)
            {
                case 1:
                    t1 = h1;
                    break;
                case 2:
                    t2 = h1;
                    break;
                case 3:
                    t3 = h1;
                    break;
                case 4:
                    t4 = h1;
                    break;
                case 5:
                    t5 = h1;
                    break;
                case 6:
                    t6 = h1;
                    break;
                case 7:
                    t7 = h1;
                    break;
                case 8:
                    t8 = h1;
                    break;
                case 9:
                    t9 = h1;
                    break;
            }
        }
        if (adet >= 2)
        {
            kutuSecim = rand.Next(1, 10);
            switch (kutuSecim)
            {
                case 1:
                    if (t1 == ' ') t1 = h2;
                    else t2 = h2;
                    break;
                case 2:
                    if (t2 == ' ') t2 = h2;
                    else t3 = h2;
                    break;
                case 3:
                    if (t3 == ' ') t3 = h2;
                    else t4 = h2;
                    break;
                case 4:
                    if (t4 == ' ') t4 = h2;
                    else t5 = h2;
                    break;
                case 5:
                    if (t5 == ' ') t5 = h2;
                    else t6 = h2;
                    break;
                case 6:
                    if (t6 == ' ') t6 = h2;
                    else t7 = h2;
                    break;
                case 7:
                    if (t7 == ' ') t7 = h2;
                    else t8 = h2;
                    break;
                case 8:
                    if (t8 == ' ') t8 = h2;
                    else t9 = h2;
                    break;
                case 9:
                    if (t9 == ' ') t9 = h2;
                    else t1 = h2;
                    break;
            }
        }
        if (adet >= 3)
        {
            kutuSecim = rand.Next(1, 10);
            switch (kutuSecim)
            {
                case 1:
                    if (t1 == ' ') t1 = h3;

                    else t3 = h3;
                    break;
                case 2:
                    if (t2 == ' ') t2 = h3;

                    else t4 = h3;
                    break;
                case 3:
                    if (t3 == ' ') t3 = h3;

                    else t5 = h3;
                    break;
                case 4:
                    if (t4 == ' ') t4 = h3;

                    else t6 = h3;
                    break;
                case 5:
                    if (t5 == ' ') t5 = h3;

                    else t7 = h3;
                    break;
                case 6:
                    if (t6 == ' ') t6 = h3;

                    else t8 = h3;
                    break;
                case 7:
                    if (t7 == ' ') t7 = h3;

                    else t9 = h3;
                    break;
                case 8:
                    if (t8 == ' ') t8 = h3;

                    else t1 = h3;
                    break;
                case 9:
                    if (t9 == ' ') t9 = h3;

                    else t2 = h3;
                    break;
            }
        }
        if (adet >= 4)
        {
            kutuSecim = rand.Next(1, 10);
            switch (kutuSecim)
            {
                case 1:
                    if (t1 == ' ') t1 = h4;
                    else t4 = h4;
                    break;
                case 2:
                    if (t2 == ' ') t2 = h4;
                    else t5 = h4;
                    break;
                case 3:
                    if (t3 == ' ') t3 = h4;
                    else t6 = h4;
                    break;
                case 4:
                    if (t4 == ' ') t4 = h4;
                    else t7 = h4;
                    break;
                case 5:
                    if (t5 == ' ') t5 = h4;
                    else t8 = h4;
                    break;
                case 6:
                    if (t6 == ' ') t6 = h4;
                    else t9 = h4;
                    break;
                case 7:
                    if (t7 == ' ') t7 = h4;
                    else t1 = h4;
                    break;
                case 8:
                    if (t8 == ' ') t8 = h4;
                    else t2 = h4;
                    break;
                case 9:
                    if (t9 == ' ') t9 = h4;
                    else t3 = h4;
                    break;
            }
        }
        if (adet >= 5)
        {
            kutuSecim = rand.Next(1, 10);
            switch (kutuSecim)
            {
                case 1:
                    if (t1 == ' ') t1 = h5;
                    else t5 = h5;
                    break;

                case 2:
                    if (t2 == ' ') t2 = h5;
                    else t6 = h5;
                    break;
                case 3:
                    if (t3 == ' ') t3 = h5;
                    else t7 = h5;
                    break;
                case 4:
                    if (t4 == ' ') t4 = h5;
                    else t8 = h5;
                    break;
                case 5:
                    if (t5 == ' ') t5 = h5;
                    else t9 = h5;
                    break;
                case 6:
                    if (t6 == ' ') t6 = h5;
                    else t1 = h5;
                    break;
                case 7:
                    if (t7 == ' ') t7 = h5;
                    else t2 = h5;
                    break;
                case 8:
                    if (t8 == ' ') t8 = h5;
                    else t3 = h5;
                    break;
                case 9:
                    if (t9 == ' ') t9 = h5;
                    else t4 = h5;
                    break;
            }
        }
        if (adet == 6)
        {
            kutuSecim = rand.Next(1, 10);
            switch (kutuSecim)
            {
                case 1:
                    if (t1 == ' ') t1 = h6;
                    else t6 = h6;
                    break;
                case 2:
                    if (t2 == ' ') t2 = h6;
                    else t7 = h6;
                    break;
                case 3:
                    if (t3 == ' ') t3 = h6;
                    else t8 = h6;
                    break;
                case 4:
                    if (t4 == ' ') t4 = h6;
                    else t9 = h6;
                    break;
                case 5:
                    if (t5 == ' ') t5 = h6;
                    else t1 = h6;
                    break;
                case 6:
                    if (t6 == ' ') t6 = h6;
                    else t2 = h6;
                    break;
                case 7:
                    if (t7 == ' ') t7 = h6;
                    else t3 = h6;
                    break;
                case 8:
                    if (t8 == ' ') t8 = h6;
                    else t4 = h6;
                    break;
                case 9:
                    if (t9 == ' ') t9 = h6;
                    else t5 = h6;
                    break;
            }
        }


        // 5. OYUN TAHTASINA AYNI TAŞLARI FARKLI DAĞITMA

        if (adet >= 1)
        {
            kutuSecim = rand.Next(1, 10);
            switch (kutuSecim)
            {
                case 1:
                    c1 = h1;
                    break;
                case 2:
                    c2 = h1;
                    break;
                case 3:
                    c3 = h1;
                    break;
                case 4:
                    c4 = h1;
                    break;
                case 5:
                    c5 = h1;
                    break;
                case 6:
                    c6 = h1;
                    break;
                case 7:
                    c7 = h1;
                    break;
                case 8:
                    c8 = h1;
                    break;
                case 9:
                    c9 = h1;
                    break;
            }
        }
        if (adet >= 2)
        {
            kutuSecim = rand.Next(1, 10);
            switch (kutuSecim)
            {
                case 1:
                    if (c1 == ' ') c1 = h2;
                    else c2 = h2;
                    break;
                case 2:
                    if (c2 == ' ') c2 = h2;
                    else c3 = h2;
                    break;
                case 3:
                    if (c3 == ' ') c3 = h2;
                    else c4 = h2;
                    break;
                case 4:
                    if (c4 == ' ') c4 = h2;
                    else c5 = h2;
                    break;
                case 5:
                    if (c5 == ' ') c5 = h2;
                    else c6 = h2;
                    break;
                case 6:
                    if (c6 == ' ') c6 = h2;
                    else c7 = h2;
                    break;
                case 7:
                    if (c7 == ' ') c7 = h2;
                    else c8 = h2;
                    break;
                case 8:
                    if (c8 == ' ') c8 = h2;
                    else c9 = h2;
                    break;
                case 9:
                    if (c9 == ' ') c9 = h2;
                    else c1 = h2;
                    break;
            }
        }
        if (adet >= 3)
        {
            kutuSecim = rand.Next(1, 10);
            switch (kutuSecim)
            {
                case 1:
                    if (c1 == ' ') c1 = h3;
                    else c3 = h3;
                    break;
                case 2:
                    if (c2 == ' ') c2 = h3;
                    else c4 = h3;
                    break;
                case 3:
                    if (c3 == ' ') c3 = h3;
                    else c5 = h3;
                    break;
                case 4:
                    if (c4 == ' ') c4 = h3;
                    else c6 = h3;
                    break;
                case 5:
                    if (c5 == ' ') c5 = h3;
                    else c7 = h3;
                    break;
                case 6:
                    if (c6 == ' ') c6 = h3;
                    else c8 = h3;
                    break;
                case 7:
                    if (c7 == ' ') c7 = h3;
                    else c9 = h3;
                    break;
                case 8:
                    if (c8 == ' ') c8 = h3;
                    else c1 = h3;
                    break;
                case 9:
                    if (c9 == ' ') c9 = h3;
                    else c2 = h3;
                    break;
            }
        }
        if (adet >= 4)
        {
            kutuSecim = rand.Next(1, 10);
            switch (kutuSecim)
            {
                case 1:
                    if (c1 == ' ') c1 = h4;
                    else c4 = h4;
                    break;
                case 2:
                    if (c2 == ' ') c2 = h4;
                    else c5 = h4;
                    break;
                case 3:
                    if (c3 == ' ') c3 = h4;
                    else c6 = h4;
                    break;
                case 4:
                    if (c4 == ' ') c4 = h4;
                    else c7 = h4;
                    break;
                case 5:
                    if (c5 == ' ') c5 = h4;
                    else c8 = h4;
                    break;
                case 6:
                    if (c6 == ' ') c6 = h4;
                    else c9 = h4;
                    break;
                case 7:
                    if (c7 == ' ') c7 = h4;
                    else c1 = h4;
                    break;
                case 8:
                    if (c8 == ' ') c8 = h4;
                    else c2 = h4;
                    break;
                case 9:
                    if (c9 == ' ') c9 = h4;
                    else c3 = h4;
                    break;
            }
        }
        if (adet >= 5)
        {
            kutuSecim = rand.Next(1, 10);
            switch (kutuSecim)
            {
                case 1:
                    if (c1 == ' ') c1 = h5;
                    else c5 = h5;
                    break;
                case 2:
                    if (c2 == ' ') c2 = h5;
                    else c6 = h5;
                    break;
                case 3:
                    if (c3 == ' ') c3 = h5;
                    else c7 = h5;
                    break;
                case 4:
                    if (c4 == ' ') c4 = h5;
                    else c8 = h5;
                    break;
                case 5:
                    if (c5 == ' ') c5 = h5;
                    else c9 = h5;
                    break;
                case 6:
                    if (c6 == ' ') c6 = h5;
                    else c1 = h5;
                    break;
                case 7:
                    if (c7 == ' ') c7 = h5;
                    else c2 = h5;
                    break;
                case 8:
                    if (c8 == ' ') c8 = h5;
                    else c3 = h5;
                    break;
                case 9:
                    if (c9 == ' ') c9 = h5;
                    else c4 = h5;
                    break;
            }
        }
        if (adet == 6)
        {
            kutuSecim = rand.Next(1, 10);
            switch (kutuSecim)
            {
                case 1:
                    if (c1 == ' ') c1 = h6;
                    else c6 = h6;
                    break;
                case 2:
                    if (c2 == ' ') c2 = h6;
                    else c7 = h6;
                    break;
                case 3:
                    if (c3 == ' ') c3 = h6;
                    else c8 = h6;
                    break;
                case 4:
                    if (c4 == ' ') c4 = h6;
                    else c9 = h6;
                    break;
                case 5:
                    if (c5 == ' ') c5 = h6;
                    else c1 = h6;
                    break;
                case 6:
                    if (c6 == ' ') c6 = h6;
                    else c2 = h6;
                    break;
                case 7:
                    if (c7 == ' ') c7 = h6;
                    else c3 = h6;
                    break;
                case 8:
                    if (c8 == ' ') c8 = h6;
                    else c4 = h6;
                    break;
                case 9:
                    if (c9 == ' ') c9 = h6;
                    else c5 = h6;
                    break;
            }
        }


        // 6. EKRAN ÇIKTILARI 

        Console.WriteLine("\nGame Mode");
        if (input == 1) Console.WriteLine("Player : Human");
        else Console.WriteLine("Player : Computer");

        Console.Write("Symbols : ");
        if (numberTypes == 1) Console.WriteLine("A");
        else if (numberTypes == 2) Console.WriteLine("A,B");
        else if (numberTypes == 3) Console.WriteLine("A,B,C");
        else if (numberTypes == 4) Console.WriteLine("A,B,C,D");
        else if (numberTypes == 5) Console.WriteLine("A,B,C,D,E");

        Console.WriteLine("Number of Symbols : " + adet);
        Console.WriteLine("Number of Shifts  : " + shiftNumber);

        // Hedef Tahta 
        Console.WriteLine("\n--- Target Board ---");
        Console.WriteLine("+-------+");
        Console.WriteLine("| " + t1 + " " + t2 + " " + t3 + " |");
        Console.WriteLine("| " + t4 + " " + t5 + " " + t6 + " |");
        Console.WriteLine("| " + t7 + " " + t8 + " " + t9 + " |");
        Console.WriteLine("+-------+");

        // Oyun Başlangıcı 
        int round = 1;
        int boardScore = 0;

        Console.WriteLine("\n--- Round " + round + " ---");
        Console.WriteLine("    7 8 9");
        Console.WriteLine("  +-------+    Board");
        Console.WriteLine("1 | " + c1 + " " + c2 + " " + c3 + " | 4  Score : " + boardScore);
        Console.WriteLine("2 | " + c4 + " " + c5 + " " + c6 + " | 5");
        Console.WriteLine("3 | " + c7 + " " + c8 + " " + c9 + " | 6");
        Console.WriteLine("  +-------+");
        Console.WriteLine("   10 11 12");











        Console.Write("Hamle numarasını giriniz (1-12): ");
        int hamle = Convert.ToInt32(Console.ReadLine());


        switch (hamle)
        {
            // 1. SATIR SAĞA KAYDIRMA
            case 1:

                if (c3 == ' ')
                {

                    if (c2 != ' ')
                    {
                        c3 = c2;
                        c2 = c1;
                        c1 = ' ';
                    }

                    else if (c1 != ' ')
                    {
                        c3 = c1;
                        c1 = ' ';
                    }
                }

                else if (c2 == ' ')
                {

                    if (c1 != ' ')
                    {
                        c2 = c1;
                        c1 = ' ';
                    }
                }

                break;


            // 2. SATIR SAĞA KAYDIRMA 

            case 2:
                if (c6 == ' ')
                {
                    if (c5 != ' ')
                    {
                        c6 = c5;
                        c5 = c4;
                        c4 = ' ';
                    }
                    else if (c4 != ' ')
                    {
                        c6 = c4;
                        c4 = ' ';
                    }
                }
                else if (c5 == ' ')
                {
                    if (c4 != ' ')
                    {
                        c5 = c4;
                        c4 = ' ';
                    }
                }
                break;


            // 3. SATIR SAĞA KAYDIRMA 

            case 3:
                if (c9 == ' ')
                {
                    if (c8 != ' ')
                    {
                        c9 = c8;
                        c8 = c7;
                        c7 = ' ';
                    }
                    else if (c7 != ' ')
                    {
                        c9 = c7;
                        c7 = ' ';
                    }
                }
                else if (c8 == ' ')
                {
                    if (c7 != ' ')
                    {
                        c8 = c7;
                        c7 = ' ';
                    }
                }
                break;


            // 1. SATIR SOLA KAYDIRMA 

            case 4:

                if (c1 == ' ')
                {

                    if (c2 != ' ')
                    {
                        c1 = c2;
                        c2 = c3;
                        c3 = ' ';
                    }

                    else if (c3 != ' ')
                    {
                        c1 = c3;
                        c3 = ' ';
                    }
                }

                else if (c2 == ' ')
                {

                    if (c3 != ' ')
                    {
                        c2 = c3;
                        c3 = ' ';
                    }
                }
                break;


            // 2. SATIR SOLA KAYDIRMA 

            case 5:
                if (c4 == ' ')
                {
                    if (c5 != ' ')
                    {
                        c4 = c5;
                        c5 = c6;
                        c6 = ' ';
                    }
                    else if (c6 != ' ')
                    {
                        c4 = c6;
                        c6 = ' ';
                    }
                }
                else if (c5 == ' ')
                {
                    if (c6 != ' ')
                    {
                        c5 = c6;
                        c6 = ' ';
                    }
                }
                break;


            // 3. SATIR SOLA KAYDIRMA 

            case 6:
                if (c7 == ' ')
                {
                    if (c8 != ' ')
                    {
                        c7 = c8;
                        c8 = c9;
                        c9 = ' ';
                    }
                    else if (c9 != ' ')
                    {
                        c7 = c9;
                        c9 = ' ';
                    }
                }
                else if (c8 == ' ')
                {
                    if (c9 != ' ')
                    {
                        c8 = c9;
                        c9 = ' ';
                    }
                }
                break;


            // 1. SÜTUN AŞAĞI KAYDIRMA 

            case 7:

                if (c7 == ' ')
                {

                    if (c4 != ' ')
                    {
                        c7 = c4;
                        c4 = c1;
                        c1 = ' ';
                    }

                    else if (c1 != ' ')
                    {
                        c7 = c1;
                        c1 = ' ';
                    }
                }

                else if (c4 == ' ')
                {

                    if (c1 != ' ')
                    {
                        c4 = c1;
                        c1 = ' ';
                    }
                }
                break;


            // 2. SÜTUN AŞAĞI KAYDIRMA 

            case 8:
                if (c8 == ' ')
                {
                    if (c5 != ' ')
                    {
                        c8 = c5;
                        c5 = c2;
                        c2 = ' ';
                    }
                    else if (c2 != ' ')
                    {
                        c8 = c2;
                        c2 = ' ';
                    }
                }
                else if (c5 == ' ')
                {
                    if (c2 != ' ')
                    {
                        c5 = c2;
                        c2 = ' ';
                    }
                }
                break;


            // 3. SÜTUN AŞAĞI KAYDIRMA 

            case 9:
                if (c9 == ' ')
                {
                    if (c6 != ' ')
                    {
                        c9 = c6;
                        c6 = c3;
                        c3 = ' ';
                    }
                    else if (c3 != ' ')
                    {
                        c9 = c3;
                        c3 = ' ';
                    }
                }
                else if (c6 == ' ')
                {
                    if (c3 != ' ')
                    {
                        c6 = c3;
                        c3 = ' ';
                    }
                }
                break;


            // 1. SÜTUN YUKARI KAYDIRMA 

            case 10:

                if (c1 == ' ')
                {

                    if (c4 != ' ')
                    {
                        c1 = c4;
                        c4 = c7;
                        c7 = ' ';
                    }

                    else if (c7 != ' ')
                    {
                        c1 = c7;
                        c7 = ' ';
                    }
                }

                else if (c4 == ' ')
                {

                    if (c7 != ' ')
                    {
                        c4 = c7;
                        c7 = ' ';
                    }
                }
                break;


            // 2. SÜTUN YUKARI KAYDIRMA 

            case 11:
                if (c2 == ' ')
                {
                    if (c5 != ' ')
                    {
                        c2 = c5;
                        c5 = c8;
                        c8 = ' ';
                    }
                    else if (c8 != ' ')
                    {
                        c2 = c8;
                        c8 = ' ';
                    }
                }
                else if (c5 == ' ')
                {
                    if (c8 != ' ')
                    {
                        c5 = c8;
                        c8 = ' ';
                    }
                }
                break;


            // 3. SÜTUN YUKARI KAYDIRMA 

            case 12:
                if (c3 == ' ')
                {
                    if (c6 != ' ')
                    {
                        c3 = c6;
                        c6 = c9;
                        c9 = ' ';
                    }
                    else if (c9 != ' ')
                    {
                        c3 = c9;
                        c9 = ' ';
                    }
                }
                else if (c6 == ' ')
                {
                    if (c9 != ' ')
                    {
                        c6 = c9;
                        c9 = ' ';
                    }
                }
                break;

            default:
                Console.WriteLine("Geçersiz hamle numarası! Lütfen 1 ile 12 arasında bir değer giriniz.");
                break;
        }

        // Hamle yapıldıktan sonra güncel tahtayı ekrana basma
        Console.WriteLine("\n--- Updated Board ---");
        Console.WriteLine("    7 8 9");
        Console.WriteLine("  +-------+");
        Console.WriteLine("1 | " + c1 + " " + c2 + " " + c3 + " | 4");
        Console.WriteLine("2 | " + c4 + " " + c5 + " " + c6 + " | 5");
        Console.WriteLine("3 | " + c7 + " " + c8 + " " + c9 + " | 6");
        Console.WriteLine("  +-------+");
        Console.WriteLine("   10 11 12");

        Console.ReadLine();


    }

}
