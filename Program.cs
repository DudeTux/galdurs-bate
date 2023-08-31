using System;
using Class1;
using asciis;
using Inventory;
using PublicInit;


namespace Galdurs_Bate
{
    public static class Program
    {
        public static Class1.Player1 Player = new Class1.Player();

        public static void Main(string[] args)
        {
            Random random = new Random();
            string username = "Nix";
            string AW = "N";
            string Fight = "False";
            string EA = "True";
            string ConsoleRL1 = "3";
            string ConsoleRL2 = "3";
            int PD20 = 100;
            int ED20 = 100;
            int randomIndex = MonsterD();
            
            Class1.Enemy[] Monster = new Class1.Enemy[10];

            Monster[0] = new Class1.Enemy_low_Goblin();
            Monster[1] = new Class1.Enemy_low_Slime();
            Monster[2] = new Class1.Enemy_low_Ratte();
            Monster[3] = new Class1.Enemy_low_Tiger();
            Monster[4] = new Class1.Enemy_low_Zombie();
            Monster[5] = new Class1.Enemy_low_Geier();
            Monster[6] = new Class1.Enemy_low_Skelet();
            Monster[7] = new Class1.Enemy_low_Rabe();
            Monster[8] = new Class1.Enemy_low_Skorpion();
            Monster[9] = new Class1.Enemy_low_Seepferdchen();

            
           
            

            
            
            int MonsterD()
            {
                Random random = new Random();
                int result = random.Next(0, 10);
                return result;
            }
            Class1.Enemy LOL = Monster[randomIndex];

            int d4()
            {
            Random random = new Random();
            int result = random.Next(1, 5);
            return result;
            }


            int d6()
            {
            Random random = new Random();
            int result = random.Next(1, 7);
            return result;
            }


            int d8()
            {
                Random random = new Random();
                int result = random.Next(1, 9);
                return result;
            }


            int d10 ()
            {
                Random random = new Random();
                int result = random.Next(1, 11);
                return result;
            }


            int d12()
            {
                Random random = new Random();
                int result = random.Next(1, 13);
                return result;
            }


            int d20()
            {
                Random random = new Random();
                int result = random.Next(1, 21);
                return result;
            }
 

            Console.Write("Programm Starten? J/N: ");
            AW = Console.ReadLine();

            if (AW == "J" || AW == "j")
            {
                

                Console.WriteLine("Ein wilder" + LOL.Name +  "erscheint. Bitte würfeln.");
                Console.ReadLine();
            }
            else if (string.IsNullOrEmpty(AW))
            {
                Console.WriteLine("Bitte Bestätigen");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("Das ist leider keine Option XD");
                return;
            }
            PD20 = d20();
            ED20 = d20();
            Console.WriteLine("Du würfelst: " + PD20);
            Console.WriteLine("Dein Gegner würfelt: " + ED20);

            if (PD20 > ED20)
            {
                Console.WriteLine("Du hast gewonnen! Willst du angreifen?\r\nJ. Ja\r\nF. Fliehen");

                string choice = Console.ReadLine();
                if (choice == "F" || choice == "f")
                {
                    Fight = "False";
                }
                else if (choice == "J" || choice == "j")
                {
                    EA = "False";
                    Fight = "True";
                }
            }
            else if (PD20 < ED20)
            {
                Console.WriteLine("Du hast verloren! Dein Gegner darf zuerst angreifen");
                EA = "True";
                Fight = "True";
            }
            else
            {
                Console.WriteLine("Es ist ein Unentschieden!");
                return;
            }

            while (Fight == "True")
            {

                if (EA == "True")
                {
                    ED20 = d20();
                    Console.WriteLine("Der Gegner greift an und versucht dir schaden in höhe von " + (ED20 + LOL.Attack) + "zu machen");

                    if ( ED20 + LOL.Attack <= Player.PDefence)
                    {
                        Console.WriteLine("Dein Gegner hat gegen deine Rüstung keine Chance");
                        
                    }
                    if ( ED20 + LOL.Attack >= Player.PDefence)
                    {
                        Console.WriteLine("Die Attake Gelingt ihm");
                        Player.PHP -= ED20;
                        Player.PHP -= LOL.Attack;
                    }
                    
                    Console.ReadLine();
                    Console.WriteLine("Bitte würfeln.");
                    EA = "False";
                }
                if (EA == "False")
                {
                    Console.WriteLine("Du bist am Zug");
                    Console.ReadLine();
                    Anker1:
                    Console.WriteLine("Dein Leben ligt bei: " + Player.PHP + "\r\nDie Gegner HP liegen bei: " + LOL.HP + "\r\nBitte wähle, was du machen möchtest:\r\n1. Attack\r\n2. Special\r\n3. Inventory\r\n4. Fliehen");

                    ConsoleRL1 = Console.ReadLine();

                    if (ConsoleRL1 == "1")
                    {
                        Console.WriteLine("Bitte wähle deine Angriffsart:\r\n1. Nahkampf");
                        ConsoleRL2 = Console.ReadLine();

                        if (ConsoleRL2 == "1")
                        {
                            PD20 = d20();
                            Console.WriteLine("Bitte würfeln");
                            Console.ReadLine();
                            Console.WriteLine("Du würfelst.\r\nDu versuchst deinem Gegner " + (PD20 + Player.PAttack) + " Schaden zu machen");
                            
                            if (PD20 + Player.PAttack >= LOL.Defence)
                            {
                                LOL.HP -= PD20 + Player.PAttack;
                                Console.WriteLine("Ein Voller Erfolg!!!!");
                                Console.ReadLine();
                            }
                            
                            else if (PD20 + Player.PAttack <= LOL.Defence)
                             {
                                Console.WriteLine("Leider ein Fehlschlag");
                                Console.ReadLine();
                             }
                            



                            if (LOL.HP > 0)
                            {
                                Console.WriteLine("Dein Gegner ist am Zug");
                            }
                            EA = "True";
                        }
                        

                        

                        
                        
                    }




                
                    if (ConsoleRL1 == "2")
                    {

                    }
                    if (ConsoleRL1 == "3")
                    {               
                        Inventory.ASKII.ASKIII();
                    
                        goto Anker1;
                    }

                    if (ConsoleRL1 == "4")
                    {


                        Console.WriteLine("Du versuchst zu fliehen\r\nFür erfolgreichen fluchtversuch bitte würfeln");
                        Console.ReadLine();
                        ED20 = d20();
                        PD20 = d20();
                        Console.WriteLine("Dein Gegner würfelt " + ED20 + "\r\nDu würfelst" + PD20);
                        if (PD20 > ED20)
                        {
                        Console.WriteLine("Deine Flucht war Erfolgreich");
                        Fight = "False";
                        }
                        if (PD20 < ED20)
                        {
                            Console.WriteLine("Du warst zu Langsam, dein Gegner schadet dir bevor du fliehen kannst");
                            ED20 = d20();
                            Console.ReadLine();
                            Console.WriteLine("Du bekommst " + ED20 + "Schaden und entkommst gerade so");
                            Player.PHP -= ED20;
                            Fight = "False";
                        }
                    }
                    else if (string.IsNullOrEmpty(ConsoleRL1))
                    {
                        Console.WriteLine("Bitte achte darauf immer eine eingabe zu tätigen wenn es verlangt wird\r\n     ");
                        goto Anker1;
                    }   
                    
                }


                if (Player.PHP <= 0)
                {
                    Console.WriteLine("Du wurdest besiegt");
                    Fight = "False";
                }
                if (LOL.HP <= 0)
                {
                    Console.WriteLine("Der Gegner wurde besigt");
                    Fight = "False";
                }


            }





            
            Console.WriteLine("Simulations ENDE!!!!");
            Console.ReadLine();
            


            
            
            
        }
 
    }
}
