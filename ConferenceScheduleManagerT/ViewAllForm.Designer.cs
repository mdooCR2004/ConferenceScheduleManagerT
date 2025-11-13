namespace ConferenceScheduleManagerT
{
    partial class ViewAllForm
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
            this.lblSessions = new System.Windows.Forms.Label();
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.dgvSpeakers = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSpeakers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeakers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSessions
            // 
            this.lblSessions.AutoSize = true;
            this.lblSessions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessions.Location = new System.Drawing.Point(20, 20);
            this.lblSessions.Name = "lblSessions";
            this.lblSessions.Size = new System.Drawing.Size(103, 21);
            this.lblSessions.TabIndex = 0;
            this.lblSessions.Text = "All Sessions:";
            // 
            // dgvSessions
            // 
            this.dgvSessions.AllowUserToAddRows = false;
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessions.Location = new System.Drawing.Point(20, 50);
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.ReadOnly = true;
            this.dgvSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSessions.Size = new System.Drawing.Size(750, 200);
            this.dgvSessions.TabIndex = 1;
            // 
            // dgvSpeakers
            // 
            this.dgvSpeakers.AllowUserToAddRows = false;
            this.dgvSpeakers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpeakers.Location = new System.Drawing.Point(20, 300);
            this.dgvSpeakers.Name = "dgvSpeakers";
            this.dgvSpeakers.ReadOnly = true;
            this.dgvSpeakers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpeakers.Size = new System.Drawing.Size(750, 200);
            this.dgvSpeakers.TabIndex = 2;
            this.dgvSpeakers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSpeakers_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(20, 520);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_2);
            // 
            // lblSpeakers
            // 
            this.lblSpeakers.AutoSize = true;
            this.lblSpeakers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeakers.Location = new System.Drawing.Point(20, 270);
            this.lblSpeakers.Name = "lblSpeakers";
            this.lblSpeakers.Size = new System.Drawing.Size(107, 21);
            this.lblSpeakers.TabIndex = 4;
            this.lblSpeakers.Text = "All Speakers:";
            // 
            // ViewAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblSpeakers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvSpeakers);
            this.Controls.Add(this.dgvSessions);
            this.Controls.Add(this.lblSessions);
            this.Name = "ViewAllForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Conference Items";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeakers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSessions;
        private System.Windows.Forms.DataGridView dgvSessions;
        private System.Windows.Forms.DataGridView dgvSpeakers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSpeakers;
    }
}