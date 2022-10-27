namespace HockeyManager;

public class Obranca: Hrac
{
    private int hits;
    
    public Obranca(string name, int age, int hits) : base(name, age)
    {
        this.name = name;
        this.age = age;
        this.hits = hits;
    }
}