namespace HockeyManager;

public class Utocnik: Hrac
{
    private int goals;
    
    public Utocnik(string name, int age, int goals) : base(name, age)
    {
        this.name = name;
        this.age = age;
        this.goals = goals;
    }
}