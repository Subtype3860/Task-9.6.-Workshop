namespace Task;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Для вывода списка фамилий в алфавитном порядке введите 1, в обратном порядке введите 2");
        var num = Console.ReadLine();
        try
        {
            var arrey = new[] { "Ермолов", "Сомов", "Добрынин", "Барсуков", "Глушков" };
            var person = new Person(2);
            person.SortPerson(arrey);
        }
        catch (PersonException e)
        {
            Console.WriteLine($"Ошибка: {e}");
        }
    }
}