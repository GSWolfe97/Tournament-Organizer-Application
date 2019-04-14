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
    public partial class CurrentMatchForm : Form
    {
        public Wrestler CurrentHomeWrestler { get; set; } = new Wrestler();
        public Wrestler CurrentAwayWrestler { get; set; } = new Wrestler();
        public Match CurrentMatch { get; set; } = new Match();
        public bool IsEditing = true;

        public CurrentMatchForm()
        {
            InitializeComponent();
        }

        private void btn_newPoint_Click(object sender, EventArgs e)
        {
            CreatePointForm createPointForm = new CreatePointForm(CurrentMatch.HomeWrestler, CurrentMatch.AwayWrestler);
            this.Hide();

            createPointForm.ShowDialog();

            if (createPointForm.NewPoint != null)
            {
                CurrentMatch.PointsScored.Add(createPointForm.NewPoint);
                lst_allPoints.Items.Add(createPointForm.NewPoint);
            }
            
            this.Show();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit match", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                IsEditing = false;
                this.Close();
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you would like to submit this match?", "Submit Match", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                IsEditing = true;
                this.Close();
            }
        }

        private void btn_editPoint_Click(object sender, EventArgs e)
        {
            CreatePointForm newPointForm = new CreatePointForm();
            newPointForm.CurrentHomeWrestler = CurrentMatch.HomeWrestler;
            newPointForm.CurrentAwayWrestler = CurrentMatch.AwayWrestler;
            newPointForm.NewPoint = (Classes.Point)lst_allPoints.SelectedItem;
            this.Hide();
            newPointForm.ShowDialog();

            if (newPointForm.NewPoint != null)
            {
                CurrentMatch.PointsScored[lst_allPoints.SelectedIndex] = newPointForm.NewPoint;
                lst_allPoints.Items[lst_allPoints.SelectedIndex] = newPointForm.NewPoint;
            }
            this.Show();
        }

        private void CurrentMatchForm_Load(object sender, EventArgs e)
        {
            lst_allPoints.Items.Clear();

            foreach (var point in CurrentMatch.PointsScored)
            {
                lst_allPoints.Items.Add(point);
            }
        }

        private void btn_removePoint_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to remove this point?", "Remove Point", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                CurrentMatch.PointsScored.RemoveAt(lst_allPoints.SelectedIndex);
                lst_allPoints.Items.RemoveAt(lst_allPoints.SelectedIndex);
            }
        }

        private void btn_viewPoint_Click(object sender, EventArgs e)
        {
            if (lst_allPoints.SelectedIndex != -1)
            {
                ViewPointForm viewPointForm = new ViewPointForm();
                viewPointForm.CurrentPoint = ((Classes.Point)lst_allPoints.SelectedItem);
                this.Hide();

                viewPointForm.ShowDialog();
            }
        }
    }
}
