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


// Method to check an IPV4 address validity

// string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
// string[] address;
// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;

// foreach (string ip in ipv4Input)
// {
//     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

//     ValidateLength();
//     ValidateZeroes();
//     ValidateRange();

//     if (validLength && validZeroes && validRange)
//     {
//         Console.WriteLine($"{ip} is a valid IPv4 address");
//     }
//     else
//     {
//         Console.WriteLine($"{ip} is an invalid IPv4 address");
//     }
// }

// void ValidateLength()
// {
//     validLength = address.Length == 4;
// }
// ;

// void ValidateZeroes()
// {
//     foreach (string number in address)
//     {
//         if (number.Length > 1 && number.StartsWith("0"))
//         {
//             validZeroes = false;
//             return;
//         }
//     }

//     validZeroes = true;
// }

// void ValidateRange()
// {
//     foreach (string number in address)
//     {
//         int value = int.Parse(number);
//         if (value < 0 || value > 255)
//         {
//             validRange = false;
//             return;
//         }
//     }
//     validRange = true;
// }

// Magic Fortune teller method

// Random random = new Random();
// int luck = random.Next(100);

// string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
// string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
// string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
// string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

// MagicCrystal(luck);

// void MagicCrystal(int luckLevel) 
// {
//     Console.WriteLine("A fortune teller whispers the following words:");
//     string[] fortune = (luckLevel > 75 ? good : (luckLevel < 25 ? bad : neutral));
//     for (int i = 0; i < 4; i++) 
//     {
//         Console.Write($"{text[i]} {fortune[i]} ");
//     }
// }


// Method with parameters

// int[] schedule = { 800, 1200, 1600, 2000 };

// void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
// {
//     int diff = 0;
//     if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//     {
//         Console.WriteLine("Invalid GMT");
//     }
//     else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//     {
//         diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     }
//     else
//     {
//         diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     }

//     for (int i = 0; i < times.Length; i++)
//     {
//         int newTime = ((times[i] + diff)) % 2400;
//         Console.WriteLine($"{times[i]} -> {newTime}");
//     }
// }

// DisplayAdjustedTimes(schedule, 6, -6);


// Add a method to display email addresses

string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

void DisplayEmailAddresses(string [,] names , bool isCorporate, string domain = "hayworth.com")
{
    string emailAddress = "";
    string firstName = "";
    string lastName = "";
    string internalDomain = "contoso.com";

    for (int i = 0; i < names.GetLength(0); i++)
    {
        firstName = names[i, 0].ToLower();
        lastName = names[i, 1].ToLower();
        emailAddress = $"{firstName[..2]}{lastName}@{(isCorporate ? internalDomain : domain)}";
        Console.WriteLine(emailAddress);
    }
}

DisplayEmailAddresses(corporate, true);
DisplayEmailAddresses(external, false);


// for (int i = 0; i < corporate.GetLength(0); i++) 
// {
//     // display internal email addresses
// }

// for (int i = 0; i < external.GetLength(0); i++) 
// {
//     // display external email addresses
// }