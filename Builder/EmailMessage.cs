namespace ConsoleApp3;

public class EmailMessage
{
    private readonly List<string> body = new();
    private string _from;
    private string _setSubject;
    private string _to;

    public EmailMessage From(string from)
    {
        _from = from;
        return this;
    }

    public EmailMessage To(string to)
    {
        _to = to;
        return this;
    }

    public EmailMessage SetSubject(string setSubject)
    {
        _setSubject = setSubject;
        return this;
    }

    public EmailMessage AddBody(string addBody)
    {
        body.Add(addBody);
        return this;
    }

    public void Send()
    {
        Console.WriteLine("От:" + _from);
        Console.WriteLine("Кому:" + _to);
        Console.WriteLine("Тема:" + _setSubject);
        Console.WriteLine("Сообщение:");
        foreach (var item in body) Console.WriteLine(item);
    }
}