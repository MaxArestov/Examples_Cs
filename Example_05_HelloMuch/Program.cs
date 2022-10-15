Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "максим")
{
    Console.WriteLine("Приветствую тебя, дружище!");
}
else
{
    Console.Write("Здравствуй,");
    Console.WriteLine(username);
}