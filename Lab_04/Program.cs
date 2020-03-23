/*
 * Lab 4: Statements and Exceptions

11-Proof

The “Eleven Proof” is used to confirm if a given number could be a bank account number.
Assume that a user has entered the following number when prompted for an account number: 123456789


1st digit account number = 1 		9 * 1 =		 9
2nd digit account number = 2 		8 * 2 =		16
3rd digit account number = 3 		7 * 3 =		21
4th digit account number = 4 		6 * 4 =		24
5th digit account number = 5 		5 * 5 =		25
6th digit account number = 6 		4 * 6 =		24
7th digit account number = 7 		3 * 7 =		21
8th digit account number = 8 		2 * 8 =		16
9nd digit account number = 9 		1 * 9 =		 9
						     ------------  +
							165

As 165 can be divided by 11 (165 / 11 = 15 remainder 0 ) 123456789 probably is a valid bank account number

This calculation can be easily performed using a loop. The counter that is used in the loop can be used in most of the calculation that must be done
To isolate individual digits out of the number you can use the  substring method of a  string object.

1.	Create a new Console application.
2.	Let the user input an accountnumber.
3.	Check with the above algorithm whether the number is valid.
4.	Throw an ArgumentException when the number is not valid.
*/

using System;

namespace Lab_04 {
    class Program {
        static void Main(string[] args) {
            elevenProof();
            compoundInterest();
        }

        static void elevenProof() {
            Console.Write("Please enter a account number: ");
            string accountNumber = Console.ReadLine();
            int total = 0;
            string substring;
            for (int loop = 1; loop <= 9; loop++) {
                substring = accountNumber.Substring(loop - 1, 1);
                total += int.Parse(substring) * (10 - loop);
            }
            if (total % 11 == 0) {
                Console.WriteLine("{0} is a valid account number.", accountNumber);
            } else {
                throw new ArgumentException(string.Format("{0} is NOT a valid account number.", accountNumber));
            }
            Console.ReadKey();
        }

        /*
         Compound Interest

Write a program that calculates the number of years it takes to double a certain amount, given a certain interest rate.
For instance if the amount is 1000 and the interest rate is eight percent the amount will double in ten years.
Assume that compound interest is applied. So each subsequent year the interest rate is applied on the sum of the amount 
and the interest of the previous year.


*/
        static void compoundInterest() {
            int interestRate = 8;
            int initialAmount = 1000;
            int numberOfYears = 0;
            int currentAmount = initialAmount;
            while (currentAmount< (2*initialAmount)) {
                numberOfYears++;
                int interest = (currentAmount * interestRate / 100);
                currentAmount = currentAmount + interest;
            }
            Console.WriteLine($"Number Of Years {numberOfYears}, Total Amount: {currentAmount}");
            Console.ReadLine();
        }
    }
}
