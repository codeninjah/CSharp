using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp2;

namespace StoryTellerWindowsApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			StoryTeller storyteller = new StoryTeller();
			txtTellStory.Text = storyteller.TellStory(
				txtNameofChild.Text,
				Convert.ToInt32(numAgeofChild.Value),
				ifScary.Checked);

		}

		private void txtTellStory_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtNameofChild_TextChanged(object sender, EventArgs e)
		{

		}

		private void numAgeofChild_ValueChanged(object sender, EventArgs e)
		{

		}

		private void ifScary_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
