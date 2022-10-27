namespace HockeyManager;

public class Hrac
{
    protected string name;
    protected int age;
    
    public Hrac(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }
    
}