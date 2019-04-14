namespace Tournament_Organizer_Application.Forms
{
    partial class CurrentMatchForm
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
            this.lst_allPoints = new System.Windows.Forms.ListBox();
            this.btn_editPoint = new System.Windows.Forms.Button();
            this.btn_removePoint = new System.Windows.Forms.Button();
            this.btn_newPoint = new System.Windows.Forms.Button();
            this.btn_viewPoint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(524, 27);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(124, 23);
            this.btn_submit.TabIndex = 23;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(654, 27);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(124, 23);
            this.btn_cancel.TabIndex = 22;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lst_allPoints
            // 
            this.lst_allPoints.FormattingEnabled = true;
            this.lst_allPoints.Location = new System.Drawing.Point(22, 95);
            this.lst_allPoints.Name = "lst_allPoints";
            this.lst_allPoints.Size = new System.Drawing.Size(756, 329);
            this.lst_allPoints.TabIndex = 21;
            // 
            // btn_editPoint
            // 
            this.btn_editPoint.Location = new System.Drawing.Point(152, 27);
            this.btn_editPoint.Name = "btn_editPoint";
            this.btn_editPoint.Size = new System.Drawing.Size(124, 23);
            this.btn_editPoint.TabIndex = 20;
            this.btn_editPoint.Text = "Edit Point";
            this.btn_editPoint.UseVisualStyleBackColor = true;
            this.btn_editPoint.Click += new System.EventHandler(this.btn_editPoint_Click);
            // 
            // btn_removePoint
            // 
            this.btn_removePoint.Location = new System.Drawing.Point(282, 27);
            this.btn_removePoint.Name = "btn_removePoint";
            this.btn_removePoint.Size = new System.Drawing.Size(124, 23);
            this.btn_removePoint.TabIndex = 19;
            this.btn_removePoint.Text = "Remove Point";
            this.btn_removePoint.UseVisualStyleBackColor = true;
            this.btn_removePoint.Click += new System.EventHandler(this.btn_removePoint_Click);
            // 
            // btn_newPoint
            // 
            this.btn_newPoint.Location = new System.Drawing.Point(22, 27);
            this.btn_newPoint.Name = "btn_newPoint";
            this.btn_newPoint.Size = new System.Drawing.Size(124, 23);
            this.btn_newPoint.TabIndex = 18;
            this.btn_newPoint.Text = "New Point";
            this.btn_newPoint.UseVisualStyleBackColor = true;
            this.btn_newPoint.Click += new System.EventHandler(this.btn_newPoint_Click);
            // 
            // btn_viewPoint
            // 
            this.btn_viewPoint.Location = new System.Drawing.Point(152, 57);
            this.btn_viewPoint.Name = "btn_viewPoint";
            this.btn_viewPoint.Size = new System.Drawing.Size(124, 23);
            this.btn_viewPoint.TabIndex = 24;
            this.btn_viewPoint.Text = "View Point";
            this.btn_viewPoint.UseVisualStyleBackColor = true;
            this.btn_viewPoint.Click += new System.EventHandler(this.btn_viewPoint_Click);
            // 
            // CurrentMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_viewPoint);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lst_allPoints);
            this.Controls.Add(this.btn_editPoint);
            this.Controls.Add(this.btn_removePoint);
            this.Controls.Add(this.btn_newPoint);
            this.Name = "CurrentMatchForm";
            this.Text = "CurrentMatchForm";
            this.Load += new System.EventHandler(this.CurrentMatchForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ListBox lst_allPoints;
        private System.Windows.Forms.Button btn_editPoint;
        private System.Windows.Forms.Button btn_removePoint;
        private System.Windows.Forms.Button btn_newPoint;
        private System.Windows.Forms.Button btn_viewPoint;
    }
}