using BankEncapsulation;




BankAccount NewAccount = new BankAccount();



Console.WriteLine("Type the number you want to deposit: ");

double amountDeposited = Convert.ToDouble(Console.ReadLine());

NewAccount.Deposit(amountDeposited);

Console.WriteLine();


Console.WriteLine("Type the number you want to withdraw: ");
double amountWithdrawn = Convert.ToDouble(Console.ReadLine());
NewAccount.Withdraw(amountWithdrawn);



Console.WriteLine($"Your balance: {NewAccount.GetBalance()}");

