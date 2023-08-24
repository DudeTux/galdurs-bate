using System;

internal class Program
{
    private static void Main(string[] args)
    {
      choose();
   }

            int Hp;
            int Magic; 
            int Attack; 
            int Defence; 
            int Geschicklichkeit; 
            int Strength;
            int Speed;
            int Luck;
            int Intelligence; 


            int BetterHp = Hp + (Hp *0.05);
            int BetterMagic = Magic + (Magic *0.05);
            int BetterAttack = Attack + (Attack *0.05);
            int BetterDefense = Defense + (Defense *0.05);
            int BetterGeschicklichkeit = Geschicklichkeit + (Geschicklichkeit *0.05);
            int BetterStrength = Strength + (Strength *0.05);
            int BetterSpeed = Speed + (Speed *0.05);
            int BetterLuck = Luck + (Luck *0.05);
            int BetterIntelligence = Intelligence + (Intelligence *0.05);


      static void choose()
      {

         Console.WriteLine("Welche Charaktereigenschaft möchtest du verbessern?");
         string Answer= console.Read();
         LvlUp(Answer);      

      }  

      static void LvlUp(string wert)
      {

         if (wert = "Hp")
         {
            Hp = BetterHp;
         }
         if (wert = "Magie")
         {
            Magic = BetterMagic;
         }
         if (wert = "Attacke")
         {
            Attack = BetterAttack;
         }
         if (wert = "Verteigigung")
         {
            Defence = BetterDefense;
         }
         if (wert = "Geschicklichkeit")
         {
            Geschicklichkeit = BetterGeschicklichkeit;
         }
         if (wert = "Stärke")
         {
            Strength = BetterStrength;
         }
         if (wert = "Geschwindigkeit")
         {
            Speed = BetterSpeed;
         }
         if (wert = "Glück")
         {
            Luck = BetterLuck;
         }
         if (wert = "Intelligenz")
         {
            Intelligence = BetterIntelligence;
         }

      }
}
