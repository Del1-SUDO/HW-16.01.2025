using System;
class Program {
    static void Main() {
        User input = new User();
        string Username = "Deli";
        string Pass = "1234";

        string result = input.LoginUser(ref Username, ref Pass);
        Console.WriteLine(result);

        string text = input.GetFullInfo();
        System.Console.WriteLine(text);
    }
}

class User {
    public string Name = "Siyovush";
    public string Last_name = "Kurbonov";
    public string Login = "Deli";
    public string Password = "1234";
    public bool IsLoggedIn;

    public string LoginUser(ref string Username, ref string Pass) {
        if (Username == Login && Pass == Password) {
            IsLoggedIn = true;
            return "User logged in successfully";
        }
        else {
            return "Your password or username is incorrect";
        }
    }

    public string GetFullInfo(){
        return $"{Name} {Last_name} - {IsLoggedIn}";
    }
}