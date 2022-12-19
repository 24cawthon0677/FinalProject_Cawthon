public class User
{
    public string username;
    public string password;

    public User(string username, string password)
    {
        this.username = username;
        this.password = password;
    }
}

public class Guest : User
{
  
    public Guest(string username, string password) : base(username, password)
    {
    }

    public string Un { get; }
}

public class Admin : User
{
    public Admin(string username, string password) : base(username, password)
    {
    }
}

