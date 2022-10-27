namespace HockeyManager;

public class HockeyManager
{
    private List<Hrac> _utocnici = new List<Hrac>();
    private List<Hrac> _obrancovia = new List<Hrac>();
    private List<Hrac> _brankari = new List<Hrac>();
    
    public void AddNewForward(string name, int age, int goals)
    {
        Hrac hrac = new Utocnik(name, age, goals);
        _utocnici.Add(hrac);
    }
    public void AddNewDefender(string name, int age, int hits)
    {
        Hrac hrac = new Obranca(name, age, hits);
        _obrancovia.Add(hrac);
    }
    public void AddNewGoalie(string name, int age, int wins)
    {
        Hrac hrac = new Brankar(name, age, wins);
        _brankari.Add(hrac);
    }
    public void PrintNameAndAgeOfTheYoungestGoalie()
    {
        if (_brankari.Count <= 0)
        {
            Console.WriteLine("Nemam v Zazname ziadnych Brankarov");
        }
        else
        {
            Hrac najmladsi = _brankari[0];
            int vek = _brankari[0].GetAge();
            foreach (var hrac in _brankari)
            {
                if (hrac.GetAge() < vek)
                {
                    vek = hrac.GetAge();
                    najmladsi = hrac;
                }
            }
            Console.WriteLine("Najmladsi Brankar je " + najmladsi.GetName() + " a ma " + najmladsi.GetAge() + " rokov");
        }
    }
}