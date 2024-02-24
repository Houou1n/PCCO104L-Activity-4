using System;

class Program {
  public static void Main (string[] args) {
    string Wrd;
    string PrevWrd = "";
    do
    {
      Console.WriteLine("Enter something: ");
      Wrd = Console.ReadLine();
      if (Wrd == "exit" || Wrd == "Exit") 
      break;

      PrevWrd = PrevWrd + " " + Wrd;
      Console.WriteLine(PrevWrd.Trim());
      } 
      while (Wrd != "exit" && Wrd != "Exit");
    Console.WriteLine(" ");
    Console.WriteLine("You have exited the program");
  }
}