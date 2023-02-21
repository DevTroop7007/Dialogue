using System;

class Program 
{
  public static void Main (string[] args) 
  {
    //Starting
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("                                Dialogue");
    Console.WriteLine("");
    Console.ResetColor();
    Console.Write("A dialoge between ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Nadia ");
    Console.ResetColor();
    Console.Write("and ");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write("Headmistress ");  
    Console.ResetColor();
    Console.WriteLine("for leave of absence");
    Console.ReadKey();

    //functions declarations
    Dialogue();

    Console.ForegroundColor = ConsoleColor.DarkBlue;    
    Console.WriteLine("Developer : *******");
    Console.WriteLine("Github link : https://github.com/DevTroop7007");
    Console.ResetColor();
  }
  
  
  
  static void Dialogue()
  {
    //variable declarations
    string[] Nadia = {"May I come in, Madam?", "Could you please grant me leave, Madam?", "Madam, I need leave of absence.","On account of fever.","For three days , Madam.","Thank you, Madam."};
    string[] HM = {"Yes, come in .Tell me what you want.", "Leave! Your examination is near at hand. So, I can't allow you any leave now.", "Why?", "For how many days?", "Give the application. I am granting you leave. Show it to your class teacher.", "You're welcome."};
    
  //Dialogue
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(">"+ Nadia[0]);
    Console.ResetColor();
    Console.ReadKey();
    ////////////////////////
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(">"+ HM[0]);
    Console.ResetColor();
    Console.ReadKey();
    ////////////////////////
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(">"+ Nadia[1]);
    Console.ResetColor();
    Console.ReadKey();
    ////////////////////////
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(">"+ HM[1]);
    Console.ResetColor();
    Console.ReadKey();
    ////////////////////////
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(">"+ Nadia[2]);
    Console.ResetColor();
    Console.ReadKey();
    ////////////////////////
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(">"+ HM[2]);
    Console.ResetColor();
    Console.ReadKey();
    ////////////////////////
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(">"+ Nadia[3]);
    Console.ResetColor();
    Console.ReadKey();
    ////////////////////////
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(">"+ HM[3]);
    Console.ResetColor();
    Console.ReadKey();
    ////////////////////////
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(">"+ Nadia[4]);
    Console.ResetColor();
    Console.ReadKey();
    ////////////////////////
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(">"+ HM[4]);
    Console.ResetColor();
    Console.ReadKey();
    ////////////////////////
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(">"+ Nadia[5]);
    Console.ResetColor();
    Console.ReadKey();
    ////////////////////////
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(">"+ HM[5]);
    Console.ResetColor();
    
  }
}
