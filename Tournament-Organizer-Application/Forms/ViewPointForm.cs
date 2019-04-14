using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Tournament_Organizer_Application.Classes;

namespace Tournament_Organizer_Application.Forms
{
    public partial class ViewPointForm : Form
    {
        public Classes.Point CurrentPoint { get; set; }
        public ViewPointForm()
        {
            InitializeComponent();
        }

        private void ViewPointForm_Load(object sender, EventArgs e)
        {
            lbl_homeWrestler.Text = $@"{CurrentPoint.HomeWrestler}";
            lbl_awayWrestler.Text = CurrentPoint.AwayWrestler.ToString();
            lbl_methodScored.Text = $"{ CurrentPoint.MethodScored} for { CurrentPoint.PointValue}{ ((CurrentPoint.PointValue == 1) ? "pt" : "pts")}";

        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            wmp_mediaPlayer.URL = CurrentPoint.VideoDirectory;
            wmp_mediaPlayer.Ctlcontrols.play();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            wmp_mediaPlayer.Ctlcontrols.stop();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            wmp_mediaPlayer.Ctlcontrols.stop();
            this.Close();
        }
    }
}
