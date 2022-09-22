Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "kseni")
{
    Console.WriteLine("Ура это же KSENI!!!");    
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}