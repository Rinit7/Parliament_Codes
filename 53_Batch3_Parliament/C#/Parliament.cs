//Author:Swanit Rivankar
//RollNo:2452
//Title:Parliament of India
//Start Date:9 July 2024
//Modified Date:27 July 2024
//Description:This program is implementing the working of parliament of India. It contains various classes to add members to Rajya Sabha and Lok Sabha and also to add the President.

using System;

public struct Member
{
    public string Name;
    public string Party;
}

public class Loksabha
{
    public Member[] Members = new Member[552];
    public int C = 0;

    public void EnterLokMembers()
    {
        Console.WriteLine("Enter the number of members you want to enter (Max 552):");
        if (int.TryParse(Console.ReadLine(), out C) && C <= 552 && C > 0)
        {
            Console.WriteLine("Enter the Members:");
            for (int i = 0; i < C; i++)
            {
                Console.Write($"Enter member {i + 1} name: ");
                Members[i].Name = Console.ReadLine();
                Console.Write($"Enter member {i + 1} party: ");
                Members[i].Party = Console.ReadLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid number of members. Please enter a number between 1 and 552.");
            C = 0;
        }
    }

    public void ShowDetails()
    {
        Console.WriteLine("Loksabha Details\nMaximum members: 552\nTerm: 5 Years\nRole: Represents the people of India\n");
    }

    public void ShowMemberDetails()
    {
        if (C == 0)
        {
            Console.WriteLine("No members to display.");
        }
        else
        {
            Console.WriteLine("Loksabha Members:");
            for (int i = 0; i < C; i++)
            {
                Console.WriteLine($"Member: {Members[i].Name}, Party: {Members[i].Party}");
            }
        }
    }
}

public class Rajyasabha
{
    public Member[] Members = new Member[250];
    public int C = 0;

    public void EnterRajMembers()
    {
        Console.WriteLine("Enter the number of members you want to enter (Max 250):");
        if (int.TryParse(Console.ReadLine(), out C) && C <= 250 && C > 0)
        {
            Console.WriteLine("Enter the Members:");
            for (int i = 0; i < C; i++)
            {
                Console.Write($"Enter member {i + 1} name: ");
                Members[i].Name = Console.ReadLine();
                Console.Write($"Enter member {i + 1} party: ");
                Members[i].Party = Console.ReadLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid number of members. Please enter a number between 1 and 250.");
            C = 0;
        }
    }

    public void ShowDetails()
    {
        Console.WriteLine("Rajyasabha Details\nMaximum members: 250\nTerm: 6 Years\nRole: Represents the states and union territories\n");
    }

    public void ShowMemberDetails()
    {
        if (C == 0)
        {
            Console.WriteLine("No members to display.");
        }
        else
        {
            Console.WriteLine("Rajyasabha Members:");
            for (int i = 0; i < C; i++)
            {
                Console.WriteLine($"Member: {Members[i].Name}, Party: {Members[i].Party}");
            }
        }
    }
}

public class President
{
    public string pname;
    public int Year;

    public void EnterPresDetails()
    {
        Console.WriteLine("Enter the name of the President:");
        pname = Console.ReadLine();
        Console.WriteLine("Enter the year:");
        if (!int.TryParse(Console.ReadLine(), out Year))
        {
            Console.WriteLine("Invalid year input.");
            Year = 0;
        }
    }

    public void ShowDetails()
    {
        if (string.IsNullOrEmpty(pname) || Year == 0)
        {
            Console.WriteLine("President details not entered or invalid.");
        }
        else
        {
            Console.WriteLine($"President Details\nName: {pname}\nYear: {Year}\nRole: The president is a part of the parliament and plays a ceremonial role\n");
        }
    }
}

public class Parliament
{
    public static void Main(string[] args)
    {
        Loksabha l1 = new Loksabha();
        Rajyasabha r1 = new Rajyasabha();
        President p1 = new President();

        bool b = true;
        while (b)
        {
            Console.WriteLine("\nEnter Your Choice:\n" +
                              "1: To Enter Loksabha Members\n" +
                              "2: To Enter Rajyasabha Members\n" +
                              "3: To Enter President Details\n" +
                              "4: To display Loksabha Details\n" +
                              "5: To display Rajyasabha Details\n" +
                              "6: To display Loksabha Members\n" +
                              "7: To display Rajyasabha Members\n" +
                              "8: To Show President Details\n" +
                              "9: Exit\n");
            if (int.TryParse(Console.ReadLine(), out int s))
            {
                switch (s)
                {
                    case 1:
                        l1.EnterLokMembers();
                        break;
                    case 2:
                        r1.EnterRajMembers();
                        break;
                    case 3:
                        p1.EnterPresDetails();
                        break;
                    case 4:
                        l1.ShowDetails();
                        break;
                    case 5:
                        r1.ShowDetails();
                        break;
                    case 6:
                        l1.ShowMemberDetails();
                        break;
                    case 7:
                        r1.ShowMemberDetails();
                        break;
                    case 8:
                        p1.ShowDetails();
                        break;
                    case 9:
                        Console.WriteLine("End of code.");
                        b = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}

