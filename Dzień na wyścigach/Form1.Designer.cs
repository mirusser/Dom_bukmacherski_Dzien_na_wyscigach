namespace Dzień_na_wyścigach
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.joeradioButton1 = new System.Windows.Forms.RadioButton();
            this.bobradioButton = new System.Windows.Forms.RadioButton();
            this.alradioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.stawiabutton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.startbutton = new System.Windows.Forms.Button();
            this.zakladyLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.racetrackPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 152);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 235);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // joeradioButton1
            // 
            this.joeradioButton1.AutoSize = true;
            this.joeradioButton1.Checked = true;
            this.joeradioButton1.Location = new System.Drawing.Point(20, 69);
            this.joeradioButton1.Name = "joeradioButton1";
            this.joeradioButton1.Size = new System.Drawing.Size(98, 17);
            this.joeradioButton1.TabIndex = 4;
            this.joeradioButton1.TabStop = true;
            this.joeradioButton1.Text = "joeRadioButton";
            this.joeradioButton1.UseVisualStyleBackColor = true;
            this.joeradioButton1.CheckedChanged += new System.EventHandler(this.joeradioButton1_CheckedChanged);
            // 
            // bobradioButton
            // 
            this.bobradioButton.AutoSize = true;
            this.bobradioButton.Location = new System.Drawing.Point(20, 92);
            this.bobradioButton.Name = "bobradioButton";
            this.bobradioButton.Size = new System.Drawing.Size(102, 17);
            this.bobradioButton.TabIndex = 5;
            this.bobradioButton.Text = "bobRadioButton";
            this.bobradioButton.UseVisualStyleBackColor = true;
            this.bobradioButton.CheckedChanged += new System.EventHandler(this.bobradioButton_CheckedChanged);
            // 
            // alradioButton
            // 
            this.alradioButton.AutoSize = true;
            this.alradioButton.Location = new System.Drawing.Point(20, 112);
            this.alradioButton.Name = "alradioButton";
            this.alradioButton.Size = new System.Drawing.Size(92, 17);
            this.alradioButton.TabIndex = 6;
            this.alradioButton.Text = "alRadioButton";
            this.alradioButton.UseVisualStyleBackColor = true;
            this.alradioButton.CheckedChanged += new System.EventHandler(this.alradioButton_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimumBetLabel.Location = new System.Drawing.Point(17, 42);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(131, 13);
            this.minimumBetLabel.TabIndex = 7;
            this.minimumBetLabel.Text = "Minimalny zakład: 5zł";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(17, 165);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(24, 13);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Joe";
            // 
            // stawiabutton
            // 
            this.stawiabutton.Location = new System.Drawing.Point(96, 155);
            this.stawiabutton.Name = "stawiabutton";
            this.stawiabutton.Size = new System.Drawing.Size(75, 23);
            this.stawiabutton.TabIndex = 9;
            this.stawiabutton.Text = "Stawia";
            this.stawiabutton.UseVisualStyleBackColor = true;
            this.stawiabutton.Click += new System.EventHandler(this.stawiabutton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(198, 155);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "zł na charta numer";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(457, 160);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 12;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(634, 45);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(198, 133);
            this.startbutton.TabIndex = 13;
            this.startbutton.Text = "Start!";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // zakladyLabel
            // 
            this.zakladyLabel.AutoSize = true;
            this.zakladyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zakladyLabel.Location = new System.Drawing.Point(240, 42);
            this.zakladyLabel.Name = "zakladyLabel";
            this.zakladyLabel.Size = new System.Drawing.Size(54, 13);
            this.zakladyLabel.TabIndex = 15;
            this.zakladyLabel.Text = "Zakłady";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(243, 69);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(191, 17);
            this.joeBetLabel.TabIndex = 16;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(243, 92);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(191, 17);
            this.bobBetLabel.TabIndex = 17;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(243, 112);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(191, 17);
            this.alBetLabel.TabIndex = 18;
            this.alBetLabel.Text = "albetLabel";
            // 
            // racetrackPictureBox
            // 
            this.racetrackPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("racetrackPictureBox.Image")));
            this.racetrackPictureBox.Location = new System.Drawing.Point(0, 0);
            this.racetrackPictureBox.Name = "racetrackPictureBox";
            this.racetrackPictureBox.Size = new System.Drawing.Size(880, 280);
            this.racetrackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrackPictureBox.TabIndex = 19;
            this.racetrackPictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.minimumBetLabel);
            this.groupBox1.Controls.Add(this.startbutton);
            this.groupBox1.Controls.Add(this.alBetLabel);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.joeradioButton1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bobBetLabel);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.bobradioButton);
            this.groupBox1.Controls.Add(this.joeBetLabel);
            this.groupBox1.Controls.Add(this.alradioButton);
            this.groupBox1.Controls.Add(this.zakladyLabel);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.stawiabutton);
            this.groupBox1.Location = new System.Drawing.Point(10, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 210);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dom bukmacherski";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 504);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.racetrackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dzień na wyścigach";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RadioButton joeradioButton1;
        private System.Windows.Forms.RadioButton bobradioButton;
        private System.Windows.Forms.RadioButton alradioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button stawiabutton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label zakladyLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.PictureBox racetrackPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

