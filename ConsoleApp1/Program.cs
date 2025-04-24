// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// float total = 0f;
// string message = "";

// foreach (string value in values)
// {
//     if (float.TryParse(value, out float number))
//     {
//         total += number;
//     }
//     else
//     {
//         message += value;
//     }
// }

// Console.WriteLine($"Total: {total}");
// Console.WriteLine($"Message: {message}");

// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// int result1 = Convert.ToInt32(value1 / value2);
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// decimal result2 = value2 / (decimal)value3;
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// float result3 = value3 / value1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


// string[] pallets = [ "B14", "A11", "B12", "A13" ];
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string pangram = "The quick brown fox jumps over the lazy dog";

// string[] words = pangram.Split(' ');

// // string result = string.Empty;
// string[] resultMessage = new string[words.Length];

// foreach (string word in words)
// {
//     char[] letters = word.ToCharArray();
//     Array.Reverse(letters);
//     string reversedWord = String.Join("", letters);
//     result += reversedWord + " ";
// }

// for (int i = 0; i < resultMessage.Length; i++)
// {
//     char[] letters = words[i].ToCharArray();
//     Array.Reverse(letters);
//     resultMessage[i] = String.Join("", letters);
// }

// result = result.Trim();
// System.Console.WriteLine(result);

// string result = String.Join(" ", resultMessage);
// Console.WriteLine(result);

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orders = orderStream.Split(',');
Array.Sort(orders);

int correctLength = 4;

foreach (string order in orders)
{
    if (order.Length != correctLength) Console.WriteLine($"{order}\t- Error");
    
    else Console.WriteLine($"{order}");
}
    