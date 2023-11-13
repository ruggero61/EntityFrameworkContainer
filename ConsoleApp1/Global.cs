using System.Runtime.CompilerServices;

namespace ConsoleApp1;
public class Global
{
  [ModuleInitializer]
  public static void Init()
  {
    //Console.WriteLine($"Global Interval for Threads is : {GlobalVars.IntervalForThreads}");
    Console.WriteLine($"Global DataBase Connection String is {GlobalVars.ConnectionToDataBase}");
  }
}

public class Singleton
{
  public static readonly Lazy<Singleton> Instance = new(() => new Singleton());
  private const int IntervalForThreads = 1;
  public static int GetIntervalForThreads() => IntervalForThreads;
}

public static class GlobalVars
{
  public const double IntervalForThreads = .1;
  public const double IntervalForCounter = 5;

  public const string ConnectionToDataBase =
    "Server=localhost;Database=efLessons;Integrated Security=True;TrustServerCertificate=True";
}

public static class RegExpPatterns
{
  public const string EmailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
  public const string FileNameWindowsPattern = "";
}
