namespace ConferenceScheduleManagerT
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnManageSessions = new System.Windows.Forms.Button();
            this.btnManageSpeakers = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFooter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(66, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(475, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Conference Schedule Manager";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSubtitle.Location = new System.Drawing.Point(150, 70);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(311, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Manage Your Conference Sessions and Speakers";
            // 
            // btnManageSessions
            // 
            this.btnManageSessions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageSessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageSessions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSessions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnManageSessions.Location = new System.Drawing.Point(150, 130);
            this.btnManageSessions.Name = "btnManageSessions";
            this.btnManageSessions.Size = new System.Drawing.Size(280, 50);
            this.btnManageSessions.TabIndex = 2;
            this.btnManageSessions.Text = "Manage Sessions";
            this.btnManageSessions.UseVisualStyleBackColor = true;
            this.btnManageSessions.Click += new System.EventHandler(this.btnManageSessions_Click);
            // 
            // btnManageSpeakers
            // 
            this.btnManageSpeakers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageSpeakers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageSpeakers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSpeakers.Location = new System.Drawing.Point(150, 200);
            this.btnManageSpeakers.Name = "btnManageSpeakers";
            this.btnManageSpeakers.Size = new System.Drawing.Size(280, 50);
            this.btnManageSpeakers.TabIndex = 3;
            this.btnManageSpeakers.Text = "Manage Speakers";
            this.btnManageSpeakers.UseVisualStyleBackColor = true;
            this.btnManageSpeakers.Click += new System.EventHandler(this.btnManageSpeakers_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.Location = new System.Drawing.Point(150, 270);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(280, 50);
            this.btnViewAll.TabIndex = 4;
            this.btnViewAll.Text = "View All Items";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(150, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(280, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit Application";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFooter.Location = new System.Drawing.Point(180, 420);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(245, 30);
            this.lblFooter.TabIndex = 6;
            this.lblFooter.Text = "© 2025 - KAU Computer Science Department\r\n           Group5 (Mada,Ghala,remas)\r\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnManageSpeakers);
            this.Controls.Add(this.btnManageSessions);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conference Schedule Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnManageSessions;
        private System.Windows.Forms.Button btnManageSpeakers;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFooter;
    }
}