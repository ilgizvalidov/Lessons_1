﻿Console.WriteLine("Введите имя пользователя");
string userName = Console.ReadLine ();

if (userName.ToLower()=="маша")
{
    Console.WriteLine ("Ура, этоже Маша!"); 
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}