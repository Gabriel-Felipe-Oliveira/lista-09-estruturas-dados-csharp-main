using System;
using System.Collections;

public class Exercise_02
{
    public void run()
    {
        Hashtable contactInfo = new Hashtable();

        Console.WriteLine("Enter up to 5 CPFs and their respective phone numbers:");

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Enter the CPF of person {i}: ");
            string cpf = Console.ReadLine();

            Console.Write($"Enter the phone number of person {i}: ");
            string phone = Console.ReadLine();

            if (contactInfo.ContainsKey(cpf))
            {
                Console.WriteLine($"The CPF {cpf} is already in the contact info. Please enter another CPF.");
                i--;
            }
            else
            {
                contactInfo[cpf] = phone;
            }
        }

        Console.WriteLine("\nContact Info (CPF and Phone Number):");
        foreach (DictionaryEntry entry in contactInfo)
        {
            Console.WriteLine($"CPF: {entry.Key}, Phone: {entry.Value}");
        }

        while (true)
        {
            Console.Write("\nEnter a CPF to search for its phone number (or type 'exit' to quit): ");
            string searchCPF = Console.ReadLine();

            if (searchCPF.ToLower() == "exit")
                break;

            if (contactInfo.ContainsKey(searchCPF))
            {
                Console.WriteLine($"Phone number for CPF {searchCPF}: {contactInfo[searchCPF]}");
            }
            else
            {
                Console.WriteLine($"CPF {searchCPF} not found in the contact info.");
            }
        }
    }
}
