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
    public partial class CreateMatchForm : Form
    {
        public List<Wrestler> AllWrestlers { get; set; } = new List<Wrestler>();
        public Match NewMatch { get; set; }
        public CreateMatchForm()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (cmb_allHomeWrestlers.SelectedIndex != -1 && cmb_allAwayWrestlers.SelectedIndex != -1)
            {
                NewMatch = new Match();
                NewMatch.HomeWrestler = new Wrestler((Wrestler)cmb_allHomeWrestlers.SelectedItem);
                NewMatch.AwayWrestler = new Wrestler((Wrestler)cmb_allAwayWrestlers.SelectedItem);
                NewMatch.WeightClass = num_weightClass.Value;
                NewMatch.MatchName = txt_matchName.Text;
                NewMatch.PointsScored = new List<Classes.Point>();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please select two wrestlers");
            }
        }

        private void CreateMatchForm_Load(object sender, EventArgs e)
        {
            FillBoxes();
        }

        public void FillBoxes()
        {
            foreach (var wrestler in AllWrestlers)
            {
                cmb_allHomeWrestlers.Items.Add(wrestler);
                cmb_allAwayWrestlers.Items.Add(wrestler);
            }   
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Cancel Match", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                NewMatch = null;
                this.Close();
            }
        }
    }
}
