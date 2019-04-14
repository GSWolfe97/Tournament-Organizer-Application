namespace Tournament_Organizer_Application.Forms
{
    partial class CurrentTournamentForm
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
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lst_allMatches = new System.Windows.Forms.ListBox();
            this.btn_editMatch = new System.Windows.Forms.Button();
            this.btn_removeMatch = new System.Windows.Forms.Button();
            this.btn_newMatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(524, 27);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(124, 23);
            this.btn_submit.TabIndex = 16;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(654, 27);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(124, 23);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lst_allMatches
            // 
            this.lst_allMatches.FormattingEnabled = true;
            this.lst_allMatches.Location = new System.Drawing.Point(22, 56);
            this.lst_allMatches.Name = "lst_allMatches";
            this.lst_allMatches.Size = new System.Drawing.Size(756, 368);
            this.lst_allMatches.TabIndex = 14;
            // 
            // btn_editMatch
            // 
            this.btn_editMatch.Location = new System.Drawing.Point(152, 27);
            this.btn_editMatch.Name = "btn_editMatch";
            this.btn_editMatch.Size = new System.Drawing.Size(124, 23);
            this.btn_editMatch.TabIndex = 13;
            this.btn_editMatch.Text = "Edit Match";
            this.btn_editMatch.UseVisualStyleBackColor = true;
            this.btn_editMatch.Click += new System.EventHandler(this.btn_editMatch_Click);
            // 
            // btn_removeMatch
            // 
            this.btn_removeMatch.Location = new System.Drawing.Point(282, 27);
            this.btn_removeMatch.Name = "btn_removeMatch";
            this.btn_removeMatch.Size = new System.Drawing.Size(124, 23);
            this.btn_removeMatch.TabIndex = 12;
            this.btn_removeMatch.Text = "Remove Match";
            this.btn_removeMatch.UseVisualStyleBackColor = true;
            this.btn_removeMatch.Click += new System.EventHandler(this.btn_removeMatch_Click);
            // 
            // btn_newMatch
            // 
            this.btn_newMatch.Location = new System.Drawing.Point(22, 27);
            this.btn_newMatch.Name = "btn_newMatch";
            this.btn_newMatch.Size = new System.Drawing.Size(124, 23);
            this.btn_newMatch.TabIndex = 11;
            this.btn_newMatch.Text = "New Match";
            this.btn_newMatch.UseVisualStyleBackColor = true;
            this.btn_newMatch.Click += new System.EventHandler(this.btn_newMatch_Click);
            // 
            // CurrentTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lst_allMatches);
            this.Controls.Add(this.btn_editMatch);
            this.Controls.Add(this.btn_removeMatch);
            this.Controls.Add(this.btn_newMatch);
            this.Name = "CurrentTournamentForm";
            this.Text = "CurrentTournamentForm";
            this.Load += new System.EventHandler(this.CurrentTournamentForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ListBox lst_allMatches;
        private System.Windows.Forms.Button btn_editMatch;
        private System.Windows.Forms.Button btn_removeMatch;
        private System.Windows.Forms.Button btn_newMatch;
    }
}