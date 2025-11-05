#region Collections Usage
#region List
using System.Collections;

List<string> names = new List<string> { "Mahmud", "Leyla", "Mahmud" };
names.Add("Mahmud");

foreach (var name in names)
    Console.WriteLine(name);

Console.WriteLine($"First name: {names[0]}");
#endregion

#region Hashset
HashSet<int> numbers = new HashSet<int> { 1, 2, 3, 3 };
numbers.Add(4);

foreach (var n in numbers)
    Console.WriteLine(n);

Console.WriteLine(numbers.Contains(3));
#endregion

#region SortedList
SortedList<int, string> sortedList = new();

sortedList.Add(3, "C");
sortedList.Add(1, "A");
sortedList.Add(2, "B");

foreach (var kvp in sortedList)
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
#endregion

#region Hashtable
Hashtable table = new Hashtable();

table.Add(1, "A");
table.Add(2, "B");
table[3] = "C";

foreach (DictionaryEntry entry in table)
{
    Console.WriteLine($"{entry.Key}: {entry.Value}");
}

if (table.ContainsKey(2))
    Console.WriteLine($"Key 2: {table[2]}");
#endregion
#endregion