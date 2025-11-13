using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConferenceScheduleManagerT
{
    public partial class SessionManagementForm : Form
    {
        public SessionManagementForm()
        {
            InitializeComponent();
            LoadSessionsToGrid();
            cmbType.SelectedIndex = 0;
        }

        private void LoadSessionsToGrid()
        {
            dgvSessions.DataSource = null;

            List<SessionDisplay> displayList = new List<SessionDisplay>();

            // loop through sessions
            for (int i = 0; i < MainForm.SessionManager.dataList.Count; i++)
            {
                Session currentSession = MainForm.SessionManager.dataList[i];

                SessionDisplay display = new SessionDisplay();
                display.ID = currentSession.ID;
                display.Name = currentSession.Name;
                display.StartTime = currentSession.StartTime.ToString("yyyy-MM-dd HH:mm");
                display.Type = currentSession.Type.ToString();

                displayList.Add(display);
            }

            dgvSessions.DataSource = displayList;
        }

        private void dgvSessions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSessions.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                dtpStartTime.Value = DateTime.Parse(row.Cells["StartTime"].Value.ToString());
                cmbType.SelectedItem = row.Cells["Type"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //check if ID is empty
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Session ID is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Session Name is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // create new session
            Session newSession = new Session();
            newSession.ID = txtID.Text.Trim();
            newSession.Name = txtName.Text.Trim();
            newSession.StartTime = dtpStartTime.Value;
            newSession.Type = (SessionType)Enum.Parse(typeof(SessionType), cmbType.SelectedItem.ToString());

            MainForm.SessionManager.dataList.Add(newSession);

            MessageBox.Show("Session '" + newSession.Name + "' added successfully!",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadSessionsToGrid();
            ClearFields();
        }

        private void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
            dtpStartTime.Value = DateTime.Now;
            cmbType.SelectedIndex = 0;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please enter a Session ID to update.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // find the session
            Session foundSession = null;
            for (int index = 0; index < MainForm.SessionManager.dataList.Count; index++)
            {
                Session sess = MainForm.SessionManager.dataList[index];
                if (sess.ID.ToLower() == txtID.Text.Trim().ToLower())
                {
                    foundSession = sess;
                    break;
                }
            }

            if (foundSession == null)
            {
                MessageBox.Show("Session with ID '" + txtID.Text + "' not found.",
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // update the session
            foundSession.Name = txtName.Text.Trim();
            foundSession.StartTime = dtpStartTime.Value;
            foundSession.Type = (SessionType)Enum.Parse(typeof(SessionType), cmbType.SelectedItem.ToString());

            MessageBox.Show("Session '" + foundSession.ID + "' updated successfully!",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadSessionsToGrid();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please enter a Session ID to delete.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Session sessionToDelete = null;
            for (int i = 0; i < MainForm.SessionManager.dataList.Count; i++)
            {
                Session s = MainForm.SessionManager.dataList[i];
                if (s.ID.ToLower() == txtID.Text.Trim().ToLower())
                {
                    sessionToDelete = s;
                    break;
                }
            }

            if (sessionToDelete == null)
            {
                MessageBox.Show("Session with ID '" + txtID.Text + "' not found.",
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // confirm before deleting
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete session '" + sessionToDelete.Name + "'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MainForm.SessionManager.dataList.Remove(sessionToDelete);
                MessageBox.Show("Session deleted successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSessionsToGrid();
                ClearFields();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKey = txtSearchKey.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchKey))
            {
                LoadSessionsToGrid();
                return;
            }

            List<SessionDisplay> results = new List<SessionDisplay>();

            // search through all sessions
            for (int i = 0; i < MainForm.SessionManager.dataList.Count; i++)
            {
                Session session = MainForm.SessionManager.dataList[i];

                bool foundInID = session.ID.ToLower().Contains(searchKey.ToLower());
                bool foundInName = session.Name.ToLower().Contains(searchKey.ToLower());

                if (foundInID || foundInName)
                {
                    SessionDisplay display = new SessionDisplay();
                    display.ID = session.ID;
                    display.Name = session.Name;
                    display.StartTime = session.StartTime.ToString("yyyy-MM-dd HH:mm");
                    display.Type = session.Type.ToString();

                    results.Add(display);
                }
            }

            dgvSessions.DataSource = results;

            if (results.Count == 0)
            {
                MessageBox.Show("No sessions found matching '" + searchKey + "'.",
                    "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSessionsToGrid();
            txtSearchKey.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // class for displaying sessions in grid
    public class SessionDisplay
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string StartTime { get; set; }
        public string Type { get; set; }
    }
}