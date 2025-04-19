string[] values = { "12.3", "45", "ABC", "11", "DEF" };
float total = 0f;
string message = "";

foreach (string value in values)
{
    if (float.TryParse(value, out float number))
    {
        total += number;
    }
    else
    {
        message += value;
    }
}

Console.WriteLine($"Total: {total}");
Console.WriteLine($"Message: {message}");