namespace Task_9._6._Workshop;

public sealed class Person
{
    public delegate void Notify(int number);
    public event Notify? ProcessEvent;
    public void SortPerson()
    {
        Console.WriteLine("Для вывода списка фамилий в алфавитном порядке введите 1, в обратном порядке введите 2");
        var result = int.TryParse(Console.ReadLine()!, out var number);
        if (number != 1 && number != 2 || !result) throw new PersonException("Ошибка данных");
        ProcessEntered(number);
    }

    private void ProcessEntered(int number)
    {
        ProcessEvent?.Invoke(number);
    }
}