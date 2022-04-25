
namespace praktikum_11_April_week_8
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.cBoxHomeTeam = new System.Windows.Forms.ComboBox();
            this.cBoxAwayTeam = new System.Windows.Forms.ComboBox();
            this.lbl_VS = new System.Windows.Forms.Label();
            this.lbl_tulisanManager = new System.Windows.Forms.Label();
            this.lbl_TulisanCaptain = new System.Windows.Forms.Label();
            this.lbl_ManagerHome = new System.Windows.Forms.Label();
            this.lbl_CaptainHome = new System.Windows.Forms.Label();
            this.lbl_CaptainAway = new System.Windows.Forms.Label();
            this.lbl_ManagerAway = new System.Windows.Forms.Label();
            this.lbl_TulisanCaptain2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_CapacityOutput = new System.Windows.Forms.Label();
            this.lbl_StadiumOutput = new System.Windows.Forms.Label();
            this.lbl_TulisanCapacity = new System.Windows.Forms.Label();
            this.lbl_TulisanStadium = new System.Windows.Forms.Label();
            this.btn_check = new System.Windows.Forms.Button();
            this.dataGridView_Detail = new System.Windows.Forms.DataGridView();
            this.lbl_tulisanTanggal = new System.Windows.Forms.Label();
            this.lbl_TulisanSkor = new System.Windows.Forms.Label();
            this.lbl_HasilTanggal = new System.Windows.Forms.Label();
            this.lbl_HasilSkor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Detail)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxHomeTeam
            // 
            this.cBoxHomeTeam.FormattingEnabled = true;
            this.cBoxHomeTeam.Location = new System.Drawing.Point(164, 27);
            this.cBoxHomeTeam.Name = "cBoxHomeTeam";
            this.cBoxHomeTeam.Size = new System.Drawing.Size(286, 28);
            this.cBoxHomeTeam.TabIndex = 0;
            this.cBoxHomeTeam.SelectedIndexChanged += new System.EventHandler(this.cBoxHomeTeam_SelectedIndexChanged);
            // 
            // cBoxAwayTeam
            // 
            this.cBoxAwayTeam.FormattingEnabled = true;
            this.cBoxAwayTeam.Location = new System.Drawing.Point(638, 27);
            this.cBoxAwayTeam.Name = "cBoxAwayTeam";
            this.cBoxAwayTeam.Size = new System.Drawing.Size(286, 28);
            this.cBoxAwayTeam.TabIndex = 1;
            this.cBoxAwayTeam.SelectedIndexChanged += new System.EventHandler(this.cBoxAwayTeam_SelectedIndexChanged);
            // 
            // lbl_VS
            // 
            this.lbl_VS.AutoSize = true;
            this.lbl_VS.Location = new System.Drawing.Point(529, 30);
            this.lbl_VS.Name = "lbl_VS";
            this.lbl_VS.Size = new System.Drawing.Size(31, 20);
            this.lbl_VS.TabIndex = 2;
            this.lbl_VS.Text = "VS";
            // 
            // lbl_tulisanManager
            // 
            this.lbl_tulisanManager.AutoSize = true;
            this.lbl_tulisanManager.Location = new System.Drawing.Point(160, 82);
            this.lbl_tulisanManager.Name = "lbl_tulisanManager";
            this.lbl_tulisanManager.Size = new System.Drawing.Size(80, 20);
            this.lbl_tulisanManager.TabIndex = 3;
            this.lbl_tulisanManager.Text = "Manager :";
            // 
            // lbl_TulisanCaptain
            // 
            this.lbl_TulisanCaptain.AutoSize = true;
            this.lbl_TulisanCaptain.Location = new System.Drawing.Point(160, 123);
            this.lbl_TulisanCaptain.Name = "lbl_TulisanCaptain";
            this.lbl_TulisanCaptain.Size = new System.Drawing.Size(72, 20);
            this.lbl_TulisanCaptain.TabIndex = 4;
            this.lbl_TulisanCaptain.Text = "Captain :";
            // 
            // lbl_ManagerHome
            // 
            this.lbl_ManagerHome.AutoSize = true;
            this.lbl_ManagerHome.Location = new System.Drawing.Point(251, 82);
            this.lbl_ManagerHome.Name = "lbl_ManagerHome";
            this.lbl_ManagerHome.Size = new System.Drawing.Size(0, 20);
            this.lbl_ManagerHome.TabIndex = 5;
            // 
            // lbl_CaptainHome
            // 
            this.lbl_CaptainHome.AutoSize = true;
            this.lbl_CaptainHome.Location = new System.Drawing.Point(251, 123);
            this.lbl_CaptainHome.Name = "lbl_CaptainHome";
            this.lbl_CaptainHome.Size = new System.Drawing.Size(0, 20);
            this.lbl_CaptainHome.TabIndex = 6;
            // 
            // lbl_CaptainAway
            // 
            this.lbl_CaptainAway.AutoSize = true;
            this.lbl_CaptainAway.Location = new System.Drawing.Point(725, 123);
            this.lbl_CaptainAway.Name = "lbl_CaptainAway";
            this.lbl_CaptainAway.Size = new System.Drawing.Size(0, 20);
            this.lbl_CaptainAway.TabIndex = 10;
            // 
            // lbl_ManagerAway
            // 
            this.lbl_ManagerAway.AutoSize = true;
            this.lbl_ManagerAway.Location = new System.Drawing.Point(725, 82);
            this.lbl_ManagerAway.Name = "lbl_ManagerAway";
            this.lbl_ManagerAway.Size = new System.Drawing.Size(0, 20);
            this.lbl_ManagerAway.TabIndex = 9;
            // 
            // lbl_TulisanCaptain2
            // 
            this.lbl_TulisanCaptain2.AutoSize = true;
            this.lbl_TulisanCaptain2.Location = new System.Drawing.Point(634, 123);
            this.lbl_TulisanCaptain2.Name = "lbl_TulisanCaptain2";
            this.lbl_TulisanCaptain2.Size = new System.Drawing.Size(76, 20);
            this.lbl_TulisanCaptain2.TabIndex = 8;
            this.lbl_TulisanCaptain2.Text = "Captain : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(634, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Manager :";
            // 
            // lbl_CapacityOutput
            // 
            this.lbl_CapacityOutput.AutoSize = true;
            this.lbl_CapacityOutput.Location = new System.Drawing.Point(511, 215);
            this.lbl_CapacityOutput.Name = "lbl_CapacityOutput";
            this.lbl_CapacityOutput.Size = new System.Drawing.Size(0, 20);
            this.lbl_CapacityOutput.TabIndex = 14;
            // 
            // lbl_StadiumOutput
            // 
            this.lbl_StadiumOutput.AutoSize = true;
            this.lbl_StadiumOutput.Location = new System.Drawing.Point(511, 174);
            this.lbl_StadiumOutput.Name = "lbl_StadiumOutput";
            this.lbl_StadiumOutput.Size = new System.Drawing.Size(0, 20);
            this.lbl_StadiumOutput.TabIndex = 13;
            // 
            // lbl_TulisanCapacity
            // 
            this.lbl_TulisanCapacity.AutoSize = true;
            this.lbl_TulisanCapacity.Location = new System.Drawing.Point(419, 215);
            this.lbl_TulisanCapacity.Name = "lbl_TulisanCapacity";
            this.lbl_TulisanCapacity.Size = new System.Drawing.Size(78, 20);
            this.lbl_TulisanCapacity.TabIndex = 12;
            this.lbl_TulisanCapacity.Text = "Capacity :";
            // 
            // lbl_TulisanStadium
            // 
            this.lbl_TulisanStadium.AutoSize = true;
            this.lbl_TulisanStadium.Location = new System.Drawing.Point(419, 174);
            this.lbl_TulisanStadium.Name = "lbl_TulisanStadium";
            this.lbl_TulisanStadium.Size = new System.Drawing.Size(76, 20);
            this.lbl_TulisanStadium.TabIndex = 11;
            this.lbl_TulisanStadium.Text = "Stadium :";
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(474, 253);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 37);
            this.btn_check.TabIndex = 15;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // dataGridView_Detail
            // 
            this.dataGridView_Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Detail.Location = new System.Drawing.Point(107, 379);
            this.dataGridView_Detail.Name = "dataGridView_Detail";
            this.dataGridView_Detail.RowHeadersWidth = 62;
            this.dataGridView_Detail.RowTemplate.Height = 28;
            this.dataGridView_Detail.Size = new System.Drawing.Size(846, 416);
            this.dataGridView_Detail.TabIndex = 16;
            // 
            // lbl_tulisanTanggal
            // 
            this.lbl_tulisanTanggal.AutoSize = true;
            this.lbl_tulisanTanggal.Location = new System.Drawing.Point(419, 307);
            this.lbl_tulisanTanggal.Name = "lbl_tulisanTanggal";
            this.lbl_tulisanTanggal.Size = new System.Drawing.Size(70, 20);
            this.lbl_tulisanTanggal.TabIndex = 17;
            this.lbl_tulisanTanggal.Text = "Tanggal:";
            // 
            // lbl_TulisanSkor
            // 
            this.lbl_TulisanSkor.AutoSize = true;
            this.lbl_TulisanSkor.Location = new System.Drawing.Point(419, 341);
            this.lbl_TulisanSkor.Name = "lbl_TulisanSkor";
            this.lbl_TulisanSkor.Size = new System.Drawing.Size(46, 20);
            this.lbl_TulisanSkor.TabIndex = 18;
            this.lbl_TulisanSkor.Text = "Skor:";
            // 
            // lbl_HasilTanggal
            // 
            this.lbl_HasilTanggal.AutoSize = true;
            this.lbl_HasilTanggal.Location = new System.Drawing.Point(505, 307);
            this.lbl_HasilTanggal.Name = "lbl_HasilTanggal";
            this.lbl_HasilTanggal.Size = new System.Drawing.Size(0, 20);
            this.lbl_HasilTanggal.TabIndex = 19;
            // 
            // lbl_HasilSkor
            // 
            this.lbl_HasilSkor.AutoSize = true;
            this.lbl_HasilSkor.Location = new System.Drawing.Point(505, 341);
            this.lbl_HasilSkor.Name = "lbl_HasilSkor";
            this.lbl_HasilSkor.Size = new System.Drawing.Size(0, 20);
            this.lbl_HasilSkor.TabIndex = 20;
            // 
            // FormHasilPertandingan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 836);
            this.Controls.Add(this.lbl_HasilSkor);
            this.Controls.Add(this.lbl_HasilTanggal);
            this.Controls.Add(this.lbl_TulisanSkor);
            this.Controls.Add(this.lbl_tulisanTanggal);
            this.Controls.Add(this.dataGridView_Detail);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.lbl_CapacityOutput);
            this.Controls.Add(this.lbl_StadiumOutput);
            this.Controls.Add(this.lbl_TulisanCapacity);
            this.Controls.Add(this.lbl_TulisanStadium);
            this.Controls.Add(this.lbl_CaptainAway);
            this.Controls.Add(this.lbl_ManagerAway);
            this.Controls.Add(this.lbl_TulisanCaptain2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_CaptainHome);
            this.Controls.Add(this.lbl_ManagerHome);
            this.Controls.Add(this.lbl_TulisanCaptain);
            this.Controls.Add(this.lbl_tulisanManager);
            this.Controls.Add(this.lbl_VS);
            this.Controls.Add(this.cBoxAwayTeam);
            this.Controls.Add(this.cBoxHomeTeam);
            this.Name = "FormHasilPertandingan";
            this.Text = "Hasil Pertandingan";
            this.Load += new System.EventHandler(this.FormHasilPertandingan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ComboBox cBoxHomeTeam;
        private System.Windows.Forms.ComboBox cBoxAwayTeam;
        private System.Windows.Forms.Label lbl_VS;
        private System.Windows.Forms.Label lbl_tulisanManager;
        private System.Windows.Forms.Label lbl_TulisanCaptain;
        private System.Windows.Forms.Label lbl_ManagerHome;
        private System.Windows.Forms.Label lbl_CaptainHome;
        private System.Windows.Forms.Label lbl_CaptainAway;
        private System.Windows.Forms.Label lbl_ManagerAway;
        private System.Windows.Forms.Label lbl_TulisanCaptain2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_CapacityOutput;
        private System.Windows.Forms.Label lbl_StadiumOutput;
        private System.Windows.Forms.Label lbl_TulisanCapacity;
        private System.Windows.Forms.Label lbl_TulisanStadium;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.DataGridView dataGridView_Detail;
        private System.Windows.Forms.Label lbl_tulisanTanggal;
        private System.Windows.Forms.Label lbl_TulisanSkor;
        private System.Windows.Forms.Label lbl_HasilTanggal;
        private System.Windows.Forms.Label lbl_HasilSkor;
    }
}

