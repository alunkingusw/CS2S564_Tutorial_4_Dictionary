// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;


Dictionary<string, string> phonebook = new Dictionary<string, string>();

phonebook.Add("Jim", "03214456789");
phonebook.Add("Belle", "01236456123");
phonebook.Add("Elsie", "01478789456");
phonebook.Add("Gary", "01125456853");
phonebook.Add("Bob", "01443123456");
phonebook.Add("Laura", "01443123456");



foreach (KeyValuePair<string, string> kvp in phonebook)
{
    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
}

