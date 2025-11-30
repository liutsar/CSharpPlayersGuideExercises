int user1Number;
int user2Number;

do
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    user1Number = Convert.ToInt32(Console.ReadLine());
} while (user1Number is < 0 or > 100);

Console.Clear();

Console.Write("User 2, guess the number.\n");

do
{
    Console.Write("What is your guess? ");
    user2Number = Convert.ToInt32(Console.ReadLine());
    if (user2Number < user1Number) Console.WriteLine(user2Number + " is too low");
    else if (user2Number > user1Number) Console.WriteLine(user2Number + " is too high");
    else if (user2Number == user1Number) Console.WriteLine("You guessed the number!");
} while (user2Number != user1Number);