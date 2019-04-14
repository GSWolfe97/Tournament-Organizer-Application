namespace Tournament_Organizer_Application.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tab_statistics = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lst_allTournaments = new System.Windows.Forms.ListBox();
            this.btn_editTournament = new System.Windows.Forms.Button();
            this.btn_removeTournament = new System.Windows.Forms.Button();
            this.btn_newTournament = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_removeWrestler = new System.Windows.Forms.Button();
            this.btn_editWrestler = new System.Windows.Forms.Button();
            this.btn_newWrestler = new System.Windows.Forms.Button();
            this.lst_allWrestlers = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.tsb_archive = new System.Windows.Forms.ToolStripButton();
            this.tsb_delete = new System.Windows.Forms.ToolStripButton();
            this.tsb_exit = new System.Windows.Forms.ToolStripButton();
            this.tsb_break = new System.Windows.Forms.ToolStripButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_statistics.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_statistics
            // 
            this.tab_statistics.Controls.Add(this.tabPage1);
            this.tab_statistics.Controls.Add(this.tabPage2);
            this.tab_statistics.Controls.Add(this.tabPage3);
            this.tab_statistics.Location = new System.Drawing.Point(12, 42);
            this.tab_statistics.Name = "tab_statistics";
            this.tab_statistics.SelectedIndex = 0;
            this.tab_statistics.Size = new System.Drawing.Size(776, 396);
            this.tab_statistics.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lst_allTournaments);
            this.tabPage1.Controls.Add(this.btn_editTournament);
            this.tabPage1.Controls.Add(this.btn_removeTournament);
            this.tabPage1.Controls.Add(this.btn_newTournament);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tournaments";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lst_allTournaments
            // 
            this.lst_allTournaments.FormattingEnabled = true;
            this.lst_allTournaments.Location = new System.Drawing.Point(6, 36);
            this.lst_allTournaments.Name = "lst_allTournaments";
            this.lst_allTournaments.Size = new System.Drawing.Size(756, 342);
            this.lst_allTournaments.TabIndex = 7;
            // 
            // btn_editTournament
            // 
            this.btn_editTournament.Location = new System.Drawing.Point(136, 7);
            this.btn_editTournament.Name = "btn_editTournament";
            this.btn_editTournament.Size = new System.Drawing.Size(124, 23);
            this.btn_editTournament.TabIndex = 6;
            this.btn_editTournament.Text = "Edit Tournament";
            this.btn_editTournament.UseVisualStyleBackColor = true;
            this.btn_editTournament.Click += new System.EventHandler(this.btn_editTournament_Click);
            // 
            // btn_removeTournament
            // 
            this.btn_removeTournament.Location = new System.Drawing.Point(266, 7);
            this.btn_removeTournament.Name = "btn_removeTournament";
            this.btn_removeTournament.Size = new System.Drawing.Size(124, 23);
            this.btn_removeTournament.TabIndex = 5;
            this.btn_removeTournament.Text = "Remove Tournament";
            this.btn_removeTournament.UseVisualStyleBackColor = true;
            this.btn_removeTournament.Click += new System.EventHandler(this.btn_removeTournament_Click);
            // 
            // btn_newTournament
            // 
            this.btn_newTournament.Location = new System.Drawing.Point(6, 7);
            this.btn_newTournament.Name = "btn_newTournament";
            this.btn_newTournament.Size = new System.Drawing.Size(124, 23);
            this.btn_newTournament.TabIndex = 4;
            this.btn_newTournament.Text = "New Tournament";
            this.btn_newTournament.UseVisualStyleBackColor = true;
            this.btn_newTournament.Click += new System.EventHandler(this.btn_newTournament_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_removeWrestler);
            this.tabPage2.Controls.Add(this.btn_editWrestler);
            this.tabPage2.Controls.Add(this.btn_newWrestler);
            this.tabPage2.Controls.Add(this.lst_allWrestlers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wrestlers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_removeWrestler
            // 
            this.btn_removeWrestler.Location = new System.Drawing.Point(266, 7);
            this.btn_removeWrestler.Name = "btn_removeWrestler";
            this.btn_removeWrestler.Size = new System.Drawing.Size(124, 23);
            this.btn_removeWrestler.TabIndex = 11;
            this.btn_removeWrestler.Text = "Remove Wrestler";
            this.btn_removeWrestler.UseVisualStyleBackColor = true;
            this.btn_removeWrestler.Click += new System.EventHandler(this.btn_removeWrestler_Click);
            // 
            // btn_editWrestler
            // 
            this.btn_editWrestler.Location = new System.Drawing.Point(136, 7);
            this.btn_editWrestler.Name = "btn_editWrestler";
            this.btn_editWrestler.Size = new System.Drawing.Size(124, 23);
            this.btn_editWrestler.TabIndex = 10;
            this.btn_editWrestler.Text = "Edit Wrestler";
            this.btn_editWrestler.UseVisualStyleBackColor = true;
            this.btn_editWrestler.Click += new System.EventHandler(this.btn_editWrestler_Click);
            // 
            // btn_newWrestler
            // 
            this.btn_newWrestler.Location = new System.Drawing.Point(6, 7);
            this.btn_newWrestler.Name = "btn_newWrestler";
            this.btn_newWrestler.Size = new System.Drawing.Size(124, 23);
            this.btn_newWrestler.TabIndex = 9;
            this.btn_newWrestler.Text = "New Wrestler";
            this.btn_newWrestler.UseVisualStyleBackColor = true;
            this.btn_newWrestler.Click += new System.EventHandler(this.btn_newWrestler_Click);
            // 
            // lst_allWrestlers
            // 
            this.lst_allWrestlers.FormattingEnabled = true;
            this.lst_allWrestlers.Location = new System.Drawing.Point(6, 36);
            this.lst_allWrestlers.Name = "lst_allWrestlers";
            this.lst_allWrestlers.Size = new System.Drawing.Size(756, 342);
            this.lst_allWrestlers.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_save,
            this.tsb_archive,
            this.tsb_delete,
            this.tsb_exit,
            this.tsb_break});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_save
            // 
            this.tsb_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_save.Image = ((System.Drawing.Image)(resources.GetObject("tsb_save.Image")));
            this.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save.Name = "tsb_save";
            this.tsb_save.Size = new System.Drawing.Size(24, 24);
            this.tsb_save.Text = "Save";
            this.tsb_save.Click += new System.EventHandler(this.tsb_save_Click);
            // 
            // tsb_archive
            // 
            this.tsb_archive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_archive.Image = ((System.Drawing.Image)(resources.GetObject("tsb_archive.Image")));
            this.tsb_archive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_archive.Name = "tsb_archive";
            this.tsb_archive.Size = new System.Drawing.Size(24, 24);
            this.tsb_archive.Text = "Archive";
            this.tsb_archive.Click += new System.EventHandler(this.tsb_archive_Click);
            // 
            // tsb_delete
            // 
            this.tsb_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_delete.Image = ((System.Drawing.Image)(resources.GetObject("tsb_delete.Image")));
            this.tsb_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_delete.Name = "tsb_delete";
            this.tsb_delete.Size = new System.Drawing.Size(24, 24);
            this.tsb_delete.Text = "Delete";
            this.tsb_delete.Click += new System.EventHandler(this.tsb_delete_Click);
            // 
            // tsb_exit
            // 
            this.tsb_exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_exit.Image = ((System.Drawing.Image)(resources.GetObject("tsb_exit.Image")));
            this.tsb_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_exit.Name = "tsb_exit";
            this.tsb_exit.Size = new System.Drawing.Size(24, 24);
            this.tsb_exit.Text = "Exit";
            this.tsb_exit.Click += new System.EventHandler(this.tsb_exit_Click);
            // 
            // tsb_break
            // 
            this.tsb_break.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_break.Image = ((System.Drawing.Image)(resources.GetObject("tsb_break.Image")));
            this.tsb_break.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_break.Name = "tsb_break";
            this.tsb_break.Size = new System.Drawing.Size(24, 24);
            this.tsb_break.Text = "Break";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 370);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Statistics";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DO NOT DELETE STUFF WILL GO HERE";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tab_statistics);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tab_statistics.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_statistics;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lst_allTournaments;
        private System.Windows.Forms.Button btn_editTournament;
        private System.Windows.Forms.Button btn_removeTournament;
        private System.Windows.Forms.Button btn_newTournament;
        private System.Windows.Forms.Button btn_removeWrestler;
        private System.Windows.Forms.Button btn_editWrestler;
        private System.Windows.Forms.Button btn_newWrestler;
        private System.Windows.Forms.ListBox lst_allWrestlers;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ToolStripButton tsb_archive;
        private System.Windows.Forms.ToolStripButton tsb_delete;
        private System.Windows.Forms.ToolStripButton tsb_exit;
        private System.Windows.Forms.ToolStripButton tsb_break;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
    }
}