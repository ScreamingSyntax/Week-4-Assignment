using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

class BankAccount
    {
    private String accountNumber;
    private decimal balance;
    public BankAccount(String accountNumber) {
        this.accountNumber = accountNumber;
        this.balance = 0;
    }
    public void Display() {
        Console.WriteLine($"Before Deposit {this.balance} $");
        this.Deposit(1000);
        Console.WriteLine($"After Deposit {this.balance} $");
        this.WithDraw(500);
        Console.WriteLine($"After Withdrawl {this.balance} $");
    }
    public void Deposit(decimal Amount) =>
    this.balance += Amount; 
    
    public void WithDraw(decimal Amount) => this.balance -= Amount;
}
