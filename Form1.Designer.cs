
namespace Praktikum_Week_10
{
	partial class FormHasilPertandingan
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
			this.btn_chck = new System.Windows.Forms.Button();
			this.Dgv_match = new System.Windows.Forms.DataGridView();
			this.labAwayKapten = new System.Windows.Forms.Label();
			this.labAwayManager = new System.Windows.Forms.Label();
			this.labHomeKapten = new System.Windows.Forms.Label();
			this.labHomeManager = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.labCapacity = new System.Windows.Forms.Label();
			this.labStadium = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboAway = new System.Windows.Forms.ComboBox();
			this.comboHome = new System.Windows.Forms.ComboBox();
			this.lbl_skor = new System.Windows.Forms.Label();
			this.lbl_tgl = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.Dgv_match)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_chck
			// 
			this.btn_chck.Location = new System.Drawing.Point(335, 211);
			this.btn_chck.Name = "btn_chck";
			this.btn_chck.Size = new System.Drawing.Size(101, 23);
			this.btn_chck.TabIndex = 47;
			this.btn_chck.Text = "Check";
			this.btn_chck.UseVisualStyleBackColor = true;
			this.btn_chck.Click += new System.EventHandler(this.btn_chck_Click);
			// 
			// Dgv_match
			// 
			this.Dgv_match.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Dgv_match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Dgv_match.Location = new System.Drawing.Point(18, 312);
			this.Dgv_match.Name = "Dgv_match";
			this.Dgv_match.RowHeadersWidth = 51;
			this.Dgv_match.RowTemplate.Height = 24;
			this.Dgv_match.Size = new System.Drawing.Size(743, 284);
			this.Dgv_match.TabIndex = 46;
			// 
			// labAwayKapten
			// 
			this.labAwayKapten.AutoSize = true;
			this.labAwayKapten.Location = new System.Drawing.Point(594, 100);
			this.labAwayKapten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labAwayKapten.Name = "labAwayKapten";
			this.labAwayKapten.Size = new System.Drawing.Size(23, 17);
			this.labAwayKapten.TabIndex = 43;
			this.labAwayKapten.Text = "---";
			// 
			// labAwayManager
			// 
			this.labAwayManager.AutoSize = true;
			this.labAwayManager.Location = new System.Drawing.Point(594, 69);
			this.labAwayManager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labAwayManager.Name = "labAwayManager";
			this.labAwayManager.Size = new System.Drawing.Size(23, 17);
			this.labAwayManager.TabIndex = 42;
			this.labAwayManager.Text = "---";
			// 
			// labHomeKapten
			// 
			this.labHomeKapten.AutoSize = true;
			this.labHomeKapten.Location = new System.Drawing.Point(90, 100);
			this.labHomeKapten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labHomeKapten.Name = "labHomeKapten";
			this.labHomeKapten.Size = new System.Drawing.Size(23, 17);
			this.labHomeKapten.TabIndex = 41;
			this.labHomeKapten.Text = "---";
			// 
			// labHomeManager
			// 
			this.labHomeManager.AutoSize = true;
			this.labHomeManager.Location = new System.Drawing.Point(90, 69);
			this.labHomeManager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labHomeManager.Name = "labHomeManager";
			this.labHomeManager.Size = new System.Drawing.Size(23, 17);
			this.labHomeManager.TabIndex = 39;
			this.labHomeManager.Text = "---";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(522, 96);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(85, 21);
			this.label11.TabIndex = 38;
			this.label11.Text = "Captain : ";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(522, 65);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(95, 21);
			this.label13.TabIndex = 36;
			this.label13.Text = "Manager : ";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(18, 96);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(85, 21);
			this.label10.TabIndex = 35;
			this.label10.Text = "Captain : ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(18, 65);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(95, 21);
			this.label8.TabIndex = 33;
			this.label8.Text = "Manager : ";
			// 
			// labCapacity
			// 
			this.labCapacity.AutoSize = true;
			this.labCapacity.Location = new System.Drawing.Point(381, 180);
			this.labCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labCapacity.Name = "labCapacity";
			this.labCapacity.Size = new System.Drawing.Size(23, 17);
			this.labCapacity.TabIndex = 32;
			this.labCapacity.Text = "---";
			// 
			// labStadium
			// 
			this.labStadium.AutoSize = true;
			this.labStadium.Location = new System.Drawing.Point(381, 153);
			this.labStadium.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labStadium.Name = "labStadium";
			this.labStadium.Size = new System.Drawing.Size(23, 17);
			this.labStadium.TabIndex = 31;
			this.labStadium.Text = "---";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(299, 180);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 17);
			this.label5.TabIndex = 30;
			this.label5.Text = "Capacity : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(302, 153);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 17);
			this.label4.TabIndex = 29;
			this.label4.Text = "Stadium : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(345, 28);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 17);
			this.label3.TabIndex = 28;
			this.label3.Text = "VS";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(606, -22);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 17);
			this.label2.TabIndex = 27;
			this.label2.Text = "Team Away";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, -22);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 17);
			this.label1.TabIndex = 26;
			this.label1.Text = "Team Home";
			// 
			// comboAway
			// 
			this.comboAway.FormattingEnabled = true;
			this.comboAway.Location = new System.Drawing.Point(525, 21);
			this.comboAway.Margin = new System.Windows.Forms.Padding(4);
			this.comboAway.Name = "comboAway";
			this.comboAway.Size = new System.Drawing.Size(160, 24);
			this.comboAway.TabIndex = 25;
			this.comboAway.SelectedIndexChanged += new System.EventHandler(this.comboAway_SelectedIndexChanged_1);
			// 
			// comboHome
			// 
			this.comboHome.FormattingEnabled = true;
			this.comboHome.Location = new System.Drawing.Point(18, 21);
			this.comboHome.Margin = new System.Windows.Forms.Padding(4);
			this.comboHome.Name = "comboHome";
			this.comboHome.Size = new System.Drawing.Size(160, 24);
			this.comboHome.TabIndex = 24;
			this.comboHome.SelectedIndexChanged += new System.EventHandler(this.comboHome_SelectedIndexChanged_1);
			// 
			// lbl_skor
			// 
			this.lbl_skor.AutoSize = true;
			this.lbl_skor.Location = new System.Drawing.Point(381, 273);
			this.lbl_skor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_skor.Name = "lbl_skor";
			this.lbl_skor.Size = new System.Drawing.Size(23, 17);
			this.lbl_skor.TabIndex = 51;
			this.lbl_skor.Text = "---";
			// 
			// lbl_tgl
			// 
			this.lbl_tgl.AutoSize = true;
			this.lbl_tgl.Location = new System.Drawing.Point(381, 246);
			this.lbl_tgl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_tgl.Name = "lbl_tgl";
			this.lbl_tgl.Size = new System.Drawing.Size(23, 17);
			this.lbl_tgl.TabIndex = 50;
			this.lbl_tgl.Text = "---";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(302, 246);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(72, 17);
			this.label12.TabIndex = 48;
			this.label12.Text = "Tanggal : ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(322, 273);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(49, 17);
			this.label7.TabIndex = 52;
			this.label7.Text = "Skor : ";
			// 
			// FormHasilPertandingan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 525);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lbl_skor);
			this.Controls.Add(this.lbl_tgl);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.btn_chck);
			this.Controls.Add(this.Dgv_match);
			this.Controls.Add(this.labAwayKapten);
			this.Controls.Add(this.labAwayManager);
			this.Controls.Add(this.labHomeKapten);
			this.Controls.Add(this.labHomeManager);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.labCapacity);
			this.Controls.Add(this.labStadium);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboAway);
			this.Controls.Add(this.comboHome);
			this.Name = "FormHasilPertandingan";
			this.Text = "Hasil Pertandingan";
			this.Load += new System.EventHandler(this.FormHasilPertandingan_Load);
			((System.ComponentModel.ISupportInitialize)(this.Dgv_match)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_chck;
		private System.Windows.Forms.DataGridView Dgv_match;
		private System.Windows.Forms.Label labAwayKapten;
		private System.Windows.Forms.Label labAwayManager;
		private System.Windows.Forms.Label labHomeKapten;
		private System.Windows.Forms.Label labHomeManager;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label labCapacity;
		private System.Windows.Forms.Label labStadium;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboAway;
		private System.Windows.Forms.ComboBox comboHome;
		private System.Windows.Forms.Label lbl_skor;
		private System.Windows.Forms.Label lbl_tgl;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label7;
	}
}

