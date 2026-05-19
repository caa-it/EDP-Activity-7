namespace Sample
{
    partial class Form17
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
            Button btnAdd;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form17));
            panel4 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            txtResultID = new TextBox();
            cmbPosition = new ComboBox();
            cmbAthlete = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            panel6 = new Panel();
            btnClear = new Button();
            panel10 = new Panel();
            pictureBox19 = new PictureBox();
            pictureBox18 = new PictureBox();
            pictureBox5 = new PictureBox();
            button8 = new Button();
            pictureBox13 = new PictureBox();
            button5 = new Button();
            pictureBox14 = new PictureBox();
            pictureBox15 = new PictureBox();
            button6 = new Button();
            pictureBox16 = new PictureBox();
            button7 = new Button();
            pictureBox17 = new PictureBox();
            button10 = new Button();
            button9 = new Button();
            button12 = new Button();
            panel3 = new Panel();
            label2 = new Label();
            button4 = new Button();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            label1 = new Label();
            dgvResults = new DataGridView();
            btnAdd = new Button();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Peru;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(588, 16);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(93, 27);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkOrange;
            panel4.Controls.Add(label7);
            panel4.Location = new Point(214, 62);
            panel4.Name = "panel4";
            panel4.Size = new Size(801, 39);
            panel4.TabIndex = 94;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Inter", 9F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 11);
            label7.Name = "label7";
            label7.Size = new Size(177, 19);
            label7.TabIndex = 0;
            label7.Text = "RESULT INFORMATION";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtResultID);
            panel2.Controls.Add(cmbPosition);
            panel2.Controls.Add(cmbAthlete);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(214, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 134);
            panel2.TabIndex = 99;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(40, 55);
            label8.Name = "label8";
            label8.Size = new Size(73, 16);
            label8.TabIndex = 51;
            label8.Text = "RESULT ID";
            // 
            // txtResultID
            // 
            txtResultID.Location = new Point(37, 75);
            txtResultID.Name = "txtResultID";
            txtResultID.Size = new Size(207, 27);
            txtResultID.TabIndex = 50;
            txtResultID.TextChanged += txtResultID_TextChanged;
            // 
            // cmbPosition
            // 
            cmbPosition.ForeColor = SystemColors.InfoText;
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Items.AddRange(new object[] { "Medal Results", "Athlete" });
            cmbPosition.Location = new Point(556, 73);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(210, 28);
            cmbPosition.TabIndex = 46;
            // 
            // cmbAthlete
            // 
            cmbAthlete.ForeColor = SystemColors.InfoText;
            cmbAthlete.FormattingEnabled = true;
            cmbAthlete.Items.AddRange(new object[] { "Medal Results", "Athlete" });
            cmbAthlete.Location = new Point(295, 73);
            cmbAthlete.Name = "cmbAthlete";
            cmbAthlete.Size = new Size(210, 28);
            cmbAthlete.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(556, 54);
            label6.Name = "label6";
            label6.Size = new Size(71, 16);
            label6.TabIndex = 43;
            label6.Text = "POSITION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(295, 54);
            label3.Name = "label3";
            label3.Size = new Size(67, 16);
            label3.TabIndex = 40;
            label3.Text = "ATHLETE";
            // 
            // panel6
            // 
            panel6.BackColor = Color.AliceBlue;
            panel6.Controls.Add(btnAdd);
            panel6.Controls.Add(btnClear);
            panel6.Location = new Point(215, 207);
            panel6.Name = "panel6";
            panel6.Size = new Size(800, 58);
            panel6.TabIndex = 98;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightBlue;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Inter", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(687, 16);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(93, 27);
            btnClear.TabIndex = 17;
            btnClear.Text = "Cancel";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.SteelBlue;
            panel10.Controls.Add(pictureBox19);
            panel10.Controls.Add(pictureBox18);
            panel10.Controls.Add(pictureBox5);
            panel10.Controls.Add(button8);
            panel10.Controls.Add(pictureBox13);
            panel10.Controls.Add(button5);
            panel10.Controls.Add(pictureBox14);
            panel10.Controls.Add(pictureBox15);
            panel10.Controls.Add(button6);
            panel10.Controls.Add(pictureBox16);
            panel10.Controls.Add(button7);
            panel10.Controls.Add(pictureBox17);
            panel10.Controls.Add(button10);
            panel10.Controls.Add(button9);
            panel10.Controls.Add(button12);
            panel10.Location = new Point(1, -1);
            panel10.Name = "panel10";
            panel10.Size = new Size(171, 550);
            panel10.TabIndex = 97;
            // 
            // pictureBox19
            // 
            pictureBox19.Image = (Image)resources.GetObject("pictureBox19.Image");
            pictureBox19.Location = new Point(2, 195);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(32, 29);
            pictureBox19.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox19.TabIndex = 21;
            pictureBox19.TabStop = false;
            // 
            // pictureBox18
            // 
            pictureBox18.Image = (Image)resources.GetObject("pictureBox18.Image");
            pictureBox18.Location = new Point(4, 147);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(32, 29);
            pictureBox18.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox18.TabIndex = 20;
            pictureBox18.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(4, 102);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 29);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // button8
            // 
            button8.BackColor = Color.SteelBlue;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Inter", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(-4, 102);
            button8.Name = "button8";
            button8.Size = new Size(201, 29);
            button8.TabIndex = 16;
            button8.Text = "Manage Athletes";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(2, 52);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(32, 29);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 14;
            pictureBox13.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.SteelBlue;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Inter", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(-4, 52);
            button5.Name = "button5";
            button5.Size = new Size(139, 29);
            button5.TabIndex = 15;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox14
            // 
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(137, 15);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(28, 26);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 12;
            pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            pictureBox15.Image = (Image)resources.GetObject("pictureBox15.Image");
            pictureBox15.Location = new Point(10, 497);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(36, 29);
            pictureBox15.TabIndex = 11;
            pictureBox15.TabStop = false;
            // 
            // button6
            // 
            button6.BackColor = Color.SteelBlue;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Inter", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(-1, 497);
            button6.Name = "button6";
            button6.Size = new Size(171, 29);
            button6.TabIndex = 10;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // pictureBox16
            // 
            pictureBox16.Image = (Image)resources.GetObject("pictureBox16.Image");
            pictureBox16.Location = new Point(0, 233);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(32, 29);
            pictureBox16.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox16.TabIndex = 9;
            pictureBox16.TabStop = false;
            // 
            // button7
            // 
            button7.BackColor = Color.SteelBlue;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Inter", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(-20, 233);
            button7.Name = "button7";
            button7.Size = new Size(181, 29);
            button7.TabIndex = 8;
            button7.Text = "Reports";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // pictureBox17
            // 
            pictureBox17.Image = (Image)resources.GetObject("pictureBox17.Image");
            pictureBox17.Location = new Point(3, 276);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(36, 29);
            pictureBox17.TabIndex = 5;
            pictureBox17.TabStop = false;
            // 
            // button10
            // 
            button10.BackColor = Color.SteelBlue;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Inter", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ControlLightLight;
            button10.Location = new Point(-4, 195);
            button10.Name = "button10";
            button10.Size = new Size(201, 29);
            button10.TabIndex = 23;
            button10.Text = "Manage Results";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.SteelBlue;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Inter", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(-4, 147);
            button9.Name = "button9";
            button9.Size = new Size(201, 29);
            button9.TabIndex = 22;
            button9.Text = "Manage Events";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.SteelBlue;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Inter", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.ForeColor = SystemColors.ControlLightLight;
            button12.Location = new Point(-21, 276);
            button12.Name = "button12";
            button12.Size = new Size(181, 29);
            button12.TabIndex = 24;
            button12.Text = "About";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(172, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(871, 56);
            panel3.TabIndex = 96;
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
            pictureBox7.Location = new Point(821, 17);
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
            label1.Location = new Point(715, 22);
            label1.Name = "label1";
            label1.Size = new Size(93, 16);
            label1.TabIndex = 0;
            label1.Text = "April 19, 2026";
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.BackgroundColor = Color.Linen;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(212, 275);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersWidth = 51;
            dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResults.Size = new Size(802, 255);
            dgvResults.TabIndex = 95;
            dgvResults.CellContentClick += dgvResults_CellContentClick;
            // 
            // Form17
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 538);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel6);
            Controls.Add(panel10);
            Controls.Add(panel3);
            Controls.Add(dgvResults);
            Name = "Form17";
            Text = "Form17";
            Load += Form17_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Label label7;
        private Panel panel2;
        private Label label8;
        private TextBox txtResultID;
        private ComboBox cmbPosition;
        private ComboBox cmbAthlete;
        private Label label6;
        private Label label3;
        private Panel panel6;
        private Button btnClear;
        private Panel panel10;
        private PictureBox pictureBox19;
        private PictureBox pictureBox18;
        private PictureBox pictureBox5;
        private Button button8;
        private PictureBox pictureBox13;
        private Button button5;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private Button button6;
        private PictureBox pictureBox16;
        private Button button7;
        private PictureBox pictureBox17;
        private Button button10;
        private Button button9;
        private Button button12;
        private Panel panel3;
        private Label label2;
        private Button button4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Label label1;
        private DataGridView dgvResults;
        private Label label4;
    }
}