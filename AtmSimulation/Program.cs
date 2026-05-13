Console.WriteLine("Welcome to World Bank ATM\n");
Console.WriteLine("Please Select Your Account Type: ");
Console.WriteLine("1. International");
Console.WriteLine("2. Domestic");

int accountType, operationType, accountPin, withdrawAmount, depositeAmount, newAtmPin;
double currentBalance = 19870.79;

if(!int.TryParse(Console.ReadLine(), out accountType) || (accountType != 1 && accountType != 2))
{
    Console.WriteLine("Transaction Canceld. Please Select a valid option");
    return;
}

Console.WriteLine("Please Enter your 4 digits PIN");
if(!int.TryParse(Console.ReadLine(), out accountPin))
{
    Console.WriteLine("Transaction Canceld. Invalid PIN");
    return;
}

Console.WriteLine("What you want to do today?");
Console.WriteLine("1. Cash Withdrawal");
Console.WriteLine("2. Cash Deposite"); 
Console.WriteLine("3. Check Balance");
Console.WriteLine("4. Reset ATM PIN");

if (!int.TryParse(Console.ReadLine(), out operationType) || (operationType != 1 && operationType != 2 && operationType != 3 && operationType != 4))
{
    Console.WriteLine("Transaction Canceld. Please Select a valid option");
    return;
}

if(operationType == 1)
{
    Console.WriteLine($"Available Balance: Rs {currentBalance}");
    Console.WriteLine("How much you want to withdraw?");
    if(!int.TryParse(Console.ReadLine(), out withdrawAmount))
    {
        Console.WriteLine("Transaction Canceld. Please enter valid amount");
        return;
    }

    Console.WriteLine("Withdrawal Successful. Please collect your cash");

    Console.WriteLine($"Available Balance: Rs {currentBalance - withdrawAmount}");

} else if(operationType == 2)
{
    Console.WriteLine("Enter amount you want to deposite.");
    if(!int.TryParse(Console.ReadLine(), out depositeAmount))
    {
        Console.WriteLine("Transaction Canceld. Please enter valid amount");
        return;
    }

    Console.WriteLine($"Available Balance: Rs {currentBalance + depositeAmount}");

} else if(operationType == 3)
{
    Console.WriteLine($"Available Balance: Rs {currentBalance}");

} else if(operationType == 4)
{
    Console.WriteLine("Please enter your NEW 4 digit pin");
    if(!int.TryParse(Console.ReadLine(), out newAtmPin))
    {
        Console.WriteLine("Transaction Canceld. Please enter valid 4 digit pin");
        return;
    }

    Console.WriteLine("PIN reset successful");

}