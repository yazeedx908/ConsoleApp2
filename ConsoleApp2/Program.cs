line1:
Console.WriteLine("ENTER WHAT YOU NEED");
var job = Console.ReadLine();
if (job == "+")
{
    Console.WriteLine("enter value1");
    var value1 = int.Parse(Console.ReadLine());
    Console.WriteLine("enter value2");
    var value2 = int.Parse(Console.ReadLine());
    var result = value1 + value2;
    Console.WriteLine("value1 + value 2 = " + result);


}
if (job == "-")
{
    Console.WriteLine("enter value1");
    var value1 = int.Parse(Console.ReadLine());
    Console.WriteLine("enter value2");
    var value2 = int.Parse(Console.ReadLine());
    var result = value1 + value2;
    Console.WriteLine("value1 - value 2 = " + result);


}
if (job == "/")
{
    Console.WriteLine("enter value1");
    var value1 = int.Parse(Console.ReadLine());
    Console.WriteLine("enter value2");
    var value2 = int.Parse(Console.ReadLine());
    var result = value1 + value2;
    Console.WriteLine("value1 / value 2 = " + result);


}
if (job == "*")
{
    Console.WriteLine("enter value1");
    var value1 = int.Parse(Console.ReadLine());
    Console.WriteLine("enter value2");
    var value2 = int.Parse(Console.ReadLine());
    var result = value1 + value2;
    Console.WriteLine("value1 * value 2 = " + result);


}
if (job == "text")
{
    Console.WriteLine("do you want to read or write");
    var selection = Console.ReadLine();
    if (selection == "read")
    {
        var notetext = System.IO.File.ReadAllText("note.txt");
        Console.WriteLine(notetext);
    }
    if (selection == "write")
    {
        Console.WriteLine("plees enter ");
        var entry = Console.ReadLine();
        System.IO.File.AppendAllText("note.txt", entry + "/n");
    }
}
goto line1;