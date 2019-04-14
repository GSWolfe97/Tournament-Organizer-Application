namespace Tournament_Organizer_Application.Forms
{
    partial class ViewPointForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPointForm));
            this.wmp_mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbl_homeWrestler = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_awayWrestler = new System.Windows.Forms.Label();
            this.lbl_methodScored = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // wmp_mediaPlayer
            // 
            this.wmp_mediaPlayer.Enabled = true;
            this.wmp_mediaPlayer.Location = new System.Drawing.Point(16, 126);
            this.wmp_mediaPlayer.Name = "wmp_mediaPlayer";
            this.wmp_mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp_mediaPlayer.OcxState")));
            this.wmp_mediaPlayer.Size = new System.Drawing.Size(385, 295);
            this.wmp_mediaPlayer.TabIndex = 0;
            // 
            // lbl_homeWrestler
            // 
            this.lbl_homeWrestler.AutoSize = true;
            this.lbl_homeWrestler.Location = new System.Drawing.Point(13, 9);
            this.lbl_homeWrestler.Name = "lbl_homeWrestler";
            this.lbl_homeWrestler.Size = new System.Drawing.Size(35, 13);
            this.lbl_homeWrestler.TabIndex = 1;
            this.lbl_homeWrestler.Text = "label1";
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(97, 97);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(16, 97);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 23);
            this.btn_play.TabIndex = 3;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(326, 97);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_awayWrestler
            // 
            this.lbl_awayWrestler.AutoSize = true;
            this.lbl_awayWrestler.Location = new System.Drawing.Point(13, 35);
            this.lbl_awayWrestler.Name = "lbl_awayWrestler";
            this.lbl_awayWrestler.Size = new System.Drawing.Size(35, 13);
            this.lbl_awayWrestler.TabIndex = 5;
            this.lbl_awayWrestler.Text = "label1";
            // 
            // lbl_methodScored
            // 
            this.lbl_methodScored.AutoSize = true;
            this.lbl_methodScored.Location = new System.Drawing.Point(13, 60);
            this.lbl_methodScored.Name = "lbl_methodScored";
            this.lbl_methodScored.Size = new System.Drawing.Size(35, 13);
            this.lbl_methodScored.TabIndex = 6;
            this.lbl_methodScored.Text = "label1";
            // 
            // ViewPointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 433);
            this.Controls.Add(this.lbl_methodScored);
            this.Controls.Add(this.lbl_awayWrestler);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.lbl_homeWrestler);
            this.Controls.Add(this.wmp_mediaPlayer);
            this.Name = "ViewPointForm";
            this.Text = "ViewPointForm";
            this.Load += new System.EventHandler(this.ViewPointForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmp_mediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmp_mediaPlayer;
        private System.Windows.Forms.Label lbl_homeWrestler;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_awayWrestler;
        private System.Windows.Forms.Label lbl_methodScored;
    }
}