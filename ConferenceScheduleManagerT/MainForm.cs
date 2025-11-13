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
    public partial class MainForm : Form
    {
        public static ConferenceManager<Session> SessionManager = new ConferenceManager<Session>();
        public static ConferenceManager<Speaker> SpeakerManager = new ConferenceManager<Speaker>();
        public MainForm()
        {
            InitializeComponent();
            InitializeSampleData();
        }
        private void InitializeSampleData()
        {
            // sample for session, speaker
            SessionManager.AddInitialData(new Session
            {
                ID = "S001",
                Name = "Introduction to C# Programming",
                StartTime = new DateTime(2025, 10, 23, 9, 0, 0),
                Type = SessionType.Keynote
            });
            SpeakerManager.AddInitialData(new Speaker
            {
                ID = "P001",
                Name = "Ghala Alshahrani",
                Affiliation = "King Abdulaziz University",
                Biography = "Lead Developer & Software Engineer"
            });
        }
        private void btnManageSessions_Click(object sender, EventArgs e)
        {
            SessionManagementForm sessionForm = new SessionManagementForm();
            sessionForm.ShowDialog();
        }
        private void btnManageSpeakers_Click(object sender, EventArgs e)
        {
            SpeakerManagmentForm speakerForm = new SpeakerManagmentForm();
            speakerForm.ShowDialog();
        }
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            ViewAllForm viewForm = new ViewAllForm();
            viewForm.ShowDialog();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show( "Are you sure you want to exit?",  "Exit Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
