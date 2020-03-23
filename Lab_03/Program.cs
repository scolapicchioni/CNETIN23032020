/*
 * Lab 3: Creating UserDefined Types
1.	Create a new Console Application.
2.	Create a new enum: “AccountType” with two values: “Checkings” and “Savings”.
3.	Create a new structure: “BankAccount”.
4.	A BankAccount consists of the following members:
a.	AccountNumber: string.
b.	Balance: decimal.
c.	AccountType: AccountType.
5.	Now create two accounts in the main method, one checkings account and one savingsaccount.
6.	Let the user input the account number in the console window for the new accounts by using the Console.ReadLine method.

 */
using System;

namespace Lab_03 {
    class Program {
        static void Main(string[] args) {
            BankAccount b1 = new BankAccount();
            b1.Id = 5;

            BankAccount b2 = b1;
            b1.Id = 6;

            Console.WriteLine(b1.Id);
            Console.WriteLine(b2.Id);
        }
    }
}
