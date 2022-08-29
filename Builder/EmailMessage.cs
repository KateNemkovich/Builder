using System.Text;

namespace ConsoleApp3;

public class EmailMessage:IToStage,ISubjectStage,IAddBodyStage,ISendStage
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

    public ISubjectStage To(string to)
    {
        _to = to;
        return this;
    }

    public IAddBodyStage SetSubject(string setSubject)
    {
        _setSubject = setSubject;
        return this;
    }

    public IAddBodyStage AddBody(string addBody)
    {
        body.Add(addBody);
        return this;
    }
    
    public ISendStage AddBody(StringBuilder builder)
    {
        body.Add(builder.ToString());
        return this;
    }

    public void Send()
    {
        Console.WriteLine("От:" + _from);
        Console.WriteLine("Кому:" + _to);
        Console.WriteLine("Тема:" + _setSubject.ToUpper());
        Console.WriteLine("Сообщение:");
        foreach (var item in body) Console.WriteLine(item);
    }
}

public interface IToStage
{
    ISubjectStage To(string to);
}
public interface ISubjectStage
{
    IAddBodyStage SetSubject (string setsubject);
}

 public interface IAddBodyStage:ISendStage
{
   public IAddBodyStage AddBody (string addBody);
   public ISendStage AddBody (StringBuilder builder);
        
}

public interface ISendStage
{
    public void Send();
}

