using System;
class Program{
    static void Main(){
        Author input = new Author();
        input.name = "Siyovush";
        input.age = 20;
        input.nationality = "Tajik";

        string name = input.GetName();
        System.Console.WriteLine(name);

        int age = input.GetAge();
        System.Console.WriteLine(age);

        string nationality = input.GetNationality();
        System.Console.WriteLine(nationality);

        string introduce = input.Introduce();
        System.Console.WriteLine(introduce);

        int nextBirthday = input.CelebrateBirthday();
        System.Console.WriteLine("Next birthday I will be: " + nextBirthday);
    }
}

class Author{
    public string? name;
    public int age;
    public string? nationality;

    public string GetName(){
        return name;
    }

    public int GetAge(){
        return age;
    }

    public string GetNationality(){
        return nationality;
    }

    public string Introduce(){
        return $"My name is {name}. I am {age} years old. I am {nationality}.";
    }

    public int CelebrateBirthday(){
        return age+1;
    }

}