namespace HockeyManager;

class Program
{
    public static void Main(string[] args)
    {
        HockeyManager hockeyManager = new HockeyManager();
        hockeyManager.AddNewForward("Janci", 19, 3);
        hockeyManager.AddNewDefender("Gabo", 25, 8);
        hockeyManager.AddNewGoalie("Feri", 22, 5);
        hockeyManager.AddNewGoalie("Jano", 18, 5);
        hockeyManager.AddNewGoalie("Daniel", 20, 5);
        hockeyManager.AddNewGoalie("Jozi", 28, 5);
        hockeyManager.AddNewGoalie("Karol", 24, 5);
        hockeyManager.PrintNameAndAgeOfTheYoungestGoalie();
    }
}