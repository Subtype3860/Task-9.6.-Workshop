namespace Task;

public class PersonException: ArgumentException
{
    private int Value { get; }

    public PersonException(string message, int val) : base(message)
    {
        Value = val;
    }
}