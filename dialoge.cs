using System;

namespace dialoge
{

    private static void Main(string[] args)
    {
      dialoge();
   }
   static void dialoge()
   {

      static void GegnerBegegnung()
      {

         Console.WriteLine("Du triffst auf einen Gegner: " + class_Enemy + ".");
         Console.Writeline("Möchtest du Angreifen?");
         string answer_GB = Console.ReadLine();

      }

      static void NeuerNpcBegegnung()
      {

         Console.WriteLine("Oh, dort ist jemand der wirkt als könnte er dir weiterhelfen.");
         Console.WriteLine("Möchtest du zu ihm/ihr gehen?");
         string answer_NNB = Console.Readline();

      }

      static void NeuerRaum()
      {

         Console.WriteLine("Du betrittst einen neuen Raum.");
         Console.WriteLine("Was möchtest du tun?");
         string answer_NR = Console.ReadLine();

      }

      static void ZurueckkehrenRaum()
      {

         Console.WriteLine("Du kommst in den Raum zurück.");
         Console.WriteLine("Was möchtest du tun?");
         string answer_ZR = Console.ReadLine();

      }

      static void RaumMehrereObjekte()
      {

         Console.WriteLine("In dem Raum siehst du " + ObjekteImRaum + ".");
         Console.WriteLine("Welches Objekt möchtest du untersuchen?");
         string answer_RMO = Console.ReadLine();

      }

      static void RaumEinObjekt()
      {

         Console.WriteLine("Im dem Raum siehst du " + ObjektImRaum + ".");
         Console.WriteLine("Möchtest du " + ObjektImRaum + "untersuchen?");
         string answer_REO = Console.ReadLine();

      }

      static void KisteOeffen()
      {

         Console.WriteLine("In der Kiste findest du " + ObjekteKiste + ".");
         Console.WriteLine("Möchtest du alle an dich nehmen?");
         string answer_KO = Console.Readline();

         if (answer_KO == "J" || answer_KO == "j")
         {
            Console.WriteLine("Du nimmst " + ObjekteKiste + " an dich:");
         }
         else 
         {
            Console.WriteLine("Du nimmst die Objekte nicht an dich");
            Console.WriteLine("Möchtest du bestimmt Objekte an dich nehmen?");
            answer_BO = Console.WriteLine();
            if (answer_BO == "J" || answer_Bo == "j")
            {  
               Console.WriteLine("Welche Objekte möchtest du an dich nehmen?")
               string answer_O =Console.ReadLine;
               ChooseKiste();
            }
            else{
               Console.WriteLine("Du nimmst keine Objekte an dich.");
            }


            static void ChooseKiste()
            {
               switch(answer_BO)
               {
                  case "Schlüssel":
                  Console.WriteLine("Du nimmst den Schlüssel an dich");
                  Console.WriteLine("Möchtest du weitere Objekte an dich nehmen?");
                  string answer_MR = Console.ReadLine;

                  if (answer_MR == "J" || answer_MR == "j"){
                     answer_MR = "";
                     ChooseKiste();
                  }
                  else {
                     Console.WriteLine("Du nimmst keine weiteren Objekte an dich.");
                     answer_MR = "";
                  }
                  break;


                  case "Waffe":
                  Console.WriteLine("Du nimmst " + Waffe + " an dich:");
                  Console.WriteLine("Möchtest du weitere Objekte an dich nehmen?");
                  string answer_MR = Console.ReadLine;

                  if (answer_MR == "J" || answer_MR == "j"){
                     answer_MR = "";
                     ChooseKiste();
                  }
                  else {
                     Console.WriteLine("Du nimmst keine weiteren Objekte an dich.");
                     answer_MR = "";
                  }
                  break;


                  case "Trank":
                  Console.WriteLine("Du nimmst den Trank an dich");
                  Console.WriteLine("Möchtest du weitere Objekte an dich nehmen?");
                  string answer_MR = Console.ReadLine;

                  if (answer_MR == "J" || answer_MR == "j"){
                     answer_MR = "";
                     ChooseKiste();
                  }
                  else {
                     Console.WriteLine("Du nimmst keine weiteren Objekte an dich.");
                     answer_MR = "";
                  }
                  break;


                  default:
                  Console.WriteLine("Du nimmst keine der Objekte an dich");
               }
            }

         }

      }
   }
}