namespace Task_9._6._Workshop;

internal static class Program
{
    public static void Main()
    {
        while (true)
        {
            var person = new Person();
            person.ProcessEvent += ShowPerson;
            try
            {
                person.SortPerson();
            }
            catch (PersonException e)
            {
                Console.WriteLine($"Ошибка: {e}");
            }
        }

    }
    private static void ShowPerson(int number)
    {
        var arrey = new[] { "Ермолов", "Сомов", "Добрынин", "Барсуков", "Глушков" };
        switch (number)
        {
            case 1:
                Array.Sort(arrey);
                break;
            case 2:
                Array.Sort(arrey);
                Array.Reverse(arrey);
                break;
        }
        foreach (var s in arrey)
        {
            Console.WriteLine(s);
        }
    }
}