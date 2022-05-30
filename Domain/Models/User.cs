namespace Domain.Models;

public class User
{
    public User()
    {
        
    }

    public User(string name, int age)
    {
        Id = 0;
        Name = name;
        Age = age;
    }

    public User(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public int Id { get; private set; }

    public string Name { get; private set; }

    public int Age { get; private set; }

    public bool LegalAge()
    {
        return Age > 18;
    }
}