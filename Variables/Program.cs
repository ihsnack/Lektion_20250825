/*
 PascalCase
camelCase
snake-case
kebab-case

Solutions PscalCase
Project PascalCase
Class PascalCase
Method PascalCase
Property PascalCase

field camelCase
variable camelCase/snake_case

datatyper
------------
char endast ett tecken
string textsträngar

int heltal (integer)
double decimaltal
decimcal decimaltal
float decimaltal
bool sant/falskt (boolean)
long
Guid unika idn
null


*/

// var firstName = "Igor";
// var lastName = "Hallingbäck Smurawa";
//// var numberOfPeopleToExit = 5;
//var number_of_people_to_exit = 6;


// Console.WriteLine(sum);


// Console.WriteLine(sum2);

// 16bit short value = short.MaxValue;
// 32bit int value = int.MaxValue;
// 32bit uint value3 = uint.MaxValue;
// 32bit float sum2 = 0.1F + 0.1F + 0.1F;
// 64bit long value4 = long.MaxValue;
// 64bit double decimal
// 128bit decimal sum = 0.1M + 0.1M + 0.1M;

// GUID Global Unique Identifier

// DateTime Datum/Tid

// null ingenting

/*
    CreateUserAsync_Should_CreateNewUser_ReturnsTrue 
*/

//Guid id = Guid.NewGuid();

//Console.WriteLine(id);

//var datetime = DateTime.Now.Year;
//var dueDate = DateTime.Now.AddDays(30);

//Console.Write(dueDate);

//var value = string.Empty;


//  Grundläggande C# - Variabler och Datatyper
//// dsahttps://www.youtube.com/watch?v=FrEHPbo1bj0

//const string firstName = "Igor";

//firstName = "Anders";
//var firstName = "Anders";

//var pi = 3.14; // double
//var firstName = "Hans"; // string

//string lastName = "Hallingbäck Smurawa"; // string

//var pi = 3.14; // float

//Console.WriteLine(pi);

//double pi2 = 3.14;

//Console.WriteLine(pi2);

//using System.Text.Json.Nodes;
//using Newtonsoft.Json;

//dynamic data = JsonConvert.DeserializeObject<dynamic>(payload);

//dynamic result = await http.GetFromJasonAsync<dynamic>("dsahttps://jsonplaceholder.typicode.com/todos/1");

//object data = 42;

//int number = (int)data;

// Värdetyper läggs på stacken. Stacken är som närtidsminnet, snabb och enkel åtkomst. Bara ett visst utrymme för våra värdetyper på stacken.
// Samma sak om RAM minnet; 8GB, 16GB. Förbrukar minne långsamt. Om du använder för mycket flödar det över. Stack Overflow.

// Referenstyper kallas för heapen.
// Refenstyper tungrodda, avancerade, komplex struktur. Tar större plats och är lite långsammare.
// Som vårat långtidsminne. Vi lagrar under längre tid. Hårddisk. Sparar ner en fil. Mycket mer utrymme. 512GB.


//string FirstName = "Igor";

//string LastName = "Hallingbäck Smurawa";

//string greeting = $"Hej {FirstName} {LastName}!";

//Console.WriteLine(greeting);

//string fileName = "ConsoleApp.csproj";
//string filePath = "C:\\Projects\\DataTypes\\ConsoleApp.csproj \n \t";
//string filePath2 = @"C:\Projects\DataTypes\{fileName}";
//string filePath3 = @$"C:\Projects\DataTypes\{fileName}";

//string fileName = "Program.cs";
//string folderPath = @$"C:\Projects\DeclaringVariables\Using_strings";


//string filePath = Path.Combine(folderPath, fileName);

//Console.WriteLine(filePath);

//string fileName = "Program.cs";
//string projectName = "Using_strings";
//string folderPath = @$"C:\Projects\DeclaringVariables";


//string filePath = Path.Combine(folderPath, projectName, fileName);

//Console.WriteLine(filePath);

//dhttps://www.youtube.com/watch?v=FrEHPbo1bj0 37:06

//string fileName = "Program.cs";
//string projectName = "Using_strings";
//string folderPath = @$"C:\Projects\DeclaringVariables";


//string filePath = Path.Combine(folderPath, projectName, fileName);

//Console.WriteLine(filePath);
//string fileName = "Program.cs";
//string projectName = "Using_strings";
//string folderPath = @$"C:\Projects\DeclaringVariables";


//string filePath = Path.Combine(folderPath, projectName, fileName);

//Console.WriteLine(filePath);

//int fileNumber = 123;
//var fileName = "File_";

//var newFileName = $"{fileName}{fileNumber}";

//Console.WriteLine(newFileName);

//string firstName = "Igor  ";
//string lastName = "Hallingbäck Smurawa";
//string domainName = "example.com";

//firstName = firstName.Trim().ToLower();
//lastName = lastName.Trim().ToLower().Replace("ä", "a").Replace(" ", ".");


//string email = $"{firstName}.{lastName}@{domainName}";



// int ett 32 bitars heltal
// uint ett 32 bitars heltal utan tecken
// long ett 64 bitars heltal
// ulong ett 64 bitars heltal utan tecken
// short ett 16 bitars heltal med tecken
// ushort ett 16 bitars heltal utan tecken
// byte ett 8 bitars heltal utan tecken
// sbyte ett 8 bitars heltal med tecken
// float ett 32 bitars flyttal. Precision ungefär 6-9 siffror.
// double ett 64 bitars flyttal. Precision ungefär 15-17 siffror.
// decimal ett 128 bitars flyttal. Precision ungefär 28-29 siffror. Används främst för ekonomiska beräkningar där precision är viktigt.

// float number = 0.1234567F;
// float number = 0.123456789F;
// double number = 0.12345678911;
// decimal number = 0.12345678911M;


// float number = 0.1F + 0.1F + 0.1F;
// decimal number = 0.1M + 0.1M + 0.1M;
// double number = 0.1 + 0.1 + 0.1; // Använd inte
// decimal number = 0.1M + 0.1M + 0.1M ; // Använd inte

// Console.WriteLine($"number: {number}");
// Console.ReadKey();

// DateTime.Now; // Datum och tid just nu

// DateTime.Today; // Datum idag utan tid

// DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // Formaterad datum och tid

// DateTime.Now.AddDays(30); // Datum och tid 30 dagar framåt

//int int_number = 100;
//string string_number = "100";
//string string_age = Console.ReadLine()!;
//int age = int.Parse(string_age);

//Console.WriteLine();
//Console.ReadKey();

//int int_number = 100;
//string string_number = "100";
//Console.Write("Enter your age: ");
//string string_age = Console.ReadLine()!;

//bool couldParse = int.TryParse(string_age, out int age);

//Console.WriteLine(couldParse);
//Console.ReadKey();

//Console.Write("Enter your age: ");
//string string_age = Console.ReadLine()!;

//double double_number = 100.58;
//int number = (int)double_number;

//Console.WriteLine(number);
//Console.ReadKey();