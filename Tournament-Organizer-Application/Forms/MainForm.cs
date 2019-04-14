using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

using Tournament_Organizer_Application.Classes;

namespace Tournament_Organizer_Application.Forms
{
    public partial class MainForm : Form
    {
        public List<Tournament> AllTournaments { get; set; } = new List<Tournament>();
        public List<Wrestler> AllWrestlers { get; set; } = new List<Wrestler>();

        public MainForm()
        {
            InitializeComponent();
        }

        //**************************************************************
        //                       Wrestler Functions
        //**************************************************************
        private void btn_newWrestler_Click(object sender, EventArgs e)
        {
            CreateWrestlerForm createWrestlerForm = new CreateWrestlerForm();
            this.Hide();
            createWrestlerForm.ShowDialog();

            if (createWrestlerForm.NewWrestler != null)
            {
                AllWrestlers.Add(createWrestlerForm.NewWrestler);
                lst_allWrestlers.Items.Add(createWrestlerForm.NewWrestler);
            }

            this.Show();
        }

        private void btn_removeWrestler_Click(object sender, EventArgs e)
        {
            RemoveWrestler();
        }

        private void RemoveWrestler()
        {
            if (lst_allWrestlers.SelectedIndex == -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you would like to remove this wrestler?", "Remove Wrestler", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    AllWrestlers.Find(x => x.WrestlerId == ((Wrestler)lst_allWrestlers.SelectedItem).WrestlerId).RemoveWrestler();
                    lst_allWrestlers.Items.RemoveAt(lst_allWrestlers.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid wrestler");
            }
            
        }

        private void btn_editWrestler_Click(object sender, EventArgs e)
        {
            if (lst_allWrestlers.SelectedIndex != -1)
            {
                CreateWrestlerForm createWrestlerForm = new CreateWrestlerForm((Wrestler)lst_allWrestlers.SelectedItem);
                this.Hide();
                createWrestlerForm.ShowDialog();

                if (createWrestlerForm.NewWrestler != null)
                {
                    AllWrestlers[lst_allWrestlers.SelectedIndex] = createWrestlerForm.NewWrestler;
                    lst_allWrestlers.Items[lst_allWrestlers.SelectedIndex] = createWrestlerForm.NewWrestler;
                }
            }
            else
            {
                MessageBox.Show("Please select a valid wrestler");
            }

            this.Show();
        }

        //**************************************************************
        //                       Serialization Functions
        //**************************************************************
        public void Serialize()
        {
            XmlSerializer tourneySerializer = new XmlSerializer(typeof(Tournament));
            foreach (var tournament in AllTournaments)
            {
                using (var tournamentFileStream = new FileStream(@"Storage\Active\Tournament\" + tournament.TournamentId + ".txt", FileMode.OpenOrCreate))
                {
                    tourneySerializer.Serialize(tournamentFileStream, tournament);
                }
            }

            XmlSerializer wrestlerSerializer = new XmlSerializer(typeof(Wrestler));
            foreach (var wrestler in AllWrestlers)
            {
                using (var wrestlerFileStream = new FileStream(@"Storage\Active\Wrestler\" + wrestler.WrestlerId + ".txt", FileMode.OpenOrCreate))
                {
                    wrestlerSerializer.Serialize(wrestlerFileStream, wrestler);
                }
            }

            MessageBox.Show("Saved");
        }

        public void Deserialize()
        {
            CreateFolderStructures();

            XmlSerializer tourneySerializer = new XmlSerializer(typeof(Tournament));
            var allTournaments = Directory.GetFiles(@"Storage\Active\Tournament");
            foreach (var file in allTournaments)
            {
                using (var tourneyFileStream = File.Open(file, FileMode.Open))
                {
                    var tournament = (Tournament)tourneySerializer.Deserialize(tourneyFileStream);
                    AllTournaments.Add(tournament);
                    lst_allTournaments.Items.Add(tournament);
                }
            }

            XmlSerializer wrestlerSerializer = new XmlSerializer(typeof(Wrestler));
            var allWrestlers = Directory.GetFiles(@"Storage\Active\Wrestler");
            foreach (var file in allWrestlers)
            {
                using (var wrestlerFileStream = File.Open(file, FileMode.Open))
                {
                    var wrestler = (Wrestler)wrestlerSerializer.Deserialize(wrestlerFileStream);
                    AllWrestlers.Add(wrestler);
                    if (wrestler.WrestlerId != "Dummy" && wrestler.WrestlerId != "Removed")
                    {
                        lst_allWrestlers.Items.Add(wrestler);
                    }
                }
            }
        }

        public void CreateFolderStructures()
        {
            if (!Directory.Exists(@"Storage"))
            {
                Directory.CreateDirectory(@"Storage");
                Directory.CreateDirectory(@"Storage\Active");
                Directory.CreateDirectory(@"Storage\Archive");
                Directory.CreateDirectory(@"Storage\Videos");
                Directory.CreateDirectory(@"Storage\Active\Tournament");
                Directory.CreateDirectory(@"Storage\Active\Wrestler");
            }
        }

        //**************************************************************
        //                       Tournament Functions
        //**************************************************************
        private void btn_newTournament_Click(object sender, EventArgs e)
        {
            CreateTournamentForm createTournamentForm = new CreateTournamentForm();
            createTournamentForm.ShowDialog();

            if (createTournamentForm.NewTournament != null)
            {
                AllTournaments.Add(createTournamentForm.NewTournament);
                lst_allTournaments.Items.Add(createTournamentForm.NewTournament);
            }
        }

        private void btn_removeTournament_Click(object sender, EventArgs e)
        {
            RemoveTournament();
        }

        public void RemoveTournament()
        {
            if (lst_allTournaments.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove this tournament?", "Remove Tournament", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    AllTournaments.RemoveAll(x => x.TournamentId == ((Tournament)lst_allTournaments.SelectedItem).TournamentId);
                    lst_allTournaments.Items.RemoveAt(lst_allTournaments.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid tournament");
            }
        }

        private void btn_editTournament_Click(object sender, EventArgs e)
        {
            if (lst_allTournaments.SelectedIndex != -1)
            {
                CurrentTournamentForm currentTournamentForm = new CurrentTournamentForm(AllTournaments[lst_allTournaments.SelectedIndex], AllWrestlers);
                this.Hide();
                currentTournamentForm.ShowDialog();

                if (currentTournamentForm.ReturnFinished == true)
                {
                    AllTournaments[lst_allTournaments.SelectedIndex] = new Tournament(currentTournamentForm.CurrentTournament);
                }

                this.Show();
            }
            else
            {
                MessageBox.Show("Please select a valid tournament");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Deserialize();
        }

        private void tsb_save_Click(object sender, EventArgs e)
        {
            Serialize();
        }

        private void tsb_archive_Click(object sender, EventArgs e)
        {
            if (tab_statistics.SelectedIndex == 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to archive this tournament?", "Archive Tournament", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DialogResult saveResult = MessageBox.Show("You must save to continue. Save and continue?", "Archive Tournament", MessageBoxButtons.YesNo);
                    if (saveResult == DialogResult.Yes)
                    {
                        string currentDirectory = $@"Storage\Active\Tournament\{AllTournaments[lst_allTournaments.SelectedIndex].TournamentId}.txt";
                        string archiveDirectory = $@"Storage\Archive\{AllTournaments[lst_allTournaments.SelectedIndex].TournamentId}.txt";

                        Directory.Move(currentDirectory, archiveDirectory);
                        AllTournaments.RemoveAt(lst_allTournaments.SelectedIndex);
                        lst_allTournaments.Items.RemoveAt(lst_allTournaments.SelectedIndex);

                        MessageBox.Show("Tournament Archived");
                    }
                }
            }
            else if (tab_statistics.SelectedIndex == 1)
            {
                MessageBox.Show("You cannot archive wrestlers");
            }
        }

        private void tsb_delete_Click(object sender, EventArgs e)
        {
            if (tab_statistics.SelectedIndex == 0)
            {
                RemoveTournament();
            }
            else if (tab_statistics.SelectedIndex == 1)
            {
                RemoveWrestler();
            }
        }

        private void tsb_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you would like to exit?", "Exit", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DialogResult saveResult = MessageBox.Show("Would you like to save your progress?", "Save", MessageBoxButtons.YesNo);
                if (saveResult == DialogResult.Yes)
                {
                    Serialize();
                }

                this.Close();
            }
        }
    }
}
