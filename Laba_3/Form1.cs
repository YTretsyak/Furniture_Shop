using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Laba_3
{
    public partial class Form1 : Form
    {
        Bank_Account current;
        List<Bank_Account> accounts = new List<Bank_Account>();
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Termless");//бессрочный
            comboBox1.Items.Add("Saving");//сберегательный
            comboBox1.Items.Add("Cumulative");//накопительный
            comboBox1.Items.Add("Estimated");//расчётный
        }



        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Недоприложение рандомного банка. 2021 Copyright \u00A9");
            label13.Text = "Последнее действие: О программе";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            label13.Text = "Последнее действие: Создать объект";
        }

        private void Digit_Input(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar))
            {
                e.Handled = !Char.IsDigit(e.KeyChar);
            }
        }
        private void Letter_Input(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = !Char.IsLetter(e.KeyChar);
                e.Handled = !Regex.IsMatch(e.KeyChar.ToString(), @"\P{IsCyrillic}");
            }
        }

        private void Passport_Input(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar))
            {
                e.Handled = !Char.IsLetterOrDigit(e.KeyChar);
                e.Handled = !Regex.IsMatch(e.KeyChar.ToString(), @"\P{IsCyrillic}");
            }

        }



        public void button1_Click(object sender, EventArgs e)
        {
            current = new Bank_Account()
            {
                number = textBox2.Text
            };

            bool token1 = false;
            bool token2 = false;
            bool token3 = false;
            bool token4 = false;
            bool token5 = false;
            bool token6 = false;
            Bank_Account account = new Bank_Account();
            account.birth_Date = dateTimePicker2.Value.ToShortDateString();
            try
            {
                account.surname = textBox1.Text;
                if (textBox1.Text == "")
                {
                    throw new Exception("Заполните поле \"Фамилия\"");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                token1 = true;
            }
            try
            {
                account.firstName = textBox4.Text;
                if (textBox4.Text == "")
                {
                    throw new Exception("Заполните поле \"Имя\"");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                token5 = true;
            }
            try
            {
                account.patronymic = textBox5.Text;
                if (textBox5.Text == "")
                {
                    throw new Exception("Заполните поле \"Отчество\"");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                token6 = true;
            }
            try
            {
                account.passport_Data = textBox3.Text;
                if (textBox3.Text == "")
                {
                    throw new Exception("Заполните поле \"Данные паспорта\"");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                token3 = true;
            }
            try
            {
                account.number = textBox2.Text;
                if (textBox2.Text == "")
                {
                    throw new Exception("Заполните поле \"Номер\"");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                token2 = true;
            }
            try
            {
                if (comboBox1.SelectedItem == null)
                {
                    throw new Exception("Выберите тип вклада");
                }
                else
                {
                    account.deposit_Type = comboBox1.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                token4 = true;
            }

            var result = new List<ValidationResult>();
            var context = new ValidationContext(current);
            var context2 = new ValidationContext(current.number);

            if (!Validator.TryValidateObject(current, context, result, true))
            {
                foreach (var error in result)
                {
                    MessageBox.Show(error.ErrorMessage);
                }
                return;
            }

            account.balance = numericUpDown1.Value.ToString();
            account.opening_Date = dateTimePicker1.Value.ToShortDateString();
            account.SMS_notification = checkBox1.Checked;
            account.internet_Banking = checkBox2.Checked;
            if (token1 != true && token2 != true && token3 != true && token4 != true && token5 != true && token6 != true)
            {
                accounts.Add(account);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                dateTimePicker1.ResetText();
                dateTimePicker2.ResetText();
                comboBox1.ResetText();
                numericUpDown1.ResetText();
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
            else
            {
                MessageBox.Show($"Не все поля заполнены");
            }

            label13.Text = "Последнее действие: Создать объект";
        }

        private void SerializeAccount(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("bank_account.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync(fs, accounts);
            }

            label13.Text = "Последнее действие: Сохранить объект";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string json = File.ReadAllText("bank_account.json");
            if (json != "")
            {
                List<Bank_Account> deserialisationAccount = JsonSerializer.Deserialize<List<Bank_Account>>(json);
                foreach (var acc in deserialisationAccount)
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

            label13.Text = "Последнее действие: Вывод на экран";
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form();
            form2.ShowDialog();
        }

        private void поискToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            label13.Text = "Последнее действие: Поиск по номеру";
        }

        private void поискToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form3 form2 = new Form3();
            form2.ShowDialog();
            label13.Text = "Последнее действие: Поиск по ФИО";
        }

        private void поискToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form4 form2 = new Form4();
            form2.ShowDialog();
            label13.Text = "Последнее действие: Поиск по балансу";
        }

        private void поискToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form5 form2 = new Form5();
            form2.ShowDialog();
            label13.Text = "Последнее действие: Поиск по типу вклада";
        }

        private void поискToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form6 form2 = new Form6();
            form2.ShowDialog();
            label13.Text = "Последнее действие: Сортировка по типу вклада";
        }

        private void поискToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form7 form2 = new Form7();
            form2.ShowDialog();
            label13.Text = "Последнее действие: Поиск по дате открытия";
        }

        private void timer1_Elapsed(object sender, EventArgs e)
        {
            label14.Text = $"Количество объектов: {accounts.Count()}";
            label15.Text = $"{DateTime.Now.ToString()}";
        }

        private void светлаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Singleton.ChangeTheme(new WhiteTheme());
            this.FontHeight = Singleton.GetInstance().IuConfig.FontSize;
            this.Font = Singleton.GetInstance().IuConfig.FontType;
            this.BackColor = Singleton.GetInstance().IuConfig.BG;
        }

        private void тёмнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Singleton.ChangeTheme(new BlackTheme());
            this.FontHeight = Singleton.GetInstance().IuConfig.FontSize;
            this.Font = Singleton.GetInstance().IuConfig.FontType;
            this.BackColor = Singleton.GetInstance().IuConfig.BG;
        }
    }
}
