using System;

namespace arch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("  ::::::::::: ::::    ::: ::::::::::: :::::::::: :::                     ::::::::   :::::::   ::::::::   ::::::::  ");
            Console.WriteLine("      :+:     :+:+:   :+:     :+:     :+:        :+:                    :+:    :+: :+:   :+: :+:    :+: :+:    :+: ");
            Console.WriteLine("      +:+     :+:+:+  +:+     +:+     +:+        +:+                    +:+    +:+ +:+  :+:+ +:+    +:+ +:+        ");
            Console.WriteLine("      +#+     +#+ +:+ +#+     +#+     +#++:++#   +#+                     +#++:++#  +#+ + +:+  +#++:++#  +#++:++#+  ");
            Console.WriteLine("      +#+     +#+  +#+#+#     +#+     +#+        +#+                    +#+    +#+ +#+#  +#+ +#+    +#+ +#+    +#+ ");
            Console.WriteLine("      #+#     #+#   #+#+#     #+#     #+#        #+#                    #+#    #+# #+#   #+# #+#    #+# #+#    #+# ");
            Console.WriteLine("  ########### ###    ####     ###     ########## ##########              ########   #######   ########   ########  ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------Uzupełnij stan rejestrów---------------------------------------------");
            Console.WriteLine(); 
            Console.ForegroundColor = ConsoleColor.White;


            Console.Write("AX: ");

            int countError = 0;
            int minusError = 0;
            int AX = int.Parse(Console.ReadLine()); 
            if(AX > 65536 )
            {
                AX= 65536;
                countError++;
            }
            if(AX<0)
            {
                AX = 0;
                minusError++;
            }


            Console.Write("BX: ");
            int BX = int.Parse(Console.ReadLine());
            if (BX > 65536)
            {
                BX = 65536;
                countError++;
            }
            if (BX < 0)
            {
                BX = 0;
                minusError++;
            }

            Console.Write("CX: ");
            int CX = int.Parse(Console.ReadLine());
            if (CX > 65536)
            {
                CX = 65536;
                countError++;
            }
            if (CX < 0)
            {
                CX = 0;
                minusError++;
            }


            Console.Write("DX: ");
            int DX = int.Parse(Console.ReadLine());
            if (DX > 65536)
            {
                DX = 65536;
                countError++;
            }
            if (DX < 0)
            {
                DX = 0;
                minusError++;
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("----------------------- STAN REJESTÓW -----------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" AX: {AX}\n BX: {BX}\n CX: {CX}\n DX: {DX}\n");
            if(countError > 0 || minusError>0)
            {
                Console.WriteLine("UWAGA");
            }
            if(countError > 0)
            {
                Console.WriteLine("Conajmniej jeden z podanych rejestrów został zmieniony \nPowód: liczba większa od 16 bit");
            }
            if (minusError > 0)
            {
                Console.WriteLine("Conajmniej jeden z podanych rejestrów został zmieniony \nPowód: liczba mniejsza od 0");
            }
        start:
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("--------------------- WYBIERZ OPERACJĘ ----------------------");
            Console.WriteLine("                    [wpisz MOV lub XCHG]                     ");
            Console.ForegroundColor = ConsoleColor.White;
           

            string co = Console.ReadLine();
            Console.WriteLine();
            
            if (co == "MOV" || co=="mov")
            {
                while (true)
                {
                    Console.WriteLine("Podaj pierwszy rejestr rozkazu MOV [AX/BX/CX/DX]: ");
                    string pierwszy = Console.ReadLine();
                    Console.WriteLine("Podaj drugi rejestr rozkazu MOV [AX/BX/CX/DX]: ");
                    string drugi = Console.ReadLine();
                    Console.WriteLine();

                    if (pierwszy == "AX" && drugi == "AX")
                    {
                        AX = AX;
                    }
                    else if (pierwszy == "AX" && drugi == "BX")
                    {
                        AX = BX;
                    }
                    else if (pierwszy == "AX" && drugi == "CX")
                    {
                        AX = CX;
                    }
                    else if (pierwszy == "AX" && drugi == "DX")
                    {
                        AX = DX;
                    }
                    else if (pierwszy == "BX" && drugi == "AX")
                    {
                        BX = AX;
                    }
                    else if (pierwszy == "BX" && drugi == "BX")
                    {
                        BX = BX;
                    }
                    else if (pierwszy == "BX" && drugi == "CX")
                    {
                        BX = CX;
                    }
                    else if (pierwszy == "BX" && drugi == "DX")
                    {
                        BX = DX;
                    }
                    else if (pierwszy == "CX" && drugi == "AX")
                    {
                        CX = AX;
                    }
                    else if (pierwszy == "CX" && drugi == "BX")
                    {
                        CX = BX;
                    }
                    else if (pierwszy == "CX" && drugi == "CX")
                    {
                        CX = CX;
                    }
                    else if (pierwszy == "CX" && drugi == "DX")
                    {
                        CX = DX;
                    }
                    else if (pierwszy == "DX" && drugi == "AX")
                    {
                        DX = AX;
                    }
                    else if (pierwszy == "DX" && drugi == "BX")
                    {
                        DX = BX;
                    }
                    else if (pierwszy == "DX" && drugi == "CX")
                    {
                        DX = CX;
                    }
                    else if (pierwszy == "DX" && drugi == "DX")
                    {
                        DX = DX;
                    }
                    else
                    {
                        Console.WriteLine("Błędnie podano rejestry procesora");
                    }
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("---------- STAN REJESTRÓW PO WYKONANIU ROZKAZU MOV ----------");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($" AX: {AX}\n BX: {BX}\n CX: {CX}\n DX: {DX}\n");
                    goto start;
                }
            }
            else if (co == "XCHG")
            {
                while (true)
                {
                    int AXC = AX;
                    int BXC = BX;
                    int CXC = CX;
                    int DXC = DX;
                    Console.WriteLine("Podaj pierwszy rejestr rozkazu XCHNG [AX/BX/CX/DX]: ");
                    string pierwszy = Console.ReadLine();
                    Console.WriteLine("Podaj drugi rejestr rozkazu XCHNG [AX/BX/CX/DX]: ");

                    string drugi = Console.ReadLine();
                    Console.WriteLine();

                    if (pierwszy == "AX" && drugi == "AX")
                    {
                        AX = AXC;
                        AX = AXC;
                    }
                    else if (pierwszy == "AX" && drugi == "BX")
                    {
                        AX = BXC;
                        BX = AXC;
                    }
                    else if (pierwszy == "AX" && drugi == "CX")
                    {
                        AX = CXC;
                        CX = AXC;
                    }
                    else if (pierwszy == "AX" && drugi == "DX")
                    {
                        AX = DXC;
                        DX = AXC;

                    }
                    else if (pierwszy == "BX" && drugi == "AX")
                    {
                        BX = AXC;
                        AX = BXC;
                    }
                    else if (pierwszy == "BX" && drugi == "BX")
                    {
                        BX = BXC;
                        BX = BXC;
                    }
                    else if (pierwszy == "BX" && drugi == "CX")
                    {
                        BX = CXC;
                        CX = BXC;
                    }
                    else if (pierwszy == "BX" && drugi == "DX")
                    {
                        BX = DXC;
                        DX = BXC;
                    }
                    else if (pierwszy == "CX" && drugi == "AX")
                    {
                        CX = AXC;
                        AX = CXC;
                    }
                    else if (pierwszy == "CX" && drugi == "BX")
                    {
                        CX = BXC;
                        BX = CXC;
                    }
                    else if (pierwszy == "CX" && drugi == "CX")
                    {
                        CX = CXC;
                        CX = CXC;
                    }
                    else if (pierwszy == "CX" && drugi == "DX")
                    {
                        CX = DXC;
                        DX = CXC;
                    }
                    else if (pierwszy == "DX" && drugi == "AX")
                    {
                        DX = AXC;
                        AX = DXC;
                    }
                    else if (pierwszy == "DX" && drugi == "BX")
                    {
                        DX = BXC;
                        BX = DXC;
                    }
                    else if (pierwszy == "DX" && drugi == "CX")
                    {
                        DX = CXC;
                        CX = DXC;
                    }
                    else if (pierwszy == "DX" && drugi == "DX")
                    {
                        DX = DXC;
                        DX = DXC;
                    }
                    else
                    {
                        Console.WriteLine("Błędnie podano rejestry procesora");
                    }
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Aktualny stan rejestrów procesora po wykonaniu rozkazu XCHG: ");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine($" AX: {AX}\n BX: {BX}\n CX: {CX}\n DX: {DX}\n"); goto start;
                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("----------------------- STAN REJESTÓW -----------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($" AX: {AX}\n BX: {BX}\n CX: {CX}\n DX: {DX}\n");

                Console.WriteLine("Nieoczekiwana wartość, sprawdź poprawnosć pisowni !");
                goto start;
            }
        }
    }
}
