using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConferenceScheduleManagerT
{
    public partial class SpeakerManagmentForm : Form
    {
        public SpeakerManagmentForm()
        {
            InitializeComponent();
            LoadSpeakersToGrid();
        }

        private void LoadSpeakersToGrid()
        {
            dgvSpeakers.DataSource = null;
            dgvSpeakers.DataSource = MainForm.SpeakerManager.dataList;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // check ID
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Speaker's ID is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
                return;
            }

            //check name
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Speaker's Name is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAffiliation.Text))
            {
                MessageBox.Show("Affiliation is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAffiliation.Focus();
                return;
            }

            Speaker newSpeaker = new Speaker();
            newSpeaker.ID = txtID.Text.Trim();
            newSpeaker.Name = txtName.Text.Trim();
            newSpeaker.Affiliation = txtAffiliation.Text.Trim();
            newSpeaker.Biography = txtBiography.Text.Trim();

            MainForm.SpeakerManager.dataList.Add(newSpeaker);

            MessageBox.Show("Speaker '" + newSpeaker.Name + "' added successfully!",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadSpeakersToGrid();
            ClearFields();
        }

        private void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtAffiliation.Clear();
            txtBiography.Clear();
            txtID.Focus();
        }

        private void SpeakerManagmentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please enter a Speaker ID to update.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //search for speaker
            Speaker foundSpeaker = null;
            for (int j = 0; j < MainForm.SpeakerManager.dataList.Count; j++)
            {
                Speaker spkr = MainForm.SpeakerManager.dataList[j];
                if (spkr.ID.ToLower() == txtID.Text.Trim().ToLower())
                {
                    foundSpeaker = spkr;
                    break;
                }
            }

            if (foundSpeaker == null)
            {
                MessageBox.Show("Speaker with ID '" + txtID.Text + "' not found.",
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //update speaker info
            foundSpeaker.Name = txtName.Text.Trim();
            foundSpeaker.Affiliation = txtAffiliation.Text.Trim();
            foundSpeaker.Biography = txtBiography.Text.Trim();

            MessageBox.Show("Speaker '" + foundSpeaker.ID + "' updated successfully!",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadSpeakersToGrid();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please enter a Speaker ID to delete.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Speaker speakerToDelete = null;
            for (int index = 0; index < MainForm.SpeakerManager.dataList.Count; index++)
            {
                Speaker currentSpeaker = MainForm.SpeakerManager.dataList[index];
                if (currentSpeaker.ID.ToLower() == txtID.Text.Trim().ToLower())
                {
                    speakerToDelete = currentSpeaker;
                    break;
                }
            }

            if (speakerToDelete == null)
            {
                MessageBox.Show("Speaker with ID '" + txtID.Text + "' not found.",
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
               "Are you sure you want to delete speaker '" + speakerToDelete.Name + "'?",
               "Confirm Delete",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MainForm.SpeakerManager.dataList.Remove(speakerToDelete);
                MessageBox.Show("Speaker deleted successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSpeakersToGrid();
                ClearFields();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKey = txtSearchKey.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchKey))
            {
                LoadSpeakersToGrid();
                return;
            }

            List<Speaker> results = new List<Speaker>();

            //loop to find matching speakers
            for (int i = 0; i < MainForm.SpeakerManager.dataList.Count; i++)
            {
                Speaker speaker = MainForm.SpeakerManager.dataList[i];

                bool idMatch = speaker.ID.ToLower().Contains(searchKey.ToLower());
                bool nameMatch = speaker.Name.ToLower().Contains(searchKey.ToLower());

                if (idMatch == true || nameMatch == true)
                {
                    results.Add(speaker);
                }
            }

            dgvSpeakers.DataSource = null;
            dgvSpeakers.DataSource = results;

            if (results.Count == 0)
            {
                MessageBox.Show("No speakers found matching '" + searchKey + "'.",
                    "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSpeakersToGrid();
            txtSearchKey.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtAffiliation.Clear();
            txtBiography.Clear();
            txtID.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSpeakers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSpeakers.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtAffiliation.Text = row.Cells["Affiliation"].Value.ToString();
                txtBiography.Text = row.Cells["Biography"].Value.ToString();
            }
        }
    }
}
