using static System.Console;
while (true)
{
    Write("Value: ");
    string? value = ReadLine();
    WriteLine($"Hash: {(value is null ? "null" : value.GetHashCode())}");
    WriteLine();
}