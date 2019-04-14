namespace Tournament_Organizer_Application.Forms
{
    partial class CreatePointForm
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_awayWrestler = new System.Windows.Forms.RadioButton();
            this.rad_homeWrestler = new System.Windows.Forms.RadioButton();
            this.cmb_allScoringMethods = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_uploadFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(260, 167);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(93, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(161, 167);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(93, 23);
            this.btn_submit.TabIndex = 6;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_awayWrestler);
            this.groupBox1.Controls.Add(this.rad_homeWrestler);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 52);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Scoring Wrestler";
            // 
            // rad_awayWrestler
            // 
            this.rad_awayWrestler.AutoSize = true;
            this.rad_awayWrestler.Location = new System.Drawing.Point(175, 19);
            this.rad_awayWrestler.Name = "rad_awayWrestler";
            this.rad_awayWrestler.Size = new System.Drawing.Size(85, 17);
            this.rad_awayWrestler.TabIndex = 1;
            this.rad_awayWrestler.TabStop = true;
            this.rad_awayWrestler.Text = "radioButton2";
            this.rad_awayWrestler.UseVisualStyleBackColor = true;
            // 
            // rad_homeWrestler
            // 
            this.rad_homeWrestler.AutoSize = true;
            this.rad_homeWrestler.Location = new System.Drawing.Point(6, 19);
            this.rad_homeWrestler.Name = "rad_homeWrestler";
            this.rad_homeWrestler.Size = new System.Drawing.Size(85, 17);
            this.rad_homeWrestler.TabIndex = 0;
            this.rad_homeWrestler.TabStop = true;
            this.rad_homeWrestler.Text = "radioButton1";
            this.rad_homeWrestler.UseVisualStyleBackColor = true;
            // 
            // cmb_allScoringMethods
            // 
            this.cmb_allScoringMethods.FormattingEnabled = true;
            this.cmb_allScoringMethods.Location = new System.Drawing.Point(159, 70);
            this.cmb_allScoringMethods.Name = "cmb_allScoringMethods";
            this.cmb_allScoringMethods.Size = new System.Drawing.Size(194, 21);
            this.cmb_allScoringMethods.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Method Scored:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // btn_uploadFile
            // 
            this.btn_uploadFile.Location = new System.Drawing.Point(260, 100);
            this.btn_uploadFile.Name = "btn_uploadFile";
            this.btn_uploadFile.Size = new System.Drawing.Size(93, 23);
            this.btn_uploadFile.TabIndex = 10;
            this.btn_uploadFile.Text = "Upload Video";
            this.btn_uploadFile.UseVisualStyleBackColor = true;
            this.btn_uploadFile.Click += new System.EventHandler(this.btn_uploadFile_Click);
            // 
            // CreatePointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 202);
            this.Controls.Add(this.btn_uploadFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_allScoringMethods);
            this.Name = "CreatePointForm";
            this.Text = "CreatePointForm";
            this.Load += new System.EventHandler(this.NewPointForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_awayWrestler;
        private System.Windows.Forms.RadioButton rad_homeWrestler;
        private System.Windows.Forms.ComboBox cmb_allScoringMethods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_uploadFile;
    }
}