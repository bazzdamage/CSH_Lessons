Console.WriteLine("Input your username");
string username = Console.ReadLine();

if(username.ToLower() == "maria")
{
    Console.WriteLine("Hooray, its a Maria");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
