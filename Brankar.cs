namespace HockeyManager;

public class Brankar: Hrac
{
    private int wins;
    
    public Brankar(string name, int age, int wins) : base(name, age)
    {
        this.name = name;
        this.age = age;
        this.wins = wins;
    }
}