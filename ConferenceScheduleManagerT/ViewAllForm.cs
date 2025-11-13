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
    public partial class ViewAllForm : Form
    {
        public ViewAllForm()
        {
            InitializeComponent();
            LoadAllData();
        }

        private void LoadAllData()
        {
            // Load Sessions
            dgvSessions.DataSource = null;
            dgvSessions.DataSource = MainForm.SessionManager.dataList;

            // Load Speakers
            dgvSpeakers.DataSource = null;
            dgvSpeakers.DataSource = MainForm.SpeakerManager.dataList;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewAllForm_Load(object sender, EventArgs e)
        {
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSpeakers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    
