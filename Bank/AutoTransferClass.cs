using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class AutoTransferClass
    {
        public string frequency;
        public int Sender;
        public int Recipient;
        public int frequencyNum;
        public int amount;

        public AutoTransferClass() { }

        AutoTransferConnection atdata = new AutoTransferConnection();

        public AutoTransferClass(string frequency, int sender, int recipient, int frequencyNum, int amount)
        {
            this.frequency = frequency;
            this.Sender = sender;
            this.Recipient = recipient;
            this.frequencyNum = frequencyNum;
            this.amount = amount;
        }

        public int CreateAutoTransfer()
        {
            if (this.frequency == "Monthly")
            {
                frequencyNum = frequencyNum * 30;
            }
            else if (this.frequency == "Weekly")
            {
                frequencyNum = frequencyNum * 7;
            }
            int num = atdata.InsertAutoTransfer(this);
            return num;

        }

        public int CheckAutos(DateTime last_transfer, DateTime end_transfer, int ID)
        {
            AutoTransferConnection atc = new AutoTransferConnection();

            DateTime datetime = DateTime.Now;
            if (end_transfer > datetime)
            {
                if (frequency == "Monthly")
                {
                    TimeSpan timeDifference = datetime - last_transfer;
                    int numberOfDays = (int)timeDifference.TotalDays;

                    if (numberOfDays > 30)
                    {
                        Account senderAcc = new Account();
                        Account recipientAcc = new Account();
                        senderAcc.AccountNum = this.Sender;
                        recipientAcc.AccountNum = this.Recipient;
                        Transfer transfer = new Transfer();
                        transfer.trasnferfunction(senderAcc, recipientAcc, this.amount);
                        MessageBox.Show("Your autopayment has been processed.");
                        atc.UpdateAutoTransfer(ID);
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }               
                else if (frequency == "Weekly")
                {
                    TimeSpan timeDifference = datetime - last_transfer;
                    int numberOfDays = (int)timeDifference.TotalDays;

                    if (numberOfDays > 7)
                    {
                        Account senderAcc = new Account();
                        Account recipientAcc = new Account();
                        senderAcc.AccountNum = this.Sender;
                        recipientAcc.AccountNum = this.Recipient;
                        Transfer transfer = new Transfer();
                        transfer.trasnferfunction(senderAcc, recipientAcc, this.amount);
                        MessageBox.Show("Your autopayment has been processed.");
                        atc.UpdateAutoTransfer(ID);
                        return 1;
                    }
                    else { return 0; }
                }
                else if (frequency == "Daily")
                {
                    TimeSpan timeDifference = datetime - last_transfer;
                    int numberOfDays = (int)timeDifference.TotalDays;
                    if (numberOfDays > 0)
                    {
                        Account senderAcc = new Account();
                        Account recipientAcc = new Account();
                        senderAcc.AccountNum = this.Sender;
                        recipientAcc.AccountNum = this.Recipient;
                        Transfer transfer = new Transfer();
                        transfer.trasnferfunction(senderAcc, recipientAcc, this.amount);
                        atc.UpdateAutoTransfer(ID);
                        MessageBox.Show("Your autopayment has been processed.");
                        return 1;
                    }
                    else { return 0; }
                }
                else { return 0; }
            }
            else { atdata.DeleteAutoTransfer(ID); return -1; }
        }
        
    }
}
