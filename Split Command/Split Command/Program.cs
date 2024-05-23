        // This program will split Full Name into First and Last Name
        Console.WriteLine("Please enter your full name:");
        string fullName = Console.ReadLine();

        string[] names = fullName.Split(' ');
        string firstName = names[0];
        string lastName = names[1];

        Console.WriteLine($"First Name: {firstName}");
        Console.WriteLine($"Last Name: {lastName}");

        Console.ReadLine();