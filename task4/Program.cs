using System;
class Program{
    static void Main(){
        Country output = new Country("Italy", "Rome", 58760000, "Italian");

        string country = output.GetName();
        Console.WriteLine("Country: " + country);

        string capital = output.GetCapital();
        Console.WriteLine("Capital: " + capital);

        int population = output.GetPopulation();
        Console.WriteLine("Population: " + population);

        string language = output.GetOfficialLanguage();
        Console.WriteLine("Official Language: " + language);
    }
}

class Country{
    public string? name;
    public string? capital;
    public int population;
    public string? officialLanguage;

    public Country(string name, string capital, int population, string officialLanguage) {
        this.name = name;
        this.capital = capital;
        this.population = population;
        this.officialLanguage = officialLanguage;
    }

    public string GetName()
    {
        return name;
    }

    public void SetCapital(string capital)
    {
        this.capital = capital;
    }

    public string GetCapital()
    {
        return capital;
    }

    public void SetPopulation(int population)
    {
        this.population = population;
    }

    public int GetPopulation()
    {
        return population;
    }

    public void SetOfficialLanguage(string language)
    {
        this.officialLanguage = language;
    }

    public string GetOfficialLanguage()
    {
        return officialLanguage;
    }
}