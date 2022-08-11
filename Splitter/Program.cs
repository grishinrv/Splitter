// See https://aka.ms/new-console-template for more information

char separator = '|';

string[] GetData(char separator, string dataKind)
{
    Console.WriteLine($"Give {dataKind}:");
    string data = Console.ReadLine();
    string[] strings = data.Split(separator);
    Console.WriteLine($"Got {strings.Length} {dataKind}");
    return strings;
}

string[] columns = GetData(separator, "columns");
string[] values = GetData(separator, "values");

for (int i = 0; i < columns.Length; i++)
{
    Console.WriteLine(columns[i] + ": " + values[i]);
}
