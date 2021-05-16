using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.IO;

namespace Laba_3
{
    public partial class Form6 : Form
    {
        private static IOrderedEnumerable<Bank_Account> sortedByDepositType;
        public Form6()
        {
            InitializeComponent();
        }

        private void сохранитьРезультатПоискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sortedByDepositType.Count() != 0)
            {
                using (FileStream fs = new FileStream("sortByDepositType.json", FileMode.OpenOrCreate))
                {
                    JsonSerializer.SerializeAsync(fs, sortedByDepositType);
                }
                MessageBox.Show("Сохранено удачно");
            }
            else
            {
                MessageBox.Show("Результирующий набор пуст");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string json = File.ReadAllText("bank_account.json");
            if (json != "")
            {
                List<Bank_Account> deserialisationAccount = JsonSerializer.Deserialize<List<Bank_Account>>(json);
                sortedByDepositType = from s in deserialisationAccount
                           orderby s.deposit_Type
                           select s;
                foreach (var acc in sortedByDepositType)
                {
                    richTextBox1.AppendText(
                        $"Имя владельца: {acc.surname} {acc.firstName} {acc.patronymic} \n" +
                        $"Дата рождения: {acc.birth_Date}\n" +
                        $"Данные паспорта: {acc.passport_Data}\n" +
                        $"Номер счёта: {acc.number}\n" +
                        $"Тип вклада: {acc.deposit_Type}\n" +
                        $"Баланс: {acc.balance} BYN\n" +
                        $"Дата открытия счёта: {acc.opening_Date}\n" +
                        $"СМС-оповещения: {acc.Check_SMS()}\n" +
                        $"Интернет-банкинг: {acc.Check_Banking()}\n##############################################\n"
                        );
                }
            }
            else
            {
                richTextBox1.AppendText("Файл пуст");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string json = File.ReadAllText("bank_account.json");
            if (json != "")
            {
                List<Bank_Account> deserialisationAccount = JsonSerializer.Deserialize<List<Bank_Account>>(json);
                var sort = from s in deserialisationAccount
                           orderby s.deposit_Type
                           descending
                           select s;
                foreach (var acc in sort)
                {
                    richTextBox1.AppendText(
                        $"Имя владельца: {acc.surname} {acc.firstName} {acc.patronymic} \n" +
                        $"Дата рождения: {acc.birth_Date}\n" +
                        $"Данные паспорта: {acc.passport_Data}\n" +
                        $"Номер счёта: {acc.number}\n" +
                        $"Тип вклада: {acc.deposit_Type}\n" +
                        $"Баланс: {acc.balance} BYN\n" +
                        $"Дата открытия счёта: {acc.opening_Date}\n" +
                        $"СМС-оповещения: {acc.Check_SMS()}\n" +
                        $"Интернет-банкинг: {acc.Check_Banking()}\n##############################################\n"
                        );
                }
            }
            else
            {
                richTextBox1.AppendText("Файл пуст");
            }
        }
    }
}
