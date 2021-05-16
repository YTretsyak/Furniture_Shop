using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
     class Bank_Account:Abstract_Bank_Account
    {
        public Bank_Account(string Number, string Deposit_Type, string Balance, string Opening_Date, bool sMS_notification, bool Internet_Banking, IOwner owner)
        {
            number = Number;
            deposit_Type = Deposit_Type;
            balance = Balance;
            opening_Date = Opening_Date;
            SMS_notification = sMS_notification;
            internet_Banking = Internet_Banking;
            Owner = owner;
        }
        public Bank_Account()
        {
            
        }

        public override Abstract_Bank_Account clone()
        {
            return new Bank_Account(number, deposit_Type, balance, opening_Date, SMS_notification, internet_Banking, Owner);
        }

        public string Check_SMS() 
        {
            if (SMS_notification) 
            {
                return "Подключено";
            }
            else
            {
                return "Не подключено";
            }
        }
        public string Check_Banking()
        {
            if (internet_Banking)
            {
                return "Подключено";
            }
            else
            {
                return "Не подключено";
            }
        }
     }

    interface IAccount_Builder
    {
        void BuildNumber(string number);
        void BuildDeposit_Type(string deposit_Type);
        void BuildBalance(string balance);
        void BuildOpening_Date(string opening_Date);
        void BuildSMS_Notification(bool SMS_notification);
        void BuildInternet_Banking(bool internet_Banking);
        void BuildOwner(IOwner owner);
        
    }

    class AccountBuilder : IAccount_Builder
    {
        private Bank_Account account = new Bank_Account();

        public void BuildNumber(string Number)
        {
            account.number = Number;
        }

        public void BuildDeposit_Type(string Deposit_Type)
        {
            account.deposit_Type = Deposit_Type;
        }

        public void BuildBalance(string Balance)
        {
            account.balance = Balance;
        }

        public void BuildOpening_Date(string Opening_Date)
        {
            account.opening_Date = Opening_Date;
        }

        public void BuildSMS_Notification(bool sMS_notification)
        {
            account.SMS_notification = sMS_notification;
        }

        public void BuildInternet_Banking(bool Internet_Banking)
        {
            account.internet_Banking = Internet_Banking;
        }

        public void BuildOwner(IOwner owner)
        {
            account.Owner = owner;
        }

        public Bank_Account GetResult()
        {
            return account;
        }

        public void Reset() => account = new Bank_Account();
    }
}
