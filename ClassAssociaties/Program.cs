using ClassAssociaties.Shared;

Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("PXL bank");

Bank bank = new Bank { Name = "Class Bank" };

Person person = new Person
{
    FirstName = "John",
    LastName = "Do",
    DateOfBirth = new DateTime(1951, 9, 25),
    IsMan = true
};

Person person2 = new Person
{
    FirstName = "Jane",
    LastName = "Dont",
    DateOfBirth = new DateTime(1956, 10, 21),
    IsMan = false
};

BankAccount account = new BankAccount
{
    Owner = person,
    AccountNumber = "BE123456789"
};

BankAccount account2 = new BankAccount
{
    Owner = person2,
    AccountNumber = "BE987654321"
};

account.AddTransaction(new Transaction(Transaction._types.D, 420.00));
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(account);
Console.ForegroundColor = ConsoleColor.Red;
account.AddTransaction(new Transaction(Transaction._types.C, 25.75));
Console.WriteLine(account);
account.AddTransaction(new Transaction(Transaction._types.C, 9.99));
Console.WriteLine(account);
Console.ForegroundColor = ConsoleColor.Green;
account.AddTransaction(new Transaction(Transaction._types.D, 9.9999));
Console.WriteLine(account);

account2.AddTransaction(new Transaction(Transaction._types.D, 9000));
Console.WriteLine(account2);

bank.AddCustomer(account);
bank.AddCustomer(account2);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Bankkapitaal: {bank.ShowBankCapital()} EUR");

foreach (string customer in bank.GetAllCustomers())
{
    Console.WriteLine($"Klant: {customer}");
}

Console.ReadLine();