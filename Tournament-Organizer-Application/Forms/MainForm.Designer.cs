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
            this.lst_allTournaments = new System.Windows.Forms.ListBox();
            this.btn_editTournament = new System.Windows.Forms.Button();
            this.btn_removeTournament = new System.Windows.Forms.Button();
            this.btn_newTournament = new System.Windows.Forms.Button();
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
            //this.tab_Tournaments.SuspendLayout();
            //this.tab_Wrestlers.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            this.tab_Wrestlers = new System.Windows.Forms.TabPage();
            this.tab_Tournaments = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_tournamentsTab = new System.Windows.Forms.Button();
            this.btn_wrestlersTab = new System.Windows.Forms.Button();
            this.btn_tournamentsTab1 = new System.Windows.Forms.Button();
            this.btn_wrestlersTab1 = new System.Windows.Forms.Button();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Tournament_Organizer_Application.Properties.Resources.Logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 114);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Tournament_Organizer_Application.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 114);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tab_statistics
            // 
            this.tab_statistics.Controls.Add(this.tab_Tournaments);
            this.tab_statistics.Controls.Add(this.tab_Wrestlers);
            this.tab_statistics.Controls.Add(this.tabPage3);
            this.tab_statistics.Location = new System.Drawing.Point(12, 42);
            this.tab_statistics.Name = "tab_statistics";
            this.tab_statistics.SelectedIndex = 0;
            this.tab_statistics.Size = new System.Drawing.Size(1260, 680);
            this.tab_statistics.TabIndex = 3;
            // 
            // tab_Tournaments
            // 
            this.tab_Tournaments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.tab_Tournaments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_Tournaments.Controls.Add(this.btn_tournamentsTab);
            this.tab_Tournaments.Controls.Add(this.pictureBox1);
            this.tab_Tournaments.Controls.Add(this.btn_wrestlersTab);
            this.tab_Tournaments.Controls.Add(this.lst_allTournaments);
            this.tab_Tournaments.Controls.Add(this.btn_editTournament);
            this.tab_Tournaments.Controls.Add(this.btn_removeTournament);
            this.tab_Tournaments.Controls.Add(this.btn_newTournament);
            this.tab_Tournaments.Location = new System.Drawing.Point(4, 22);
            this.tab_Tournaments.Name = "tab_Tournaments";
            this.tab_Tournaments.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Tournaments.Size = new System.Drawing.Size(1252, 654);
            this.tab_Tournaments.TabIndex = 0;
            this.tab_Tournaments.Text = "Tournaments";
            // 
            // lst_allTournaments
            // 
            this.lst_allTournaments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.lst_allTournaments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_allTournaments.ForeColor = System.Drawing.Color.Silver;
            this.lst_allTournaments.FormattingEnabled = true;
            this.lst_allTournaments.ItemHeight = 24;
            this.lst_allTournaments.Location = new System.Drawing.Point(239, 91);
            this.lst_allTournaments.Name = "lst_allTournaments";
            this.lst_allTournaments.Size = new System.Drawing.Size(990, 532);
            this.lst_allTournaments.TabIndex = 3;
            // 
            // btn_editTournament
            // 
            this.btn_editTournament.BackgroundImage = global::Tournament_Organizer_Application.Properties.Resources.Tournements_Edit;
            this.btn_editTournament.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_editTournament.FlatAppearance.BorderSize = 2;
            this.btn_editTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editTournament.Location = new System.Drawing.Point(410, 26);
            this.btn_editTournament.Name = "btn_editTournament";
            this.btn_editTournament.Size = new System.Drawing.Size(165, 59);
            this.btn_editTournament.TabIndex = 2;
            this.btn_editTournament.UseVisualStyleBackColor = true;
            this.btn_editTournament.Click += new System.EventHandler(this.btn_editTournament_Click);
            // 
            // btn_removeTournament
            // 
            this.btn_removeTournament.BackgroundImage = global::Tournament_Organizer_Application.Properties.Resources.Tournements_Delete;
            this.btn_removeTournament.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_removeTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_removeTournament.FlatAppearance.BorderSize = 2;
            this.btn_removeTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeTournament.Location = new System.Drawing.Point(581, 26);
            this.btn_removeTournament.Name = "btn_removeTournament";
            this.btn_removeTournament.Size = new System.Drawing.Size(165, 59);
            this.btn_removeTournament.TabIndex = 1;
            this.btn_removeTournament.UseVisualStyleBackColor = true;
            // 
            // btn_newTournament
            // 
            this.btn_newTournament.BackgroundImage = global::Tournament_Organizer_Application.Properties.Resources.Tournements_Add;
            this.btn_newTournament.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_newTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_newTournament.FlatAppearance.BorderSize = 2;
            this.btn_newTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newTournament.Location = new System.Drawing.Point(239, 26);
            this.btn_newTournament.Name = "btn_newTournament";
            this.btn_newTournament.Size = new System.Drawing.Size(165, 59);
            this.btn_newTournament.TabIndex = 0;
            this.btn_newTournament.UseVisualStyleBackColor = true;
            this.btn_newTournament.Click += new System.EventHandler(this.btn_newTournament_Click);
            // 
            // tab_Wrestlers
            // 
            this.tab_Wrestlers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.tab_Wrestlers.Controls.Add(this.btn_wrestlersTab1);
            this.tab_Wrestlers.Controls.Add(this.btn_tournamentsTab1);
            this.tab_Wrestlers.Controls.Add(this.pictureBox2);
            this.tab_Wrestlers.Controls.Add(this.btn_removeWrestler);
            this.tab_Wrestlers.Controls.Add(this.btn_editWrestler);
            this.tab_Wrestlers.Controls.Add(this.btn_newWrestler);
            this.tab_Wrestlers.Controls.Add(this.lst_allWrestlers);
            this.tab_Wrestlers.Location = new System.Drawing.Point(4, 22);
            this.tab_Wrestlers.Name = "tab_Wrestlers";
            this.tab_Wrestlers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Wrestlers.Size = new System.Drawing.Size(1252, 654);
            this.tab_Wrestlers.TabIndex = 1;
            this.tab_Wrestlers.Text = "Wrestlers";
            // 
            // btn_removeWrestler
            // 
            this.btn_removeWrestler.BackgroundImage = global::Tournament_Organizer_Application.Properties.Resources.Wrestlers_Delete;
            this.btn_removeWrestler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_removeWrestler.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_removeWrestler.FlatAppearance.BorderSize = 2;
            this.btn_removeWrestler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeWrestler.Location = new System.Drawing.Point(581, 26);
            this.btn_removeWrestler.Name = "btn_removeWrestler";
            this.btn_removeWrestler.Size = new System.Drawing.Size(165, 59);
            this.btn_removeWrestler.TabIndex = 7;
            this.btn_removeWrestler.UseVisualStyleBackColor = true;
            this.btn_removeWrestler.Click += new System.EventHandler(this.btn_removeWrestler_Click);
            // 
            // btn_editWrestler
            // 
            this.btn_editWrestler.BackgroundImage = global::Tournament_Organizer_Application.Properties.Resources.Wrestlers_Edit;
            this.btn_editWrestler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editWrestler.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_editWrestler.FlatAppearance.BorderSize = 2;
            this.btn_editWrestler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editWrestler.Location = new System.Drawing.Point(410, 26);
            this.btn_editWrestler.Name = "btn_editWrestler";
            this.btn_editWrestler.Size = new System.Drawing.Size(165, 59);
            this.btn_editWrestler.TabIndex = 6;
            this.btn_editWrestler.UseVisualStyleBackColor = true;
            this.btn_editWrestler.Click += new System.EventHandler(this.btn_editWrestler_Click);
            // 
            // btn_newWrestler
            // 
            this.btn_newWrestler.BackgroundImage = global::Tournament_Organizer_Application.Properties.Resources.Wrestlers_Add;
            this.btn_newWrestler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_newWrestler.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_newWrestler.FlatAppearance.BorderSize = 2;
            this.btn_newWrestler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newWrestler.Location = new System.Drawing.Point(239, 26);
            this.btn_newWrestler.Name = "btn_newWrestler";
            this.btn_newWrestler.Size = new System.Drawing.Size(165, 59);
            this.btn_newWrestler.TabIndex = 5;
            this.btn_newWrestler.UseVisualStyleBackColor = true;
            this.btn_newWrestler.Click += new System.EventHandler(this.btn_newWrestler_Click);
            // 
            // lst_allWrestlers
            // 
            this.lst_allWrestlers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.lst_allWrestlers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_allWrestlers.ForeColor = System.Drawing.Color.Silver;
            this.lst_allWrestlers.FormattingEnabled = true;
            this.lst_allWrestlers.ItemHeight = 24;
            this.lst_allWrestlers.Location = new System.Drawing.Point(239, 91);
            this.lst_allWrestlers.Name = "lst_allWrestlers";
            this.lst_allWrestlers.Size = new System.Drawing.Size(990, 532);
            this.lst_allWrestlers.TabIndex = 0;
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
            // btn_tournamentsTab
            // 
            this.btn_tournamentsTab.BackgroundImage = global::Tournament_Organizer_Application.Properties.Resources.Tournaments;
            this.btn_tournamentsTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tournamentsTab.FlatAppearance.BorderSize = 0;
            this.btn_tournamentsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tournamentsTab.Location = new System.Drawing.Point(6, 135);
            this.btn_tournamentsTab.Name = "btn_tournamentsTab";
            this.btn_tournamentsTab.Size = new System.Drawing.Size(201, 63);
            this.btn_tournamentsTab.TabIndex = 6;
            this.btn_tournamentsTab.TabStop = false;
            this.btn_tournamentsTab.UseVisualStyleBackColor = true;
            this.btn_tournamentsTab.Click += new System.EventHandler(this.btn_tournamentsTab_Click);
            // 
            // btn_wrestlersTab
            // 
            this.btn_wrestlersTab.BackgroundImage = global::Tournament_Organizer_Application.Properties.Resources.Wrestlers;
            this.btn_wrestlersTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_wrestlersTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_wrestlersTab.FlatAppearance.BorderSize = 0;
            this.btn_wrestlersTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wrestlersTab.Location = new System.Drawing.Point(6, 200);
            this.btn_wrestlersTab.Name = "btn_wrestlersTab";
            this.btn_wrestlersTab.Size = new System.Drawing.Size(201, 63);
            this.btn_wrestlersTab.TabIndex = 4;
            this.btn_wrestlersTab.TabStop = false;
            this.btn_wrestlersTab.UseVisualStyleBackColor = true;
            this.btn_wrestlersTab.Click += new System.EventHandler(this.btn_wrestlerTab_Click);
            // 
            // btn_tournamentsTab1
            // 
            this.btn_tournamentsTab1.BackgroundImage = global::Tournament_Organizer_Application.Properties.Resources.Tournaments;
            this.btn_tournamentsTab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tournamentsTab1.FlatAppearance.BorderSize = 0;
            this.btn_tournamentsTab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tournamentsTab1.Location = new System.Drawing.Point(6, 135);
            this.btn_tournamentsTab1.Name = "btn_tournamentsTab1";
            this.btn_tournamentsTab1.Size = new System.Drawing.Size(201, 63);
            this.btn_tournamentsTab1.TabIndex = 9;
            this.btn_tournamentsTab1.TabStop = false;
            this.btn_tournamentsTab1.UseVisualStyleBackColor = true;
            this.btn_tournamentsTab1.Click += new System.EventHandler(this.btn_tournamentsTab_Click);
            // 
            // btn_wrestlersTab1
            // 
            this.btn_wrestlersTab1.BackgroundImage = global::Tournament_Organizer_Application.Properties.Resources.Wrestlers;
            this.btn_wrestlersTab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_wrestlersTab1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_wrestlersTab1.FlatAppearance.BorderSize = 0;
            this.btn_wrestlersTab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wrestlersTab1.Location = new System.Drawing.Point(6, 200);
            this.btn_wrestlersTab1.Name = "btn_wrestlersTab1";
            this.btn_wrestlersTab1.Size = new System.Drawing.Size(201, 63);
            this.btn_wrestlersTab1.TabIndex = 10;
            this.btn_wrestlersTab1.TabStop = false;
            this.btn_wrestlersTab1.UseVisualStyleBackColor = true;
            this.btn_wrestlersTab1.Click += new System.EventHandler(this.btn_wrestlerTab_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 680);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tab_statistics);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tab_statistics.ResumeLayout(false);
            this.tab_Tournaments.ResumeLayout(false);
            this.tab_Wrestlers.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_statistics;
        private System.Windows.Forms.TabPage tab_Tournaments;
        private System.Windows.Forms.TabPage tab_Wrestlers;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_wrestlersTab1;
        private System.Windows.Forms.Button btn_tournamentsTab1;
        private System.Windows.Forms.Button btn_wrestlersTab;
        private System.Windows.Forms.Button btn_tournamentsTab;
    }
}
