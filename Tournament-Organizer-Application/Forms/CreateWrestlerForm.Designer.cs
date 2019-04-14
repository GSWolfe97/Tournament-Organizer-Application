namespace Tournament_Organizer_Application.Forms
{
    partial class CreateWrestlerForm
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
            this.dtp_birthDate = new System.Windows.Forms.DateTimePicker();
            this.txt_wrestlerSchool = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_wrestlerLastName = new System.Windows.Forms.TextBox();
            this.txt_wrestlerFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtp_birthDate
            // 
            this.dtp_birthDate.Location = new System.Drawing.Point(138, 94);
            this.dtp_birthDate.Name = "dtp_birthDate";
            this.dtp_birthDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_birthDate.TabIndex = 24;
            // 
            // txt_wrestlerSchool
            // 
            this.txt_wrestlerSchool.Location = new System.Drawing.Point(138, 68);
            this.txt_wrestlerSchool.Name = "txt_wrestlerSchool";
            this.txt_wrestlerSchool.Size = new System.Drawing.Size(200, 20);
            this.txt_wrestlerSchool.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Wrestler Birthday:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Wrestler School:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(263, 136);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 25;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(182, 136);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 26;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_wrestlerLastName
            // 
            this.txt_wrestlerLastName.Location = new System.Drawing.Point(138, 42);
            this.txt_wrestlerLastName.Name = "txt_wrestlerLastName";
            this.txt_wrestlerLastName.Size = new System.Drawing.Size(200, 20);
            this.txt_wrestlerLastName.TabIndex = 22;
            // 
            // txt_wrestlerFirstName
            // 
            this.txt_wrestlerFirstName.Location = new System.Drawing.Point(138, 16);
            this.txt_wrestlerFirstName.Name = "txt_wrestlerFirstName";
            this.txt_wrestlerFirstName.Size = new System.Drawing.Size(200, 20);
            this.txt_wrestlerFirstName.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Wrestler Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Wrestler  First Name:";
            // 
            // CreateWrestlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 182);
            this.Controls.Add(this.dtp_birthDate);
            this.Controls.Add(this.txt_wrestlerSchool);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_wrestlerLastName);
            this.Controls.Add(this.txt_wrestlerFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateWrestlerForm";
            this.Text = "CreateWrestlerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_birthDate;
        private System.Windows.Forms.TextBox txt_wrestlerSchool;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_wrestlerLastName;
        private System.Windows.Forms.TextBox txt_wrestlerFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}