using System;
using System.Media;
using System.Threading;

class CybersecurityChatbot
{
    static void Main()
    {
        PlayGreeting();
        DisplayAsciiLogo();
        GreetUser();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n═════════════════════════════════════════════");
        Console.WriteLine("Here are Cybersecurity Tips you should know:\n");
        Console.WriteLine("═════════════════════════════════════════════\n");

        ProvidePasswordSafetyTips();
        ProvidePhishingAwarenessTips();
        ProvideSafeBrowsingTips();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n═════════════════════════════════════════════");
        Console.WriteLine("Let's test your knowledge on cybersecurity threats.\n");
        Console.WriteLine("═════════════════════════════════════════════\n");

        AskPhishingQuestion();
        AskPasswordQuestion();
        AskSuspiciousLinkQuestion();
        AskSocialEngineeringQuestion();
        AskPublicWiFiQuestion();

        Console.WriteLine("\nThank you for participating! Stay safe online.");
    }

    static void PlayGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("greeting.wav");
            player.PlaySync();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error playing greeting: " + e.Message);
        }
    }

    static void DisplayAsciiLogo()
    {
        string asciiLogo = @"
        ╔════════════════════════════════╗
        ║  CYBERSECURITY AWARENESS BOT   ║
        ║ [🔒 Secure Your Digital Life 🔒] ║
        ╚════════════════════════════════╝";

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(asciiLogo);
        Console.ResetColor();
        Thread.Sleep(1500);
    }



    static void GreetUser()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n═════════════════════════════════════════════");
        Console.WriteLine("\nHello! Welcome to the Cybersecurity Awareness Chatbot.");
        Console.WriteLine("═════════════════════════════════════════════\n");
        Console.ResetColor();
        Console.Write("What's your name? ");
        string name = Console.ReadLine()?.Trim() ?? "Guest";
        Console.WriteLine($"Nice to meet you, {name}!\n");

        Console.Write("Is this your first time hearing about cybersecurity? (yes/no): ");
        string response = Console.ReadLine()?.ToLower() ?? "no";
        if (response == "yes")
        {
            Console.WriteLine("\nThat's great! You're about to learn some important cybersecurity tips.\n");
        }
        else
        {
            Console.WriteLine("\nAwesome! Let's refresh your knowledge on cybersecurity.\n");
        }
    }

    static void ProvidePasswordSafetyTips()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nPassword Safety Tips");
        Console.ResetColor();
        Console.WriteLine("Passwords are the first line of defense for your online security.");
        Console.WriteLine("a. Use at least 12 characters with a mix of letters, numbers, and symbols.");
        Console.WriteLine("b. Use a unique password for each account.");
        Console.WriteLine("c. Consider using a password manager.");
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }

    static void ProvidePhishingAwarenessTips()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nPhishing Awareness");
        Console.ResetColor();
        Console.WriteLine("Phishing is when attackers try to trick you into revealing personal information.");
        Console.WriteLine("a. Be cautious of emails or messages that create a sense of urgency.");
        Console.WriteLine("b. Never click on suspicious links.");
        Console.WriteLine("c. Always verify the source of emails.");
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }

    static void ProvideSafeBrowsingTips()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nSafe Browsing Tips");
        Console.ResetColor();
        Console.WriteLine("a. Avoid entering personal information on unknown websites.");
        Console.WriteLine("b. Keep your antivirus software updated.");
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }

    static void AskPhishingQuestion()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n1. You receive an email from your bank asking you to update your account details by clicking on a link. What do you do?");
        Console.ResetColor();
        Console.WriteLine("    A) Click the link immediately.");
        Console.WriteLine("    B) Verify the email by contacting the bank directly.");
        string choice;
        do
        {
            Console.Write("Enter your choice (A/B): ");
            choice = Console.ReadLine()?.ToUpper();

            if (choice != "A" && choice != "B")
            {
                Console.WriteLine("Invalid choice. Please enter A or B.");
            }
        } while (choice != "A" && choice != "B");

        if (choice == "A")
            Console.WriteLine("\nWarning: This could be a phishing attempt! Always verify with your bank before clicking on any suspicious links.");
        else if (choice == "B")
            Console.WriteLine("\nGreat choice! Verifying with the bank directly helps prevent phishing scams.");
    }

    static void AskPasswordQuestion()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n2. Which of these passwords is the most secure?");
        Console.ResetColor();
        Console.WriteLine("    A) Password123");
        Console.WriteLine("    B) P@$$w0rd");
        Console.WriteLine("    C) Yt6$h&9m!LrQ");
        string choice;
        do
        {
            Console.Write("Enter your choice (A/B/C): ");
            choice = Console.ReadLine()?.ToUpper();

            if (choice != "A" && choice != "B" && choice != "C")
            {
                Console.WriteLine("Invalid choice. Please enter A, B, or C.");
            }
        } while (choice != "A" && choice != "B" && choice != "C");

        if (choice == "A" || choice == "B")
            Console.WriteLine("\nWeak password! Always use long, unique passwords with a mix of letters, numbers, and symbols.");
        else if (choice == "C")
            Console.WriteLine("\nExcellent! Strong passwords help keep your accounts secure.");
    }

    static void AskSuspiciousLinkQuestion()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n3. You receive a message from an unknown number saying you won a prize and need to click a link to claim it. What do you do?");
        Console.ResetColor();
        Console.WriteLine("    A) Click the link to claim the prize.");
        Console.WriteLine("    B) Ignore the message and report it as spam.");
        string choice;
        do
        {
            Console.Write("Enter your choice (A/B): ");
            choice = Console.ReadLine()?.ToUpper();

            if (choice != "A" && choice != "B")
            {
                Console.WriteLine("Invalid choice. Please enter A or B.");
            }
        } while (choice != "A" && choice != "B");

        if (choice == "A")
            Console.WriteLine("\nWarning: This is a common scam! Never click on suspicious links.");
        else if (choice == "B")
            Console.WriteLine("\nWell done! Ignoring and reporting such messages helps protect against scams.");
    }

    static void AskSocialEngineeringQuestion()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n4. A caller claims to be from IT support and asks for your password to fix an issue. What do you do?");
        Console.ResetColor();
        Console.WriteLine("    A) Give them your password.");
        Console.WriteLine("    B) Refuse and verify with IT.");
        string choice;
        do
        {
            Console.Write("Enter your choice (A/B): ");
            choice = Console.ReadLine()?.ToUpper();

            if (choice != "A" && choice != "B")
            {
                Console.WriteLine("Invalid choice. Please enter A or B.");
            }
        } while (choice != "A" && choice != "B");

        if (choice == "A")
            Console.WriteLine("\nNever share your password! Legitimate IT support will never ask for it.");
        else if (choice == "B")
            Console.WriteLine("\nGood job! Always verify with your IT department.");
    }

    static void AskPublicWiFiQuestion()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n5. You need to check your bank account, but you're using free public Wi-Fi. What should you do?");
        Console.ResetColor();
        Console.WriteLine("    A) Log in anyway, it's convenient.");
        Console.WriteLine("    B) Use a VPN or wait until you're on a secure network.");
        string choice;
        do
        {
            Console.Write("Enter your choice (A/B): ");
            choice = Console.ReadLine()?.ToUpper();

            if (choice != "A" && choice != "B")
            {
                Console.WriteLine("Invalid choice. Please enter A or B.");
            }
        } while (choice != "A" && choice != "B");

        if (choice == "A")
            Console.WriteLine("\nPublic Wi-Fi is not secure! Avoid accessing sensitive accounts in public networks.");
        else if (choice == "B")
            Console.WriteLine("\nSmart choice! A VPN adds security, and using a trusted network is always best.");
    }
}
