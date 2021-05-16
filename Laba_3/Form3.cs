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
    public partial class Form3 : Form
    {
        private static List<Bank_Account> found = new List<Bank_Account>();
        public Form3()
        {
            InitializeComponent();
        }

        private void Letter_Input(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = !Char.IsLetter(e.KeyChar);
                e.Handled = !Regex.IsMatch(e.KeyChar.ToString(), @"\P{IsCyrillic}");
            }
        }

        private void сохранитьРезультатПоискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (found.Count() != 0)
            {
                using (FileStream fs = new FileStream("foundByFIO.json", FileMode.OpenOrCreate))
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
            if (textBox1.Text.Length < 3 && textBox2.Text.Length <3 && textBox3.Text.Length <3)
            {
                MessageBox.Show("Поиск невозможен, так как точность мала. Введите минимум 3 символа, а лучше конкретный номер");
            }
            else
            {
                string json = File.ReadAllText("bank_account.json");
                string[] jsonDelim = json.Split(new[] { "},{" }, StringSplitOptions.None);
                Regex surnameCheck = new Regex(@"surname(""):("")" + textBox1.Text);
                Regex firstNameCheck = new Regex(@"firstName(""):("")" + textBox2.Text);
                Regex patronymicCheck = new Regex(@"patronymic(""):("")" + textBox3.Text);
                string match = null;
                foreach (string obj in jsonDelim)
                {
                    if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text != "")
                    {
                        if (patronymicCheck.IsMatch(obj))
                        {
                            match += obj;
                        }
                    }
                    else if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "")
                    {
                        if (surnameCheck.IsMatch(obj))
                        {
                            match += obj;
                        }
                    }
                    else if (textBox1.Text == "" && textBox2.Text != "" && textBox3.Text == "")
                    {
                        if (firstNameCheck.IsMatch(obj))
                        {
                            match += obj;
                        }
                    }
                    else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                    {
                        if (surnameCheck.IsMatch(obj) && firstNameCheck.IsMatch(obj))
                        {
                            match += obj;
                        }
                    }
                    else if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text != "")
                    {
                        if (surnameCheck.IsMatch(obj) && patronymicCheck.IsMatch(obj))
                        {
                            match += obj;
                        }
                    }
                    else if (textBox1.Text == "" && textBox2.Text != "" && textBox3.Text != "")
                    {
                        if (firstNameCheck.IsMatch(obj) && patronymicCheck.IsMatch(obj))
                        {
                            match += obj;
                        }
                    }
                    else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                    {
                        if (surnameCheck.IsMatch(obj) && firstNameCheck.IsMatch(obj) && patronymicCheck.IsMatch(obj))
                        {
                            match += obj;
                        }
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
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }
    }
}
