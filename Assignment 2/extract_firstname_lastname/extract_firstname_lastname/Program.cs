//extract first name lastname
        Console.Write("Please enter your full name: ");
        string fullName = Console.ReadLine();

        string[] nameParts = fullName.Split(' ');

        if (nameParts.Length >= 2)
        {
            string firstName = nameParts[0];
            string lastName = nameParts[nameParts.Length - 1];

            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
        }
        else
        {
            Console.WriteLine("Please enter both your first and last names separated by a space.");
        }
  