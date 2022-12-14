Console.WriteLine("Ведите имя пльзователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "инна")
{
    Console.WriteLine("О! Это же Инна! Привет!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}