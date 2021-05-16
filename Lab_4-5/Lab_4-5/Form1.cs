using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Lab_4_5
{
    public partial class Form1 : Form
    {
        Apartment apartment;
        public Form1()
        {
            InitializeComponent();
        }
      
        private void display_btn_Click(object sender, EventArgs e)
        {
            try
            {
                display_RTB.Text = "";
                List<Apartment> outputList = new Apartment().Deserializing(Program.Path + Program.ApartmentsFilename);
                if (outputList == null)
                {
                    MessageBox.Show("Apartments file is empty");
                }
                else
                    foreach (Apartment apartment in outputList)
                        display_RTB.Text += apartment + "\n";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                apartment = (Apartment)new ApartmentWithAddressFactory().CreateAccommodation(this);
                apartment.Serializing(apartment, Program.Path + Program.ApartmentsFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }

        private void floor_TB_Scroll(object sender, EventArgs e)
        {
            trackbar_lbl.Text = floor_TB.Value.ToString();
        }

        private void clone_btn_Click(object sender, EventArgs e)
        {
            apartment = (Apartment)apartment.clone();
        }

        private void saveWithoutAddress_btn_Click(object sender, EventArgs e)
        {
            try
            {
                apartment = (Apartment)new ApartmentWithoutAddressFactory().CreateAccommodation(this);
                apartment.Serializing(apartment, Program.Path + Program.ApartmentsFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }

        private void displayWithSort_btn_Click(object sender, EventArgs e)
        {
            try
            {
                display_RTB.Text = "";
                List<Apartment> outputList = new DeSerializationWithSortDecorator(new Apartment()).Deserializing(Program.Path + Program.ApartmentsFilename);
                if (outputList == null)
                {
                    MessageBox.Show("Apartments file is empty");
                }
                else
                    foreach (Apartment apartment in outputList)
                        display_RTB.Text += apartment + "\n";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
