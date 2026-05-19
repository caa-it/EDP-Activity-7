namespace Sample
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            dgvAccounts = new DataGridView();
            colUserID = new DataGridViewTextBoxColumn();
            colFirstName = new DataGridViewTextBoxColumn();
            colLastName = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            pictureBox12 = new PictureBox();
            button11 = new Button();
            panel7 = new Panel();
            label7 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            button4 = new Button();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            label1 = new Label();
            panel6 = new Panel();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            panel2 = new Panel();
            label11 = new Label();
            txtUserID = new TextBox();
            panel4 = new Panel();
            label16 = new Label();
            label3 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label6 = new Label();
            label8 = new Label();
            cmbRole = new ComboBox();
            txtPassword = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAccounts
            // 
            dgvAccounts.AllowUserToAddRows = false;
            dgvAccounts.BackgroundColor = Color.Linen;
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccounts.Columns.AddRange(new DataGridViewColumn[] { colUserID, colFirstName, colLastName, colEmail, colRole, colStatus });
            dgvAccounts.Location = new Point(128, 343);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.ReadOnly = true;
            dgvAccounts.RowHeadersWidth = 51;
            dgvAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAccounts.Size = new Size(802, 189);
            dgvAccounts.TabIndex = 0;
            dgvAccounts.CellContentClick += dgvAccounts_CellContentClick;
            // 
            // colUserID
            // 
            colUserID.DataPropertyName = "UserID";
            colUserID.HeaderText = "User ID";
            colUserID.MinimumWidth = 6;
            colUserID.Name = "colUserID";
            colUserID.ReadOnly = true;
            colUserID.Width = 125;
            // 
            // colFirstName
            // 
            colFirstName.DataPropertyName = "FirstName";
            colFirstName.HeaderText = "First Name";
            colFirstName.MinimumWidth = 6;
            colFirstName.Name = "colFirstName";
            colFirstName.ReadOnly = true;
            colFirstName.Width = 125;
            // 
            // colLastName
            // 
            colLastName.DataPropertyName = "LastName";
            colLastName.HeaderText = "Last Name";
            colLastName.MinimumWidth = 6;
            colLastName.Name = "colLastName";
            colLastName.ReadOnly = true;
            colLastName.Width = 125;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 125;
            // 
            // colRole
            // 
            colRole.DataPropertyName = "Role";
            colRole.HeaderText = "Role";
            colRole.MinimumWidth = 6;
            colRole.Name = "colRole";
            colRole.ReadOnly = true;
            colRole.Width = 125;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 125;
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.Orange;
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(727, 16);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(28, 25);
            pictureBox12.TabIndex = 18;
            pictureBox12.TabStop = false;
            // 
            // button11
            // 
            button11.BackColor = Color.Orange;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ForeColor = SystemColors.ControlLightLight;
            button11.Location = new Point(724, 15);
            button11.Name = "button11";
            button11.Size = new Size(158, 27);
            button11.TabIndex = 17;
            button11.Text = "Add Account";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Navy;
            panel7.Controls.Add(label7);
            panel7.Controls.Add(pictureBox12);
            panel7.Controls.Add(button11);
            panel7.Location = new Point(0, 54);
            panel7.Name = "panel7";
            panel7.Size = new Size(1045, 56);
            panel7.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Snow;
            label7.Location = new Point(12, 15);
            label7.Name = "label7";
            label7.Size = new Size(166, 21);
            label7.TabIndex = 19;
            label7.Text = "USER ACCOUNTS";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1048, 56);
            panel3.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Quicksand", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(61, 28);
            label2.Name = "label2";
            label2.Size = new Size(171, 19);
            label2.TabIndex = 1;
            label2.Text = "Sports Mangement System";
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.DarkOrange;
            button4.Location = new Point(55, 5);
            button4.Name = "button4";
            button4.Size = new Size(81, 33);
            button4.TabIndex = 13;
            button4.Text = "PLAYON";
            button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(4, 7);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(60, 44);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(998, 14);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(24, 24);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 15;
            pictureBox7.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Inter", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(892, 19);
            label1.Name = "label1";
            label1.Size = new Size(93, 16);
            label1.TabIndex = 0;
            label1.Text = "April 19, 2026";
            // 
            // panel6
            // 
            panel6.BackColor = Color.AliceBlue;
            panel6.Controls.Add(btnDelete);
            panel6.Controls.Add(btnUpdate);
            panel6.Controls.Add(btnSave);
            panel6.Controls.Add(btnCancel);
            panel6.Location = new Point(3, 174);
            panel6.Name = "panel6";
            panel6.Size = new Size(1029, 47);
            panel6.TabIndex = 86;
            panel6.Paint += panel6_Paint;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(593, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 27);
            btnDelete.TabIndex = 84;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.CornflowerBlue;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(494, 10);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(93, 27);
            btnUpdate.TabIndex = 83;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Peru;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(395, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(93, 27);
            btnSave.TabIndex = 82;
            btnSave.Text = "Add";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightBlue;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(692, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 27);
            btnCancel.TabIndex = 81;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtUserID);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtFirstName);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(cmbRole);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtEmail);
            panel2.Location = new Point(128, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(802, 221);
            panel2.TabIndex = 87;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(42, 49);
            label11.Name = "label11";
            label11.Size = new Size(58, 16);
            label11.TabIndex = 88;
            label11.Text = "USER ID";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(42, 74);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(174, 27);
            txtUserID.TabIndex = 87;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Navy;
            panel4.Controls.Add(label16);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1020, 30);
            panel4.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Inter", 9F, FontStyle.Bold);
            label16.ForeColor = Color.White;
            label16.Location = new Point(9, 8);
            label16.Name = "label16";
            label16.Size = new Size(121, 19);
            label16.TabIndex = 0;
            label16.Text = "ADD ACCOUNT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(278, 51);
            label3.Name = "label3";
            label3.Size = new Size(89, 16);
            label3.TabIndex = 72;
            label3.Text = "FIRST NAME";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(278, 76);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(174, 27);
            txtFirstName.TabIndex = 67;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(543, 76);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(178, 27);
            txtLastName.TabIndex = 68;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(543, 53);
            label6.Name = "label6";
            label6.Size = new Size(85, 16);
            label6.TabIndex = 73;
            label6.Text = "LAST NAME";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(41, 110);
            label8.Name = "label8";
            label8.Size = new Size(41, 16);
            label8.TabIndex = 79;
            label8.Text = "ROLE";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(41, 133);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(174, 28);
            cmbRole.TabIndex = 77;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(543, 136);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(175, 27);
            txtPassword.TabIndex = 70;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(278, 114);
            label9.Name = "label9";
            label9.Size = new Size(48, 16);
            label9.TabIndex = 74;
            label9.Text = "EMAIL";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(543, 115);
            label10.Name = "label10";
            label10.Size = new Size(82, 16);
            label10.TabIndex = 76;
            label10.Text = "PASSWORD";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(278, 135);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(174, 27);
            txtEmail.TabIndex = 69;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1039, 544);
            Controls.Add(panel2);
            Controls.Add(panel7);
            Controls.Add(panel3);
            Controls.Add(dgvAccounts);
            Name = "Form10";
            Text = "Form10";
            Load += Form10_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAccounts;
        private PictureBox pictureBox12;
        private Button button11;
        private Panel panel7;
        private Panel panel3;
        private Label label2;
        private Button button4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Label label1;
        private Label label7;
        private Panel panel6;
        private Button btnSave;
        private Button btnCancel;
        private Panel panel2;
        private Panel panel4;
        private Label label16;
        private Label label3;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label6;
        private Label label8;
        private ComboBox cmbRole;
        private TextBox txtPassword;
        private Label label9;
        private Label label10;
        private TextBox txtEmail;
        private Button btnDelete;
        private Button btnUpdate;
        private Label label11;
        private TextBox txtUserID;
        private DataGridViewTextBoxColumn colUserID;
        private DataGridViewTextBoxColumn colFirstName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colRole;
        private DataGridViewTextBoxColumn colStatus;
    }
}