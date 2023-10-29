using System;
using System.Collections;

public class Exercise_01
{
    public void run()
    {
        Hashtable contact_info = new Hashtable();

        Console.WriteLine("Enter up to 5 CPFs and their respective phone numbers:");

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Enter the CPF of person {i}: ");
            string cpf = Console.ReadLine();

            Console.Write($"Enter the phone number of person {i}: ");
            string phone = Console.ReadLine();

            if (contact_info.ContainsKey(cpf))
            {
                Console.WriteLine($"The CPF {cpf} is already in the contact info. Please enter another CPF.");
                i--;
            }
            else
            {
                contact_info[cpf] = phone;
            }
        }

        Console.WriteLine("\nContact Info (CPF and Phone Number):");
        foreach (DictionaryEntry entry in contact_info)
        {
            Console.WriteLine($"CPF: {entry.Key}, Phone: {entry.Value}");
        }
    }
}
