string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number; // stores the TryParse "out" value
    if (decimal.TryParse(value, out number))
    {
        Console.WriteLine("value: " + value);
        Console.WriteLine("number: " + number);
        total += number;
        Console.WriteLine("total: " + total);
    }
    else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");


// Nuevo ejemplo
Console.WriteLine("Nuevo Ejemplo");

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1 = Convert.ToInt32(value1 /value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


// Nuevo ejemplo
Console.WriteLine("Nuevo Ejemplo");

string[] pallets = [ "B14", "A11", "B12", "A13" ];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


//nuevo ejemplo
Console.WriteLine("Nuevo Ejemplo");

string val = "abc123";
char[] valueArray = val.ToCharArray();
Array.Reverse(valueArray);
//string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}


//ejercicio 1
Console.WriteLine("Ejercicio 1");

string pangram = "The quick brown fox jumps over the lazy dog";
string[] pgArray = pangram.Split(' ');
for (int i = 0; i < pgArray.Length; i++)
{
    char[] pgChar = pgArray[i].ToCharArray();
    Array.Reverse(pgChar);
    pgArray[i] = new string(pgChar);
}

string newPangram = String.Join(" ", pgArray);
Console.WriteLine(newPangram);


//ejercicio 2
Console.WriteLine("Ejercicio 2");

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderStreamArray = orderStream.Split(',');
Array.Sort(orderStreamArray);
string[] newOrderStreamArray = new string[orderStreamArray.Length];
for (int i = 0; i < orderStreamArray.Length; i++)
{
    newOrderStreamArray[i] = orderStreamArray[i];
    if (orderStreamArray[i].Length != 4)
    {
        while (newOrderStreamArray[i].Length < 8)
        {
            newOrderStreamArray[i] += " ";
        }
        newOrderStreamArray[i] += "- Error";
        // todo esto es lo mismo que Console.WriteLine(newOrderStreamArray[i] += "\t- Error");
    }

    Console.WriteLine(newOrderStreamArray[i]);
}


// Nuevo ejemplo
Console.WriteLine("Nuevo Ejemplo");

string first = "Hello";
string second = "World";
string res = string.Format("{0} {1}!", first, second);  // Formato completo
Console.WriteLine(res);

decimal price2 = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price2:C} (Save {discount:C})");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
Console.WriteLine($"Measurement: {measurement:N4} units");

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
yourDiscount += $"A discount of {((price - salePrice) / price):P2}!"; //inserted

Console.WriteLine(yourDiscount);


//Nuevo ejemplo
Console.WriteLine("Nuevo Ejemplo");

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
//decimal total2 = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");


//Nuevo ejemplo
Console.WriteLine("Nuevo Ejemplo");

string input = "Pad this";
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";
var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);
Console.WriteLine(formattedLine);


//Ejercicio 3
Console.WriteLine("Ejercicio 3");

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine("");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P2}.");
Console.WriteLine("");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}.");
Console.WriteLine("");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
comparisonMessage += currentProduct.PadRight(20) + currentReturn.ToString("P2").PadRight(10) + currentProfit.ToString("C2") + "\n";
comparisonMessage += newProduct.PadRight(20) + newReturn.ToString("P2").PadRight(10) + newProfit.ToString("C2");

Console.WriteLine(comparisonMessage);


//Nuevo ejemplo
Console.WriteLine("Nuevo Ejemplo");

message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

message = "What is the value <span>between the tags</span>?";

openingPosition = message.IndexOf("<span>");
closingPosition = message.IndexOf("</span>");

openingPosition += 6;
length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));


//Nuevo ejemplo
Console.WriteLine("Nuevo Ejemplo");

message = "hello there!";

int first_h = message.IndexOf('h');
int last_h = message.LastIndexOf('h');

Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");


message = "(What if) I am (only interested) in the last (set of parentheses)?";
openingPosition = message.LastIndexOf('(');

openingPosition += 1;
closingPosition = message.LastIndexOf(')');
length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));


// recuperar todas:
message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    closingPosition = message.IndexOf(')');
    length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}



//Nuevo ejemplo
Console.WriteLine("Nuevo Ejemplo");

message = "Hello, world!";
char[] charsToFind = { 'a', 'e', 'i' };

int index = message.IndexOfAny(charsToFind);

Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");


// Nuevo ejemplo
Console.WriteLine("Nuevo Ejemplo");

message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

closingPosition = 0;

while (true)
{
    openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}


//Nuevo ejemplo
Console.WriteLine("Nuevo Ejemplo");

string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);


// Ejercicio 4
Console.WriteLine("Ejercicio 4");

const string input2 = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

//for quantity
int openSpan = input2.IndexOf("<span>");
int closeSpan = input2.IndexOf("</span>");
quantity = input2.Substring(openSpan + 6, closeSpan - openSpan - 6);

// for output
output = input2.Replace("<div>", ""); // tb puede hacerse con Remove()
output = output.Replace("</div>", "");
output = output.Replace("&trade;", "&reg;");

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine(output);