#region Delegate
class Program
{
    public delegate bool StringFilter(string str);

    public static List<string> FilterStrings(List<string> items, StringFilter filter)
    {
        List<string> result = new List<string>();

        foreach (var item in items)
        {
            if (filter(item))
            {
                result.Add(item);
            }
        }

        return result;
    }

    public static void Main()
    {
        var words = new List<string> { "apple", "banana", "cherry", "avocado" };

        var filtered = FilterStrings(words, s => s.StartsWith("a"));

        foreach (var word in filtered)
        {
            Console.WriteLine(word);
        }
    }
}
#endregion