using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Text.Json;

namespace Laba_3
{
    public partial class Form4 : Form
    {
        private static List<Bank_Account> found = new List<Bank_Account>();
        public Form4()
        {
            InitializeComponent();
        }
        private void Digit_Input(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar))
            {
                e.Handled = !Char.IsDigit(e.KeyChar);
            }
        }

        private void сохранитьРезультатПоискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (found.Count() != 0)
            {
                using (FileStream fs = new FileStream("foundByBalance.json", FileMode.OpenOrCreate))
                {
                    JsonSerializer.SerializeAsync(fs, found);
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
            if (textBox1.Text.Length < 2)
            {
                MessageBox.Show("Поиск невозможен, так как точность мала. Введите конкретный номер");
            }
            else
            {
                string json = File.ReadAllText("bank_account.json");
                string[] jsonDelim = json.Split(new[] { "},{" }, StringSplitOptions.None);
                Regex balanceCheck = new Regex(@"ba\w{5}(""):("")" + textBox1.Text);
                string match = null;
                foreach (string obj in jsonDelim)
                {
                    if (balanceCheck.IsMatch(obj))
                    {
                        match += obj;
                    }
                }
                if (match != null)
                {
                    if (!match.Contains(']'))
                    {
                        match += "}]";
                    }
                    else if (!match.Contains('['))
                    {
                        match = match.Insert(0, "[{");
                    }
                    found = JsonSerializer.Deserialize<List<Bank_Account>>(match);
                    foreach (var acc in found)
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
                    richTextBox1.AppendText("Ничего не найдено");
                }
                /*richTextBox1.AppendText(json);*/
                textBox1.Clear();
            }

        }
    }
}
