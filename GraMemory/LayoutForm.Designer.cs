
namespace GraMemory
{
    partial class LayoutForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayoutForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.visibilityPanel = new System.Windows.Forms.Panel();
            this.visibilitySaveBtn = new System.Windows.Forms.Button();
            this.visibilityTimeBox = new System.Windows.Forms.TextBox();
            this.visibilityTimeLabel = new System.Windows.Forms.Label();
            this.centerLine = new System.Windows.Forms.PictureBox();
            this.endGameBtn = new System.Windows.Forms.Button();
            this.stopGameBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Label();
            this.preTimer = new System.Windows.Forms.Label();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.showRankBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.visibilityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 800);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 550);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.showRankBtn);
            this.panel5.Controls.Add(this.visibilityPanel);
            this.panel5.Controls.Add(this.visibilityTimeLabel);
            this.panel5.Controls.Add(this.centerLine);
            this.panel5.Controls.Add(this.endGameBtn);
            this.panel5.Controls.Add(this.stopGameBtn);
            this.panel5.Controls.Add(this.timer);
            this.panel5.Controls.Add(this.preTimer);
            this.panel5.Controls.Add(this.settingsBtn);
            this.panel5.Controls.Add(this.newGameBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 38);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3);
            this.panel5.Size = new System.Drawing.Size(200, 474);
            this.panel5.TabIndex = 2;
            // 
            // visibilityPanel
            // 
            this.visibilityPanel.Controls.Add(this.visibilitySaveBtn);
            this.visibilityPanel.Controls.Add(this.visibilityTimeBox);
            this.visibilityPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.visibilityPanel.Location = new System.Drawing.Point(3, 245);
            this.visibilityPanel.Name = "visibilityPanel";
            this.visibilityPanel.Size = new System.Drawing.Size(194, 23);
            this.visibilityPanel.TabIndex = 10;
            this.visibilityPanel.Visible = false;
            // 
            // visibilitySaveBtn
            // 
            this.visibilitySaveBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.visibilitySaveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visibilitySaveBtn.FlatAppearance.BorderSize = 0;
            this.visibilitySaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visibilitySaveBtn.ForeColor = System.Drawing.Color.White;
            this.visibilitySaveBtn.Location = new System.Drawing.Point(153, 0);
            this.visibilitySaveBtn.Name = "visibilitySaveBtn";
            this.visibilitySaveBtn.Size = new System.Drawing.Size(41, 23);
            this.visibilitySaveBtn.TabIndex = 10;
            this.visibilitySaveBtn.Text = "Save";
            this.visibilitySaveBtn.UseVisualStyleBackColor = false;
            this.visibilitySaveBtn.Visible = false;
            this.visibilitySaveBtn.Click += new System.EventHandler(this.visibilitySaveBtn_Click);
            // 
            // visibilityTimeBox
            // 
            this.visibilityTimeBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.visibilityTimeBox.Location = new System.Drawing.Point(0, 0);
            this.visibilityTimeBox.Name = "visibilityTimeBox";
            this.visibilityTimeBox.Size = new System.Drawing.Size(153, 23);
            this.visibilityTimeBox.TabIndex = 9;
            this.visibilityTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.visibilityTimeBox.Visible = false;
            // 
            // visibilityTimeLabel
            // 
            this.visibilityTimeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.visibilityTimeLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.visibilityTimeLabel.ForeColor = System.Drawing.Color.White;
            this.visibilityTimeLabel.Location = new System.Drawing.Point(3, 212);
            this.visibilityTimeLabel.Name = "visibilityTimeLabel";
            this.visibilityTimeLabel.Size = new System.Drawing.Size(194, 33);
            this.visibilityTimeLabel.TabIndex = 8;
            this.visibilityTimeLabel.Text = "Visibility time for a flipped pair";
            this.visibilityTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.visibilityTimeLabel.Visible = false;
            // 
            // centerLine
            // 
            this.centerLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.centerLine.Image = ((System.Drawing.Image)(resources.GetObject("centerLine.Image")));
            this.centerLine.Location = new System.Drawing.Point(3, 201);
            this.centerLine.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.centerLine.Name = "centerLine";
            this.centerLine.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.centerLine.Size = new System.Drawing.Size(194, 11);
            this.centerLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.centerLine.TabIndex = 7;
            this.centerLine.TabStop = false;
            this.centerLine.Visible = false;
            // 
            // endGameBtn
            // 
            this.endGameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.endGameBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.endGameBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.endGameBtn.FlatAppearance.BorderSize = 0;
            this.endGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endGameBtn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endGameBtn.ForeColor = System.Drawing.Color.LightCoral;
            this.endGameBtn.Location = new System.Drawing.Point(3, 168);
            this.endGameBtn.Margin = new System.Windows.Forms.Padding(5);
            this.endGameBtn.Name = "endGameBtn";
            this.endGameBtn.Size = new System.Drawing.Size(194, 33);
            this.endGameBtn.TabIndex = 6;
            this.endGameBtn.Text = "End Game";
            this.endGameBtn.UseVisualStyleBackColor = false;
            this.endGameBtn.Visible = false;
            this.endGameBtn.Click += new System.EventHandler(this.endGameBtn_Click);
            // 
            // stopGameBtn
            // 
            this.stopGameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.stopGameBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.stopGameBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.stopGameBtn.FlatAppearance.BorderSize = 0;
            this.stopGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopGameBtn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stopGameBtn.ForeColor = System.Drawing.Color.Silver;
            this.stopGameBtn.Location = new System.Drawing.Point(3, 135);
            this.stopGameBtn.Margin = new System.Windows.Forms.Padding(5);
            this.stopGameBtn.Name = "stopGameBtn";
            this.stopGameBtn.Size = new System.Drawing.Size(194, 33);
            this.stopGameBtn.TabIndex = 5;
            this.stopGameBtn.Text = "Stop Game";
            this.stopGameBtn.UseVisualStyleBackColor = false;
            this.stopGameBtn.Visible = false;
            this.stopGameBtn.Click += new System.EventHandler(this.stopGameBtn_Click);
            // 
            // timer
            // 
            this.timer.Dock = System.Windows.Forms.DockStyle.Top;
            this.timer.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timer.ForeColor = System.Drawing.Color.White;
            this.timer.Location = new System.Drawing.Point(3, 102);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(194, 33);
            this.timer.TabIndex = 4;
            this.timer.Text = "Time: 00:00";
            this.timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timer.Visible = false;
            // 
            // preTimer
            // 
            this.preTimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.preTimer.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.preTimer.ForeColor = System.Drawing.Color.White;
            this.preTimer.Location = new System.Drawing.Point(3, 69);
            this.preTimer.Name = "preTimer";
            this.preTimer.Size = new System.Drawing.Size(194, 33);
            this.preTimer.TabIndex = 11;
            this.preTimer.Text = "Time to start: 0";
            this.preTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.preTimer.Visible = false;
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.settingsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.Location = new System.Drawing.Point(3, 36);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(5);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(194, 33);
            this.settingsBtn.TabIndex = 1;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // newGameBtn
            // 
            this.newGameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.newGameBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.newGameBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.newGameBtn.FlatAppearance.BorderSize = 0;
            this.newGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGameBtn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newGameBtn.ForeColor = System.Drawing.Color.White;
            this.newGameBtn.Location = new System.Drawing.Point(3, 3);
            this.newGameBtn.Margin = new System.Windows.Forms.Padding(5);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(194, 33);
            this.newGameBtn.TabIndex = 0;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = false;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 512);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.pictureBox3.Size = new System.Drawing.Size(200, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.pictureBox2.Size = new System.Drawing.Size(200, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.username);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 250);
            this.panel3.TabIndex = 0;
            // 
            // username
            // 
            this.username.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.username.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(0, 203);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(200, 47);
            this.username.TabIndex = 2;
            this.username.Text = "User Name";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::GraMemory.Properties.Resources.userphoto;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(20);
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 800);
            this.panel2.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(210, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(800, 800);
            this.panelChildForm.TabIndex = 2;
            // 
            // showRankBtn
            // 
            this.showRankBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.showRankBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.showRankBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.showRankBtn.FlatAppearance.BorderSize = 0;
            this.showRankBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showRankBtn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showRankBtn.ForeColor = System.Drawing.Color.White;
            this.showRankBtn.Location = new System.Drawing.Point(3, 438);
            this.showRankBtn.Margin = new System.Windows.Forms.Padding(5);
            this.showRankBtn.Name = "showRankBtn";
            this.showRankBtn.Size = new System.Drawing.Size(194, 33);
            this.showRankBtn.TabIndex = 12;
            this.showRankBtn.Text = "Show Rank";
            this.showRankBtn.UseVisualStyleBackColor = false;
            this.showRankBtn.Click += new System.EventHandler(this.showRankBtn_Click);
            // 
            // LayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 800);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LayoutForm";
            this.Text = "Menu startowe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.visibilityPanel.ResumeLayout(false);
            this.visibilityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.PictureBox centerLine;
        private System.Windows.Forms.Button endGameBtn;
        private System.Windows.Forms.Button stopGameBtn;
        private System.Windows.Forms.Label visibilityTimeLabel;
        private System.Windows.Forms.TextBox visibilityTimeBox;
        private System.Windows.Forms.Panel visibilityPanel;
        private System.Windows.Forms.Button visibilitySaveBtn;
        private System.Windows.Forms.Label preTimer;
        private System.Windows.Forms.Button showRankBtn;
    }
}

