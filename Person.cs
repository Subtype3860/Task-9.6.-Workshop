namespace Task;


public class Person
{
    public delegate void Notify(int number);
    public event Notify ProcessCompleted;
    private int _log;
    private int Log
    {
        get => _log;
        set
        {
            if (value < 1 | value > 2)
            {
                throw new PersonException("Указано не верное значение", value);
            }
            else
            {
                _log = value;
            }
        }
    }
    public Person(int log)
    {
        Log = log;
    }
    public void SortPerson(string[] person)
    {
        switch (_log)
        {
            case 1:
                Array.Sort(person);
                break;
            case 2:
                Array.Sort(person);
                Array.Reverse(person);
                break;
        }

        foreach (var s in person)
        {
            Console.WriteLine(s);
        }
        
    }
}