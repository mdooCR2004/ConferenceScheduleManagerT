namespace ConferenceScheduleManagerT
{
    partial class SpeakerManagmentForm
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
            this.panelInput = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBiography = new System.Windows.Forms.TextBox();
            this.lbBiography = new System.Windows.Forms.Label();
            this.txtAffiliation = new System.Windows.Forms.TextBox();
            this.ldAffiliation = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPanelTitle = new System.Windows.Forms.Label();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.dgvSpeakers = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblDisplayTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelInput.SuspendLayout();
            this.panelDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeakers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInput.Controls.Add(this.btnClear);
            this.panelInput.Controls.Add(this.btnDelete);
            this.panelInput.Controls.Add(this.btnEdit);
            this.panelInput.Controls.Add(this.btnAdd);
            this.panelInput.Controls.Add(this.txtBiography);
            this.panelInput.Controls.Add(this.lbBiography);
            this.panelInput.Controls.Add(this.txtAffiliation);
            this.panelInput.Controls.Add(this.ldAffiliation);
            this.panelInput.Controls.Add(this.txtName);
            this.panelInput.Controls.Add(this.lblName);
            this.panelInput.Controls.Add(this.txtID);
            this.panelInput.Controls.Add(this.lblID);
            this.panelInput.Controls.Add(this.lblPanelTitle);
            this.panelInput.Location = new System.Drawing.Point(32, 31);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(350, 559);
            this.panelInput.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Honeydew;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(20, 499);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(310, 40);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MistyRose;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(20, 453);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(310, 40);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Speaker";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Info;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(20, 407);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(310, 40);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Update Speaker";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(20, 361);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(310, 40);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Speaker";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBiography
            // 
            this.txtBiography.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBiography.Location = new System.Drawing.Point(20, 295);
            this.txtBiography.Multiline = true;
            this.txtBiography.Name = "txtBiography";
            this.txtBiography.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBiography.Size = new System.Drawing.Size(310, 60);
            this.txtBiography.TabIndex = 8;
            // 
            // lbBiography
            // 
            this.lbBiography.AutoSize = true;
            this.lbBiography.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBiography.Location = new System.Drawing.Point(23, 266);
            this.lbBiography.Name = "lbBiography";
            this.lbBiography.Size = new System.Drawing.Size(75, 17);
            this.lbBiography.TabIndex = 7;
            this.lbBiography.Text = "Biography:";
            // 
            // txtAffiliation
            // 
            this.txtAffiliation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAffiliation.Location = new System.Drawing.Point(20, 220);
            this.txtAffiliation.Name = "txtAffiliation";
            this.txtAffiliation.Size = new System.Drawing.Size(310, 25);
            this.txtAffiliation.TabIndex = 6;
            // 
            // ldAffiliation
            // 
            this.ldAffiliation.AutoSize = true;
            this.ldAffiliation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldAffiliation.Location = new System.Drawing.Point(23, 200);
            this.ldAffiliation.Name = "ldAffiliation";
            this.ldAffiliation.Size = new System.Drawing.Size(75, 17);
            this.ldAffiliation.TabIndex = 5;
            this.ldAffiliation.Text = "Affiliation:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(20, 150);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(310, 25);
            this.txtName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(20, 125);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(109, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Speaker\'s Name:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(20, 85);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(310, 25);
            this.txtID.TabIndex = 2;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(20, 60);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(87, 17);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Speaker\'s ID:";
            // 
            // lblPanelTitle
            // 
            this.lblPanelTitle.AutoSize = true;
            this.lblPanelTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPanelTitle.Location = new System.Drawing.Point(10, 10);
            this.lblPanelTitle.Name = "lblPanelTitle";
            this.lblPanelTitle.Size = new System.Drawing.Size(156, 25);
            this.lblPanelTitle.TabIndex = 0;
            this.lblPanelTitle.Text = "Speakers Details\n";
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDisplay.Controls.Add(this.dgvSpeakers);
            this.panelDisplay.Controls.Add(this.btnRefresh);
            this.panelDisplay.Controls.Add(this.btnSearch);
            this.panelDisplay.Controls.Add(this.txtSearchKey);
            this.panelDisplay.Controls.Add(this.lblSearch);
            this.panelDisplay.Controls.Add(this.lblDisplayTitle);
            this.panelDisplay.Location = new System.Drawing.Point(400, 70);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(570, 520);
            this.panelDisplay.TabIndex = 1;
            // 
            // dgvSpeakers
            // 
            this.dgvSpeakers.AllowUserToAddRows = false;
            this.dgvSpeakers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSpeakers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSpeakers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSpeakers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpeakers.Location = new System.Drawing.Point(10, 115);
            this.dgvSpeakers.Name = "dgvSpeakers";
            this.dgvSpeakers.ReadOnly = true;
            this.dgvSpeakers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpeakers.Size = new System.Drawing.Size(545, 390);
            this.dgvSpeakers.TabIndex = 5;
            this.dgvSpeakers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSpeakers_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(380, 73);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(270, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Location = new System.Drawing.Point(10, 75);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(250, 20);
            this.txtSearchKey.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(10, 50);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(146, 17);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search by ID or Name:";
            // 
            // lblDisplayTitle
            // 
            this.lblDisplayTitle.AutoSize = true;
            this.lblDisplayTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTitle.Location = new System.Drawing.Point(10, 10);
            this.lblDisplayTitle.Name = "lblDisplayTitle";
            this.lblDisplayTitle.Size = new System.Drawing.Size(120, 25);
            this.lblDisplayTitle.TabIndex = 0;
            this.lblDisplayTitle.Text = "All Speakers";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Navy;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(30, 610);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 40);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "← Back to Main Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SpeakerManagmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.panelInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SpeakerManagmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speaker managment";
            this.Load += new System.EventHandler(this.SpeakerManagmentForm_Load);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelDisplay.ResumeLayout(false);
            this.panelDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeakers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPanelTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbBiography;
        private System.Windows.Forms.TextBox txtAffiliation;
        private System.Windows.Forms.Label ldAffiliation;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBiography;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblDisplayTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.DataGridView dgvSpeakers;
        private System.Windows.Forms.Button btnBack;
    }
}