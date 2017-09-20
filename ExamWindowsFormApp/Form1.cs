using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenLib;

namespace ExamWindowsFormApp
{
	public partial class Form1 : Form
	{
		Exam nyExam = new Exam("");

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnGrade_Click(object sender, EventArgs e)
		{
				Student nyStudent = new Student(txtStudent.Text);
				nyExam.Assign(nyStudent);
				nyExam.Grade(nyStudent, cmbBetyg.SelectedItem.ToString());
				
			
		}

		private void txtStudent_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void cmbBetyg_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnGenStats_Click(object sender, EventArgs e)
		{
			var gradeCountDictionary = nyExam.GenerateStatistics();
			var IGCounter = gradeCountDictionary["IG"];
			label1.Text = $"IG: {IGCounter}";

			var GCounter = gradeCountDictionary["G"];
			label2.Text = $"G: {GCounter}";

			var VGCounter = gradeCountDictionary["VG"];
			label3.Text = $"VG: {VGCounter}";
		}
	}
}
