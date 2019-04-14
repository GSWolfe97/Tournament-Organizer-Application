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
    public partial class CurrentTournamentForm : Form
    {
        public Tournament CurrentTournament { get; set; }
        public List<Wrestler> AllWrestlers { get; set; } = new List<Wrestler>();

        public bool ReturnFinished = false;

        public CurrentTournamentForm(Tournament tournament, List<Wrestler> allWrestlers)
        {
            InitializeComponent();

            CurrentTournament = new Tournament(tournament);

            foreach (Wrestler wrestler in allWrestlers)
            {
                Wrestler newWrestler = new Wrestler(wrestler);
                AllWrestlers.Add(newWrestler);
            }
        }

        public CurrentTournamentForm()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Exit Tournament", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ReturnFinished = false;
                this.Close();
            }
        }

        private void btn_newMatch_Click(object sender, EventArgs e)
        {
            CreateMatchForm createMatchForm = new CreateMatchForm();
            createMatchForm.AllWrestlers = AllWrestlers;

            this.Hide();
            createMatchForm.ShowDialog();

            if (createMatchForm.NewMatch != null)
            {
                CurrentTournament.AllMatches.Add(createMatchForm.NewMatch);
                lst_allMatches.Items.Add(createMatchForm.NewMatch);
            }

            this.Show();
        }

        private void btn_removeMatch_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to remove this match?", "Remove Match", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                CurrentTournament.AllMatches.RemoveAt(lst_allMatches.SelectedIndex);
                lst_allMatches.Items.RemoveAt(lst_allMatches.SelectedIndex);
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to submit this tournament?", "Submit Tournament", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ReturnFinished = true;
                this.Close();
            }
        }

        private void CurrentTournamentForm_Load(object sender, EventArgs e)
        {
            lst_allMatches.Items.Clear();
            foreach (var match in CurrentTournament.AllMatches)
            {
                lst_allMatches.Items.Add(match);
            }
        }

        private void btn_editMatch_Click(object sender, EventArgs e)
        {
            if (lst_allMatches.SelectedIndex != -1)
            {
                CurrentMatchForm currentMatchForm = new CurrentMatchForm();
                currentMatchForm.CurrentMatch = new Match(CurrentTournament.AllMatches[lst_allMatches.SelectedIndex]);
                this.Hide();
                currentMatchForm.ShowDialog();

                if (currentMatchForm.IsEditing == true)
                {
                    CurrentTournament.AllMatches[lst_allMatches.SelectedIndex] = currentMatchForm.CurrentMatch;
                }

                this.Show();
            }
            else
            {
                MessageBox.Show("Please select a valid match");
            }
        }
    }
}
