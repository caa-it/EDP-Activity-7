namespace Sample
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            btnSave = new Button();
            btnCancel = new Button();
            label7 = new Label();
            label6 = new Label();
            cboSecurityQ = new ComboBox();
            cboRole = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtSecurityA = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            panel3 = new Panel();
            label9 = new Label();
            button4 = new Button();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            label10 = new Label();
            panel2 = new Panel();
            panel6 = new Panel();
            panel4 = new Panel();
            label16 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Peru;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(418, 13);
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
            btnCancel.Location = new Point(526, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 27);
            btnCancel.TabIndex = 81;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(44, 279);
            label7.Name = "label7";
            label7.Size = new Size(76, 16);
            label7.TabIndex = 80;
            label7.Text = "QUESTION";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(44, 214);
            label6.Name = "label6";
            label6.Size = new Size(41, 16);
            label6.TabIndex = 79;
            label6.Text = "ROLE";
            // 
            // cboSecurityQ
            // 
            cboSecurityQ.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSecurityQ.FormattingEnabled = true;
            cboSecurityQ.Location = new Point(44, 298);
            cboSecurityQ.Name = "cboSecurityQ";
            cboSecurityQ.Size = new Size(175, 28);
            cboSecurityQ.TabIndex = 78;
            // 
            // cboRole
            // 
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(44, 237);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(174, 28);
            cboRole.TabIndex = 77;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(370, 144);
            label5.Name = "label5";
            label5.Size = new Size(82, 16);
            label5.TabIndex = 76;
            label5.Text = "PASSWORD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(44, 144);
            label4.Name = "label4";
            label4.Size = new Size(48, 16);
            label4.TabIndex = 74;
            label4.Text = "EMAIL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(370, 279);
            label2.Name = "label2";
            label2.Size = new Size(66, 16);
            label2.TabIndex = 75;
            label2.Text = "ANSWER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(367, 71);
            label1.Name = "label1";
            label1.Size = new Size(85, 16);
            label1.TabIndex = 73;
            label1.Text = "LAST NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(44, 71);
            label3.Name = "label3";
            label3.Size = new Size(89, 16);
            label3.TabIndex = 72;
            label3.Text = "FIRST NAME";
            // 
            // txtSecurityA
            // 
            txtSecurityA.Location = new Point(370, 298);
            txtSecurityA.Name = "txtSecurityA";
            txtSecurityA.Size = new Size(175, 27);
            txtSecurityA.TabIndex = 71;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(370, 165);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(175, 27);
            txtPassword.TabIndex = 70;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(44, 165);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(174, 27);
            txtEmail.TabIndex = 69;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(367, 94);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(178, 27);
            txtLastName.TabIndex = 68;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(44, 96);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(174, 27);
            txtFirstName.TabIndex = 67;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(0, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1048, 56);
            panel3.TabIndex = 83;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Quicksand", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(74, 30);
            label9.Name = "label9";
            label9.Size = new Size(171, 19);
            label9.TabIndex = 1;
            label9.Text = "Sports Mangement System";
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.DarkOrange;
            button4.Location = new Point(68, 7);
            button4.Name = "button4";
            button4.Size = new Size(81, 33);
            button4.TabIndex = 13;
            button4.Text = "PLAYON";
            button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(12, 7);
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
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Inter", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(892, 19);
            label10.Name = "label10";
            label10.Size = new Size(93, 16);
            label10.TabIndex = 0;
            label10.Text = "April 19, 2026";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtSecurityA);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtFirstName);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(cboSecurityQ);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cboRole);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtEmail);
            panel2.Location = new Point(189, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(650, 408);
            panel2.TabIndex = 85;
            // 
            // panel6
            // 
            panel6.BackColor = Color.AliceBlue;
            panel6.Controls.Add(btnSave);
            panel6.Controls.Add(btnCancel);
            panel6.Location = new Point(189, 443);
            panel6.Name = "panel6";
            panel6.Size = new Size(647, 53);
            panel6.TabIndex = 40;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Navy;
            panel4.Controls.Add(label16);
            panel4.Location = new Point(2, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(815, 53);
            panel4.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Inter", 9F, FontStyle.Bold);
            label16.ForeColor = Color.White;
            label16.Location = new Point(10, 20);
            label16.Name = "label16";
            label16.Size = new Size(121, 19);
            label16.TabIndex = 0;
            label16.Text = "ADD ACCOUNT";
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1039, 543);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Form11";
            Text = "Form11";
            Load += Form11_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Label label7;
        private Label label6;
        private ComboBox cboSecurityQ;
        private ComboBox cboRole;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtSecurityA;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Panel panel3;
        private Label label9;
        private Button button4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Label label10;
        private Panel panel2;
        private Panel panel4;
        private Label label16;
        private Panel panel6;
    }
}