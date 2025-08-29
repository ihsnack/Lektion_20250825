//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//string[] names = new string[3];

//names[0] = "Igor";
//names[1] = "Anders";
//names[2] = "Hans";



//foreach (var name in names)
//{
//    Console.WriteLine(name);
//}

//Console.ReadKey();

//string[] names = ["Igor", "Anders", "Hans"];

//Array.Sort(names);

//foreach (var name in names)
//{
//    Console.WriteLine(name);
//}

//List<string> names = new List<string>();

//List<string> numbers = new();

//List<string> names2 = [];

//var customers = new List<Customer>();


//List<string> names = new List<string>();

//List<string> numbers = new();

//List<string> names2 = [];

//var customers = new List<Customer>();

//List<string> names = [];

//names.Add("Anders");
//names.Add("Igor");

//names.Reverse();

//foreach (var name in names)
//{
//    Console.WriteLine(name);
//}


//Console.WriteLine(names.Any());
//Console.WriteLine(names.Any(e => e == "Eva"));
//Console.WriteLine(names.Count());
//Console.WriteLine(names.Contains("Igor"));


//List<string> names2 = [];

//IEnumerable<string> names = names2;  


//Console.WriteLine("Enter a name to search for:");


List<string> databaseList = [];
databaseList.Add("Anders");
databaseList.Add("Igor");

IEnumerable<string> inMemorylist = databaseList;

foreach (var name in inMemorylist)
{
    Console.WriteLine(name);
}

//IEnumerable<string> names = names2;


//Console.WriteLine("Enter a name to search for:");