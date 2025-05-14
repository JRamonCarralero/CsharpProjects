int[] numbers = { 4, 8, 15, 16, 23, 42 };

int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
        found = true;

}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

Random random= new Random();
int value = random.Next(1, 100);

Console.WriteLine("Valor: " + value);
Console.WriteLine(value > 50 ? "Cara" : "Cruz");


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate"; // sirve para los dos valores case 100 y case 200
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch(product[0])
{
    case "01":
        type = "Sweat shirt";
        break ;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch(product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

// break
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}

//arrays
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

string[] names2 = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names2.Length; i++)
    if (names2[i] == "David") names2[i] = "Sammy";

foreach (var name in names2) Console.WriteLine(name); 

// FizzBuzz

for (int i = 1; i<=100; i++)
{
    if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
    else if (i % 3 == 0) Console.WriteLine("Fizz");
    else if (i % 5 == 0) Console.WriteLine("Buzz");
    else Console.WriteLine(i);
}

// while & do while
Random random2 = new Random();
int current = 0;

do
{
    current = random2.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue; // salta a la siguiente iteración, no ejecuta el Console.WriteLine

    Console.WriteLine(current);
} while (current != 7);


Console.WriteLine("Press the Enter key to continue (Rol Game)");
Console.ReadLine();

// Juego de rol

int monsterLife = 10;
int playerLife = 10;
int damage = 0;

Random random3 = new Random();

do
{
    damage = random3.Next(1, 11);
    monsterLife -= damage;
    Console.WriteLine($"Player damage: {damage}");
    Console.WriteLine($"Monster life: {monsterLife}");

    if (monsterLife <= 0) continue;

    damage = random3.Next(1, 11);
    playerLife -= damage;
    Console.WriteLine($"Monster damage: {damage}");
    Console.WriteLine($"Player life: {playerLife}");
} while (monsterLife > 0 && playerLife > 0);

if (playerLife > 0) Console.WriteLine("You win!");
else Console.WriteLine("You lose!");


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

// read entry

string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);

Console.WriteLine($"You entered: {readResult}");


Console.WriteLine("Press the Enter key to continue (read integer)");
Console.ReadLine();

// read integer

Console.WriteLine("Enter an integer between 5 and 10:");
string? readResult2;
int number2 = 0;
bool validEntry2 = false;
do
{
    readResult2 = Console.ReadLine();
    if (readResult2 != null)
    {
        if (int.TryParse(readResult2, out number2))
        {
            if (number2 >= 5 && number2 <= 10)
            {
                validEntry2 = true;
            }
            else
            {
                Console.WriteLine("Your input is invalid, please try again.");
            }
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry2 == false);

Console.WriteLine($"You entered: {number2}");


Console.WriteLine("Press the Enter key to continue (read string)");
Console.ReadLine();

// read string

Console.WriteLine("Introduce un rol (Administrador, Director o Usuario):");
bool validEntry3 = false;
string? readResult3;
string role = "";
do
{
    readResult3 = Console.ReadLine();
    if (readResult3 != null)
    {
        readResult3 = readResult3.Trim().ToLower();
        if (readResult3 == "administrador" || readResult3 == "director" || readResult3 == "usuario")
        {
            role = readResult3;
            validEntry3 = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry3 == false);

Console.WriteLine($"You entered: {role}");


Console.WriteLine("Press the Enter key to continue (string array)");
Console.ReadLine();

// string array

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation;

foreach (string ms in myStrings)
{
    string myString = ms;
    periodLocation = myString.IndexOf('.');
    string newMyString;
    while (periodLocation > -1)
    {
        newMyString = myString.Remove(periodLocation);
        myString = myString.Substring(periodLocation + 1).TrimStart();
        periodLocation = myString.IndexOf('.');
        Console.WriteLine(newMyString);
    }
    newMyString = myString.TrimStart();
    Console.WriteLine(newMyString);
}