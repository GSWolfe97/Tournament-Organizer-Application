namespace Tournament_Organizer_Application.Forms
{
    partial class CreateMatchForm
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
            this.cmb_allAwayWrestlers = new System.Windows.Forms.ComboBox();
            this.cmb_allHomeWrestlers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.num_weightClass = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_matchName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_weightClass)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_allAwayWrestlers
            // 
            this.cmb_allAwayWrestlers.FormattingEnabled = true;
            this.cmb_allAwayWrestlers.Location = new System.Drawing.Point(129, 48);
            this.cmb_allAwayWrestlers.Name = "cmb_allAwayWrestlers";
            this.cmb_allAwayWrestlers.Size = new System.Drawing.Size(181, 21);
            this.cmb_allAwayWrestlers.TabIndex = 7;
            // 
            // cmb_allHomeWrestlers
            // 
            this.cmb_allHomeWrestlers.FormattingEnabled = true;
            this.cmb_allHomeWrestlers.Location = new System.Drawing.Point(129, 21);
            this.cmb_allHomeWrestlers.Name = "cmb_allHomeWrestlers";
            this.cmb_allHomeWrestlers.Size = new System.Drawing.Size(181, 21);
            this.cmb_allHomeWrestlers.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Away Wreslter:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Home Wrestler:";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(154, 142);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 9;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(235, 142);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Weight Class:";
            // 
            // num_weightClass
            // 
            this.num_weightClass.Location = new System.Drawing.Point(190, 75);
            this.num_weightClass.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_weightClass.Name = "num_weightClass";
            this.num_weightClass.Size = new System.Drawing.Size(120, 20);
            this.num_weightClass.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Match Name:";
            // 
            // txt_matchName
            // 
            this.txt_matchName.Location = new System.Drawing.Point(129, 101);
            this.txt_matchName.Name = "txt_matchName";
            this.txt_matchName.Size = new System.Drawing.Size(181, 20);
            this.txt_matchName.TabIndex = 13;
            // 
            // CreateMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 180);
            this.Controls.Add(this.txt_matchName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num_weightClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.cmb_allAwayWrestlers);
            this.Controls.Add(this.cmb_allHomeWrestlers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateMatchForm";
            this.Text = "CreateMatchForm";
            this.Load += new System.EventHandler(this.CreateMatchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_weightClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_allAwayWrestlers;
        private System.Windows.Forms.ComboBox cmb_allHomeWrestlers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_weightClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_matchName;
    }
}