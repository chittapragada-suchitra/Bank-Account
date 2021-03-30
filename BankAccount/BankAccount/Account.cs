using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        public int accNo { get; set; }
        public string accHolderName { get; set; }
        public long mobile { get; set; }
        public int balance { get; set; }

        static int minBalance = 100;

        public void GetAccount(int AccNo, string AccHolderName, long Mobile, int Balance)
        {
            this.accNo = AccNo;
            this.accHolderName = AccHolderName;
            this.mobile = Mobile;
            this.balance = Balance;

        }


        public void Deposit(int amount)
        {
            balance = balance + amount;
        }


        public void WithDraw(int amount)
        {
            balance = balance - amount;
        }



        public void TransferAmount(Account receiver, int Tamount)
        {

            if (balance - Tamount < minBalance)
            {
                //throw new InsufficientAmountException();

            }
            WithDraw(Tamount);
            receiver.Deposit(Tamount);

        }



        public class InsufficientAmountException : ApplicationException
        { }


        public void GetAccount()
        {

        }
    }
}
