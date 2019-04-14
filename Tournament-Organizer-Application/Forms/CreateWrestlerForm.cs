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
    public partial class CreateWrestlerForm : Form
    {
        public Wrestler NewWrestler { get; set; } = new Wrestler();
        public bool IsEditing;
        public CreateWrestlerForm()
        {
            InitializeComponent();
        }

        public CreateWrestlerForm(Wrestler wrestler)
        {
            InitializeComponent();

            txt_wrestlerFirstName.Text = wrestler.FirstName;
            txt_wrestlerLastName.Text = wrestler.LastName;
            txt_wrestlerSchool.Text = wrestler.School;
            dtp_birthDate.Value = wrestler.BirthDay;

            NewWrestler = wrestler;
            IsEditing = true;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateForm();

            if (isValid)
            {
                NewWrestler.BirthDay = dtp_birthDate.Value;
                NewWrestler.FirstName = txt_wrestlerFirstName.Text;
                NewWrestler.LastName = txt_wrestlerLastName.Text;
                NewWrestler.School = txt_wrestlerSchool.Text;
                NewWrestler.CalculateBirthday();
                
                if (!IsEditing)
                {
                    if (NewWrestler.WrestlerId != "Removed")
                    {
                        NewWrestler.GenerateId();
                    }
                }

                this.Close();
            }
        }

        public bool ValidateForm()
        {
            bool isValid = true;

            if (txt_wrestlerFirstName.Text == string.Empty)
            {
                MessageBox.Show("Please input the wrestler's first name.");
                isValid = false;
            }
            if (txt_wrestlerLastName.Text == string.Empty)
            {
                MessageBox.Show("Please input the wrestler's last name.");
                isValid = false;
            }
            if (txt_wrestlerSchool.Text == string.Empty)
            {
                MessageBox.Show("Please input the wrestler's school.");
                isValid = false;
            }
            if (dtp_birthDate.Value > DateTime.Now)
            {
                MessageBox.Show("Please input the wrestler's age.");
                isValid = false;
            }

            return isValid;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult exitResult = MessageBox.Show("Are you sure you would like to exit?", "Exit", MessageBoxButtons.YesNo);

            if (exitResult == DialogResult.Yes)
            {
                NewWrestler = null;
                this.Close();
            }
        }
    }
}
