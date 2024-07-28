using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Transfer
    {
        //properties
        ConnectionTransfer datatransfer = new ConnectionTransfer();

        public int ID;
        public int sender;
        public int recipient;
        public string date;
        public int amount;
        public int Auto;

        public Transfer() { }

        public Transfer(int _id, int _sender, int _recipient, string _date, int _amount, int _auto) { 
            this.ID = _id;
            this.sender = _sender;
            this.recipient = _recipient;
            this.date = _date;
            this.amount = _amount;  
            this.Auto = _auto;
        }

        //methods
        public int CreateTransfer()
        {
            datatransfer.InsertTransfer(this);
            return 1;
        }

        public int trasnferfunction(Account SenderAcc, Account RecipientAcc, int amount)
        {
            SenderAcc.Balance = SenderAcc.AccountBalance();
            RecipientAcc.Balance = RecipientAcc.AccountBalance();
            if (amount > SenderAcc.Balance) { MessageBox.Show("This account's balance is too low, try another account."); return -1; }
            else
            {
                SenderAcc.Balance -= amount;
                RecipientAcc.Balance += amount;
                SenderAcc.UpdateBalance();
                RecipientAcc.UpdateBalance();
                DateTime datetime = DateTime.Now;
                string date = datetime.ToString("yyyy-MM-dd");
                Transfer transfer = new Transfer();
                transfer.sender = SenderAcc.AccountNum; transfer.recipient = RecipientAcc.AccountNum; transfer.date = date; transfer.amount = amount;
                transfer.CreateTransfer();
                return 1;

            }
        }
    }
}
