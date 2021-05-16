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
using System.Xml.Serialization;
using System.IO;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Specialized;

namespace Laba_2
{
    public partial class Form1 : Form
    {
        List<IOwner> Owners { get; }
        List<Bank_Account> accounts = new List<Bank_Account>();
        Bank_Account account = new Bank_Account();
        private AccountBuilder accountBuilder;
        private ManFactory manFactory;
        private WomanFactory womanFactory;
        List<RadioButton> RadioButtons { get; }
       
    public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Бессрочный");
            comboBox1.Items.Add("Сберегательный");
            comboBox1.Items.Add("Накопительный");
            comboBox1.Items.Add("Расчётный");
            RadioButtons = new List<RadioButton>()
            {
                radioButton1, radioButton2
            };
            manFactory = new ManFactory();
            womanFactory = new WomanFactory();
            accountBuilder = new AccountBuilder();
            Owners = new List<IOwner>() {
                manFactory.CreateOwner("Обычный Мужчина Батькович", "21.09.1975","12345PASSPORT2"),
                womanFactory.CreateOwner("Обычная Женщина Батьковна", "01.04.2000","54321PASSPORT3")
            };
        }



        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Недоприложение рандомного банка. 2021 Copyright \u00A9");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
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
            }
        }

        private void Passport_Input(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar))
            {
                e.Handled = !Char.IsLetterOrDigit(e.KeyChar) ;
            }
            
        }

 

        public void button1_Click(object sender, EventArgs e)
        {
            bool token1 = false;
            bool token2 = false;
            bool token3 = false;
            bool token4 = false;
            
            
            try
            {
                if (textBox1.Text == "")
                {
                    throw new Exception("Заполните поле \"ФИО\"");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"{ex.Message}");
                token1 = true;
            }
            try
            {
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
                accountBuilder.BuildNumber(textBox2.Text);
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
                    accountBuilder.BuildDeposit_Type(comboBox1.SelectedItem.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                token4 = true;
            }

            if (radioButton1.Checked)
            {
                accountBuilder.BuildOwner(new Man(textBox1.Text, dateTimePicker2.Value.ToShortDateString(), textBox3.Text));
            }
            else if(radioButton2.Checked)
            {
                accountBuilder.BuildOwner(new Woman(textBox1.Text, dateTimePicker2.Value.ToShortDateString(), textBox3.Text));
            }
            //accountBuilder.Reset();
            var rb = RadioButtons.Where(item => item.Checked).First();
            IOwner owner = Owners.Where(item => item.sex == rb.Text).First();
            
            accountBuilder.BuildBalance(numericUpDown1.Value.ToString());
            accountBuilder.BuildOpening_Date(dateTimePicker1.Value.ToShortDateString());
            accountBuilder.BuildSMS_Notification(checkBox1.Checked);
            accountBuilder.BuildInternet_Banking(checkBox2.Checked);
            

            if (token1 != true && token2 != true && token3 != true && token4 != true)
            {
                accounts.Add(accountBuilder.GetResult());
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                dateTimePicker1.ResetText();
                dateTimePicker2.ResetText();
                comboBox1.ResetText();
                numericUpDown1.ResetText();
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            else
            {
                MessageBox.Show($"Не все поля заполнены");
            }
        }

        private void SerializeAccount(object sender, EventArgs e)
        {
                var fileName = "bank_account.json";

                var dialog = new SaveFileDialog
                {
                    FileName = fileName
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (var sw = new StreamWriter(dialog.FileName))
                    {
                        sw.Write(JsonConvert.SerializeObject(accounts));
                    }
                }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string json = File.ReadAllText("bank_account.json");
            if (json != "")
            {
                using (var sr = new StreamReader("bank_account.json"))
                {
                    string sd = sr.ReadToEnd();
                    //var items = JsonConvert.DeserializeObject<List<Bank_Account>>(sd);
                    foreach (var acc in accounts)
                    {
                        richTextBox1.AppendText(
                            $"Имя владельца: {acc.Owner.FIO}\n" +
                            $"Дата рождения: {acc.Owner.birth_Date}\n" +
                            $"Данные паспорта: {acc.Owner.passport_Data}\n" +
                            $"Пол: {acc.Owner.sex}\n" +
                            $"Номер счёта: {acc.number}\n" +
                            $"Тип вклада: {acc.deposit_Type}\n" +
                            $"Баланс: {acc.balance} BYN\n" +
                            $"Дата открытия счёта: {acc.opening_Date}\n" +
                            $"СМС-оповещения: {acc.Check_SMS()}\n" +
                            $"Интернет-банкинг: {acc.Check_Banking()}\n##############################################\n"
                            );
                    }
                }
            }
            else
            {
                richTextBox1.AppendText("Файл пуст");
            }
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form();
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Singleton singleton = Singleton.GetSingleton();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            account = (Bank_Account)accounts[0].clone();
            Bank_Account tmp = (Bank_Account)account.clone();
            tmp.number = account.number;
            accounts.Add(tmp);
        }
    }
}
