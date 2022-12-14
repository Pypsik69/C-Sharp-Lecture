Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "султан") //Модуль ToLower позволяет писать имя с любого регистра 
{
    Console.WriteLine("Ура, это же Султик !");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}