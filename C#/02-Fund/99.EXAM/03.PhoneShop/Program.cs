using System;
using System.Collections.Generic;
using System.Linq;

public class PhoneStorage
{
    private readonly List<string> phoneList;

    public PhoneStorage(string initialPhones)
    {
        phoneList = initialPhones.Split(", ").ToList();
    }

    public void ProcessCommand(string command)
    {
        var parts = command.Split(" - ");

        if (parts.Length != 2)
        {
            return; // Ignore invalid commands silently
        }

        var action = parts[0];
        var phone = parts[1];

        switch (action)
        {
            case "Add":
                AddPhone(phone);
                break;
            case "Remove":
                RemovePhone(phone);
                break;
            case "Bonus phone":
                BonusPhone(phone);
                break;
            case "Last":
                MovePhoneLast(phone);
                break;
        }
    }

    private void AddPhone(string phone)
    {
        if (!phoneList.Contains(phone))
        {
            phoneList.Add(phone);
        }
    }

    private void RemovePhone(string phone)
    {
        phoneList.Remove(phone);
    }

    private void BonusPhone(string phone)
    {
        var parts = phone.Split(":");
        var oldPhone = parts[0];
        var newPhone = parts[1];

        if (phoneList.Contains(oldPhone))
        {
            var index = phoneList.IndexOf(oldPhone);
            phoneList.Insert(index + 1, newPhone);
        }
    }

    private void MovePhoneLast(string phone)
    {
        if (phoneList.Remove(phone))
        {
            phoneList.Add(phone);
        }
    }

    public void PrintPhones()
    {
        Console.WriteLine(string.Join(", ", phoneList));
    }

    public static void Main(string[] args)
    {
        var initialPhones = Console.ReadLine();

        var storage = new PhoneStorage(initialPhones);

        while (true)
        {
            var command = Console.ReadLine();
            if (command == "End")
            {
                break;
            }

            storage.ProcessCommand(command);
        }

        storage.PrintPhones();
    }
}
