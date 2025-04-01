// See https://aka.ms/new-console-template for more information

using cu.staticBasics.cons.Entities;
using cu.staticBasics.cons.Extensions;

Console.WriteLine("ExtensionMethods!");
int number = 2;
var result = number.Add(2);
Console.WriteLine(result);
var numbers = new List<int> {1,2,3,4,56,89,78,56,2 };
var average = numbers.CustomAverage();
Console.WriteLine(average);

Console.WriteLine("Benten".GetFirstLetter());

var personRepository = new PersonRepository();
var person = personRepository.GetPersons().First();
Console.WriteLine(person.GetPrefix());
Console.WriteLine(person.GetAge());


