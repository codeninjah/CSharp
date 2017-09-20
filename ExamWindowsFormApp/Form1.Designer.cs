namespace ExamWindowsFormApp
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
			this.studentNamn = new System.Windows.Forms.GroupBox();
			this.txtStudent = new System.Windows.Forms.TextBox();
			this.cmbBetyg = new System.Windows.Forms.ComboBox();
			this.btnGrade = new System.Windows.Forms.Button();
			this.gpBoxStats = new System.Windows.Forms.GroupBox();
			this.btnGenStats = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.gpBoxStats.SuspendLayout();
			this.SuspendLayout();
			// 
			// studentNamn
			// 
			this.studentNamn.Location = new System.Drawing.Point(12, 12);
			this.studentNamn.Name = "studentNamn";
			this.studentNamn.Size = new System.Drawing.Size(200, 22);
			this.studentNamn.TabIndex = 0;
			this.studentNamn.TabStop = false;
			this.studentNamn.Text = "Student";
			// 
			// txtStudent
			// 
			this.txtStudent.Location = new System.Drawing.Point(12, 40);
			this.txtStudent.Name = "txtStudent";
			this.txtStudent.Size = new System.Drawing.Size(588, 20);
			this.txtStudent.TabIndex = 0;
			this.txtStudent.TextChanged += new System.EventHandler(this.txtStudent_TextChanged);
			// 
			// cmbBetyg
			// 
			this.cmbBetyg.FormattingEnabled = true;
			this.cmbBetyg.Items.AddRange(new object[] {
            "IG",
            "G",
            "VG"});
			this.cmbBetyg.Location = new System.Drawing.Point(12, 82);
			this.cmbBetyg.Name = "cmbBetyg";
			this.cmbBetyg.Size = new System.Drawing.Size(240, 21);
			this.cmbBetyg.TabIndex = 1;
			this.cmbBetyg.SelectedIndexChanged += new System.EventHandler(this.cmbBetyg_SelectedIndexChanged);
			// 
			// btnGrade
			// 
			this.btnGrade.Location = new System.Drawing.Point(287, 82);
			this.btnGrade.Name = "btnGrade";
			this.btnGrade.Size = new System.Drawing.Size(131, 25);
			this.btnGrade.TabIndex = 2;
			this.btnGrade.Text = "btnGrade";
			this.btnGrade.UseVisualStyleBackColor = true;
			this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
			// 
			// gpBoxStats
			// 
			this.gpBoxStats.Controls.Add(this.label3);
			this.gpBoxStats.Controls.Add(this.label2);
			this.gpBoxStats.Controls.Add(this.label1);
			this.gpBoxStats.Location = new System.Drawing.Point(23, 137);
			this.gpBoxStats.Name = "gpBoxStats";
			this.gpBoxStats.Size = new System.Drawing.Size(632, 159);
			this.gpBoxStats.TabIndex = 3;
			this.gpBoxStats.TabStop = false;
			this.gpBoxStats.Text = "Statitics";
			// 
			// btnGenStats
			// 
			this.btnGenStats.Location = new System.Drawing.Point(489, 302);
			this.btnGenStats.Name = "btnGenStats";
			this.btnGenStats.Size = new System.Drawing.Size(166, 39);
			this.btnGenStats.TabIndex = 4;
			this.btnGenStats.Text = "Generate Statistics";
			this.btnGenStats.UseVisualStyleBackColor = true;
			this.btnGenStats.Click += new System.EventHandler(this.btnGenStats_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(228, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "IG: 0";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(228, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "G: 0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(228, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 33);
			this.label3.TabIndex = 2;
			this.label3.Text = "VG: 0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 352);
			this.Controls.Add(this.btnGenStats);
			this.Controls.Add(this.gpBoxStats);
			this.Controls.Add(this.btnGrade);
			this.Controls.Add(this.cmbBetyg);
			this.Controls.Add(this.txtStudent);
			this.Controls.Add(this.studentNamn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gpBoxStats.ResumeLayout(false);
			this.gpBoxStats.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox studentNamn;
		private System.Windows.Forms.TextBox txtStudent;
		private System.Windows.Forms.ComboBox cmbBetyg;
		private System.Windows.Forms.Button btnGrade;
		private System.Windows.Forms.GroupBox gpBoxStats;
		private System.Windows.Forms.Button btnGenStats;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

