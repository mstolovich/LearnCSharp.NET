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

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// string[] orders = orderStream.Split(',');
// Array.Sort(orders);

// int correctLength = 4;

// foreach (string order in orders)
// {
//     if (order.Length != correctLength) Console.WriteLine($"{order}\t- Error");

//     else Console.WriteLine($"{order}");
// }

// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// string mailTemplate = "Dear {0},\n" +
//     "As a customer of our {1} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\n" +
//     "Currently, you own {2:N2} shares at a return of {3:P2}\n\n" +
//     "Our new product, {4} offers a return of {5:P2}.  Given your current volume, your potential profit would be {6:C}\n\n";

// string message = String.Format(mailTemplate, customerName, currentProduct, currentShares, currentReturn, newProduct, newReturn, newProfit);

// Console.WriteLine(message);
// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = $"{currentProduct.PadRight(20)} {currentReturn.ToString("P2").PadRight(10)} {currentProfit.ToString("C").PadRight(60)}\n" +
//     $"{newProduct.PadRight(20)} {newReturn.ToString("P2").PadRight(10)} {newProfit.ToString("C").PadRight(60)}\n";

// Console.WriteLine(comparisonMessage);


// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string quantity = "";
// string output = "";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int quantityStart = input.IndexOf(openSpan) + openSpan.Length;
// int quantityEnd = input.IndexOf(closeSpan);
// int quantityLength = quantityEnd - quantityStart;
// quantity = input.Substring(quantityStart, quantityLength);

// const string tradeSymbol = "&trade;";
// const string regSymbol = "&reg;";
// output = input.Replace(tradeSymbol, regSymbol);

// const string openDiv = "<div>";
// int divStart = output.IndexOf(openDiv);
// if (divStart != -1) output = output.Remove(divStart, openDiv.Length);

// const string closeDiv = "</div>";
// int divCloseStart = output.IndexOf(closeDiv);
// if (divCloseStart != -1) output = output.Remove(divCloseStart, closeDiv.Length);

// Console.WriteLine($"Quantity: {quantity}");
// Console.WriteLine($"Output: {output}");


// Methods
// ========

// Console.WriteLine("Generating random numbers:");
// DisplayRandomNumbers();

// void DisplayRandomNumbers() 
// {
//     Random random = new Random();

//     for (int i = 0; i < 5; i++) 
//     {
//         Console.Write($"{random.Next(1, 100)} ");
//     }

//     Console.WriteLine();
// }

//Shifting medicine intake time method

// int[] times = {800, 1200, 1600, 2000};
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");
// DisplayTimes();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     AdjustTimes();
// } 
// else 
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     AdjustTimes();
// }

// Console.WriteLine("New Medicine Schedule:");
// DisplayTimes();

// void DisplayTimes()
// {
//     /* Format and display medicine times */
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     }
//     Console.WriteLine();
// }

// void AdjustTimes() 
// {
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++) 
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }
