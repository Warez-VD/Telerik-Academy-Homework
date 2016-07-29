namespace BankAccounts
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            Console.WriteLine("Sample deposit account");
            var depositAccount = new Deposit(new Individual("Ivan", "Ivanov", 23), 15000.12m, 0.3m, CurrencyType.euro);
            Console.WriteLine($"Balance: {depositAccount.Balance} {depositAccount.Currency}");
            depositAccount.DepositMoney(1200);
            Console.WriteLine($"Balance: {depositAccount.Balance} {depositAccount.Currency}");
            Console.WriteLine($"Interest rate: {depositAccount.InterestAmountForPeriod(4)} %");

            Console.WriteLine(new string('-', 25));

            Console.WriteLine("Sample mortgage account");
            var mortgageAccount = new Mortgage(new Company("Mobiltel"), 25500, 2.4m, CurrencyType.lv);
            Console.WriteLine(mortgageAccount.Owner);
            Console.WriteLine($"Balance: {mortgageAccount.Balance} {mortgageAccount.Currency}");
            var mortgageWithdrawedMoney = mortgageAccount.WithDraw(15000);
            Console.WriteLine($"Balance: {mortgageAccount.Balance} {mortgageAccount.Currency}");
            Console.WriteLine($"Interest rate: {depositAccount.InterestAmountForPeriod(3)} %");

            Console.WriteLine(new string('-', 25));

            Console.WriteLine("Sample loan account");
            var loanAccount = new Loan(new Individual("Anna", "Georgieva", 19), 1250, 0.8m, CurrencyType.dollars);
            Console.WriteLine(loanAccount.Owner);
            Console.WriteLine($"Balance: {loanAccount.Balance} {loanAccount.Currency}");
            var loanWithdrawedMoney = loanAccount.WithDraw(1248);
            Console.WriteLine($"Balance: {loanAccount.Balance} {loanAccount.Currency}");
            Console.WriteLine($"Interest rate: {depositAccount.InterestAmountForPeriod(8)} %");
        }
    }
}
