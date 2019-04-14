using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Tournament_Organizer_Application.Classes;

namespace Tournament_Organizer_Application.Forms
{
    public partial class CreatePointForm : Form
    {
        public Wrestler CurrentHomeWrestler { get; set; }
        public Wrestler CurrentAwayWrestler { get; set; }
        public Classes.Point NewPoint { get; set; } = new Classes.Point();
        public string VideoDirectory;

        public CreatePointForm()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you would like to exit?", "Exit Point", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                NewPoint = null;
                this.Close();
            }
        }

        public CreatePointForm(Wrestler homeWrestler, Wrestler awayWrestler)
        {
            InitializeComponent();
            CurrentHomeWrestler = homeWrestler;
            CurrentAwayWrestler = awayWrestler;
        }

        private void NewPointForm_Load(object sender, EventArgs e)
        {
            rad_homeWrestler.Text = CurrentHomeWrestler.LastName + ", " + CurrentHomeWrestler.FirstName;
            rad_awayWrestler.Text = CurrentAwayWrestler.LastName + ", " + CurrentAwayWrestler.FirstName;

            if (NewPoint.HomeScored != null)
            {
                if (NewPoint.HomeScored == true)
                {
                    rad_homeWrestler.Checked = true;
                }
                else
                {
                    rad_awayWrestler.Checked = true;
                }
            }

            cmb_allScoringMethods.Items.Clear();
            PointMethod allPointMethods = new PointMethod();
            foreach (var point in allPointMethods.AllPointMethods)
            {
                cmb_allScoringMethods.Items.Add(point);
            }

            if (NewPoint.MethodScored != null)
            {
                cmb_allScoringMethods.SelectedItem = NewPoint.MethodScored;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateForm();

            if (isValid)
            {
                PointMethod allPointsMethods = new PointMethod();

                NewPoint = new Classes.Point();
                NewPoint.MethodScored = ((Method)cmb_allScoringMethods.SelectedItem).MethodScored;
                NewPoint.PointValue = ((Method)cmb_allScoringMethods.SelectedItem).Value;
                NewPoint.HomeScored = (rad_homeWrestler.Checked == true) ? true : false;
                NewPoint.HomeWrestler = new Wrestler(CurrentHomeWrestler);
                NewPoint.AwayWrestler = new Wrestler(CurrentAwayWrestler);

                if (VideoDirectory != null)
                {
                    NewPoint.VideoDirectory = VideoDirectory;
                }
                else
                {
                    NewPoint.VideoDirectory = "novideo";
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a wrestler and a point method");
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            if ((!rad_homeWrestler.Checked && !rad_awayWrestler.Checked) || cmb_allScoringMethods.SelectedIndex == -1)
            {
                isValid = false;
            }

            return isValid;
        }

        private void btn_uploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string newDirectory = @"C:\Users\Sheldon\Desktop\WrestlingFolders\Videos\" + Guid.NewGuid().ToString() + Path.GetExtension(openFileDialog.FileName);

                File.Move(openFileDialog.FileName, newDirectory);
                VideoDirectory = newDirectory;
            }
        }
    }
}
