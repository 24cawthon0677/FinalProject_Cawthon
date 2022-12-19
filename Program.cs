/*
 * Program Name: UserInterface
 * Programmer: Mason Cawthon
 * Date: 12/19/2022
 *
 * Description: This program is a take on a User Manager that allows 
 * the user to make a user as an admin or sign in as a normal User.
 */

bool isLooping = false;

// Default Admin Username and Password
const string ADMIN_USERNAME = "Admin";
const string ADMIN_PASSWORD = "67532765213@$#@$#";

List<User> users = new List<User>();
List<Guest> guests = new List<Guest>();
List<Admin> admins = new List<Admin>();

Console.WriteLine("Press 1 to Login.");
Console.WriteLine("Press 2 to create new users.");
string userInput = Console.ReadLine();

if (userInput == "1")
{
    Login();
}
else if (userInput == "2")
{
    CreateUsers();
}
else
{
    Console.WriteLine("Invalid Selection....");
}
CreateUsers();

void Login()
{
    Console.WriteLine("Enter username: ");
    string username = Console.ReadLine();
    Console.WriteLine("Enter password: ");
    string password = Console.ReadLine();

    foreach (User user in users)
    {
        if (user.username == username)
        {
            if (user.password == password)
            {
     
            }
            else
            {
                Console.WriteLine("Invalid Password. ");
                Login();
            }
        }
        else
        {
            Console.WriteLine("Invalid Username. ");
            Login();
        }
    }
}

void CreateUsers()
{
    // Login as Administrator
    Console.WriteLine("Enter an admin username: ");
    string username = Console.ReadLine();
    Console.WriteLine("Enter an admin password: ");
    string password = Console.ReadLine();

    if (username == ADMIN_USERNAME && password == ADMIN_PASSWORD)
    {
        isLooping = true;
    }
    else
    {
        isLooping = false;
        Console.Clear();
        Console.WriteLine("Invalid username or password.");
        CreateUsers();
    }

    while (isLooping)
    {
        // Prompt for username
        Console.WriteLine("Enter a username: ");
        string un = Console.ReadLine();
        // Prompt for Password
        Console.WriteLine("Enter a password: ");
        string pw = Console.ReadLine();
        Console.WriteLine("Press 1 for Generic User");
        Console.WriteLine("Press 2 for a Guest User");
        Console.WriteLine("Press 3 for an Admin User");
        Console.WriteLine("Press 0 to Login");
        int selection = int.Parse(Console.ReadLine());
        Console.Clear();

        if (selection == 1)
        {
            users.Add(new User(un, pw));
            Console.WriteLine(un + " has been created as a Generic User");
        }
    
    }
}

