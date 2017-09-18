namespace StoryTellerWindowsApp
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label3 = new System.Windows.Forms.Label();
			this.txtNameofChild = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.ifScary = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.txtTellStory = new System.Windows.Forms.TextBox();
			this.numAgeofChild = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numAgeofChild)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(38, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Name of Child";
			// 
			// txtNameofChild
			// 
			this.txtNameofChild.Location = new System.Drawing.Point(41, 35);
			this.txtNameofChild.Name = "txtNameofChild";
			this.txtNameofChild.Size = new System.Drawing.Size(162, 20);
			this.txtNameofChild.TabIndex = 1;
			this.txtNameofChild.TextChanged += new System.EventHandler(this.txtNameofChild_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(41, 84);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Age of Child";
			// 
			// ifScary
			// 
			this.ifScary.AutoSize = true;
			this.ifScary.Location = new System.Drawing.Point(44, 127);
			this.ifScary.Name = "ifScary";
			this.ifScary.Size = new System.Drawing.Size(86, 17);
			this.ifScary.TabIndex = 4;
			this.ifScary.Text = "Will be scary";
			this.ifScary.UseVisualStyleBackColor = true;
			this.ifScary.CheckedChanged += new System.EventHandler(this.ifScary_CheckedChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(44, 177);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Tell Story!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtTellStory
			// 
			this.txtTellStory.Location = new System.Drawing.Point(44, 207);
			this.txtTellStory.Multiline = true;
			this.txtTellStory.Name = "txtTellStory";
			this.txtTellStory.Size = new System.Drawing.Size(504, 132);
			this.txtTellStory.TabIndex = 6;
			this.txtTellStory.TextChanged += new System.EventHandler(this.txtTellStory_TextChanged);
			// 
			// numAgeofChild
			// 
			this.numAgeofChild.Location = new System.Drawing.Point(44, 101);
			this.numAgeofChild.Name = "numAgeofChild";
			this.numAgeofChild.Size = new System.Drawing.Size(120, 20);
			this.numAgeofChild.TabIndex = 7;
			this.numAgeofChild.ValueChanged += new System.EventHandler(this.numAgeofChild_ValueChanged);
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(581, 351);
			this.Controls.Add(this.numAgeofChild);
			this.Controls.Add(this.txtTellStory);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ifScary);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtNameofChild);
			this.Controls.Add(this.label3);
			this.Name = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.numAgeofChild)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbNameOfChild;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numAge;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button btnTellStory;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNameofChild;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox ifScary;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtTellStory;
		private System.Windows.Forms.NumericUpDown numAgeofChild;
	}
}

