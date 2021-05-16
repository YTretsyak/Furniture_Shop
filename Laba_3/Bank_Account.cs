using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Laba_3
{
    public class Bank_Account
    {
        [NumberAttribute]
        public string number { get; set; }
        public string deposit_Type { get; set; }
        public string balance { get; set; }
        public string opening_Date { get; set; }
        public bool SMS_notification { get; set; }
        public bool internet_Banking { get; set; }
        public string surname { get; set; }
        public string firstName { get; set; }
        public string patronymic { get; set; }
        public string birth_Date { get; set; }
        public string passport_Data { get; set; }
        
        public Bank_Account()
        {
            
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
    public class NumberAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string number = value.ToString();
                if (!number.StartsWith("0"))
                    return true;
                else
                    this.ErrorMessage = "Номер не должен начинаться с цифры 0";
            }
            return false;
        }
    }
}

