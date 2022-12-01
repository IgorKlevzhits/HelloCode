Console.Write("Введите имя пользователя: ");
string userName = Console.ReadLine();

if (userName.ToLower() == "masha")
{
    Console.WriteLine("Ура, это же Маша! ");
}
else
{
    Console.WriteLine("Привет,  {0}", userName);
}