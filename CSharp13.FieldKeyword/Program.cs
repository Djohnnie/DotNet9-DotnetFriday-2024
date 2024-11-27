

Console.WriteLine(new Person
{
    NameInCaps = "Johnny Hooyberghs"
});

Console.WriteLine(new NewsItem
{
    Title = "C# 13.0 is out!"
});

Console.ReadKey();



public class Person
{
    public string NameInCaps
    {
        get => field;
        set => field = value.ToUpper();
    }

    public override string ToString()
    {
        return NameInCaps;
    }
}

public class NewsItem
{
    private string field;

    public string Title
    {
        get => @field;
        set => @field = value;
    }

    public override string ToString()
    {
        return field;
    }
}