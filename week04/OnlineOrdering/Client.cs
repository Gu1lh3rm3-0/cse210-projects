using System;

public class Client
{
   Address _address = new Address();

   private string _name;
   public string theClient()
   {
    Console.WriteLine(_address.GetAddress);
    string client = $"{_name}";
    return client;
    
   }
}