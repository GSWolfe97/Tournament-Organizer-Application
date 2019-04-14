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
    public partial class CreateTournamentForm : Form
    {
        public Tournament NewTournament { get; set; }
        public CreateTournamentForm()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            bool isValid = VerifyForm();

            if (isValid)
            {
                NewTournament = new Tournament();

                NewTournament.AllMatches = new List<Match>();
                NewTournament.Date = dtp_tournamentDate.Value;
                NewTournament.Location = txt_tournamentLocation.Text;
                NewTournament.Name = txt_tournamentName.Text;
                NewTournament.GenerateId();

                this.Close();
            }
        }

        public bool VerifyForm()
        {
            bool isValid = false;

            if (txt_tournamentLocation.Text != string.Empty && txt_tournamentName.Text != string.Empty)
            {
                isValid = true;
            }

            if (txt_tournamentName.Text == string.Empty)
            {
                MessageBox.Show("Please input a tournament's name");
            }
            if (txt_tournamentLocation.Text == string.Empty)
            {
                MessageBox.Show("Please input the tournament's location");
            }

            return isValid;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult exitResult = MessageBox.Show("Are you sure you would like to exit?", "Exit", MessageBoxButtons.YesNo);

            if (exitResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
