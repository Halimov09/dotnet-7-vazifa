// palindrom word 1
Console.Write("soz kiriting: ");
string str = Console.ReadLine();
bool changeStr = false;
string reversedString = new string(str.Reverse().ToArray());

for (int i = 0; i < str.Length; i++)
{
    if (str[i] == reversedString[i])
    {
        changeStr = true;
    }else{
        changeStr = false;
    }
}

if (changeStr == true)
{
    Console.WriteLine($"bu so'z {str} palindrom so'z");
}else{
    Console.WriteLine($"bu so'z {str} palindrom so'z emas");
}




// celcius 2 
Console.Write("enter the celcius: ");
int celcy = Convert.ToInt32(Console.ReadLine());

double fahrenheit = 0;
double kelvin = 0;

fahrenheit = (celcy * 9 / 5 ) + 32;
kelvin = celcy + 273.15;

Console.WriteLine($"celcy: {celcy}, fahrenheit: {fahrenheit}, kelvin: {kelvin}.");






// ascendingg and descanding 3

Console.Write("Enter the number: ");
string strs = Console.ReadLine();
char[] digits = strs.ToCharArray();
var sortedDigits = digits.OrderBy(c => c);
var sortDigits = digits.OrderByDescending(c => c);
string ascendingNumber = string.Join(",", sortedDigits);
string ascenNumber = string.Join(",", sortDigits);

Console.WriteLine(ascendingNumber);
Console.WriteLine(ascenNumber);




// find symbol 4
Console.Write("Matn kiriting: ");
string input = Console.ReadLine();

Dictionary<char, int> charCount = new Dictionary<char, int>();

foreach (char c in input)
{
    if (charCount.ContainsKey(c))
    {
        charCount[c]++;
    }
    else
    {
        charCount[c] = 1;
    }
}

foreach (var item in charCount)
{
    Console.WriteLine($"'{item.Key}': {item.Value} martta");
}