using System;
using System.Threading;

public class Utils
{
  public static void CustomConsole(string msg, ConsoleColor conColor, int delay=0)
  {
    Console.ForegroundColor = conColor;
    Console.WriteLine(msg);
    Console.ResetColor();

    Thread.Sleep(delay);
  }
  public static void DrawLine(int size, string symb)
  {
    var str="";
    for(int x=0; x<size;x++)
      str+=symb;
    Console.WriteLine(str);
  }
 
}