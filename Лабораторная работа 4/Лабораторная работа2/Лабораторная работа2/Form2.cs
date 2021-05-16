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
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Specialized;

namespace Лабораторная_работа2
{
    public partial class Form2 : Form
    {
		public ObservableCollection<Discipline> disciplines;

		public Form2(List<Discipline> resList)
        {
            InitializeComponent();
			this.Font = Singleton.GetInstance().Config.FontType;
			this.BackColor = Singleton.GetInstance().Config.FontColor;
			Disciplines_ListView.Items.Clear();
			AddToTableRange(resList);	
        }

		private void AddToTableRange(IEnumerable<Discipline> disciplines)
		{
			foreach (var discipline in disciplines)
				AddToTable(discipline);
		}

		private void AddToTable(Discipline discipline)
		{
			var item = new ListViewItem(discipline.Name);
			item.SubItems.Add(discipline.Course.ToString());
			item.SubItems.Add(discipline.Semester.ToString());
			item.SubItems.Add(discipline.Test);
			item.SubItems.Add(discipline.LecturesAmt.ToString());
			item.SubItems.Add(discipline.LabsAmt.ToString());
			item.SubItems.Add(discipline.Specialty);
			item.SubItems.Add(discipline.Lecturer.FullName);
			item.SubItems.Add(discipline.Lecturer.Chair);
			item.SubItems.Add(discipline.Lecturer.Step);

			Disciplines_ListView.Items.Add(item);
		}
		private void Disciplines_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

		private void button1_Click(object sender, EventArgs e)
		{
			var fileName = "save.json";

			var dialog = new SaveFileDialog
			{
				FileName = fileName
			};

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				using (var sw = new StreamWriter(dialog.FileName))
				{
					sw.Write(JsonConvert.SerializeObject(disciplines));
				}
			}
		}
	}
}
