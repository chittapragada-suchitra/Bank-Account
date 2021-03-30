using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class TestTransaction
    {
        [TestCase]
        public void GetAccount()
        {
            Account sender = new Account();
            sender.GetAccount(1212, "John", 8569522226, 10000);

        }

        [TestCase]
        public void Deposit()
        {
            Account sender = new Account();
            sender.Deposit(2000);
        }
        [TestCase]
        public void WithDraw()
        {
            Account sender = new Account();
            sender.WithDraw(1000);

        }

        [TestCase]
        public void TransferAmount()
        {
            Account sender = new Account();
            Account receiver = new Account();
            sender.TransferAmount(receiver, 500);



            // Assert.AreEqual(500, receiver.balance);
            //Assert.AreEqual(500, sender.balance);

        }
    }
}
