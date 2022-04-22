
namespace GraMemory
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveSettingsBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Po = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.boardSizeSelect = new System.Windows.Forms.ComboBox();
            this.initialvisibilityLabel = new System.Windows.Forms.Label();
            this.initialVisibilityTimeText = new System.Windows.Forms.TextBox();
            this.flippedPairLabel = new System.Windows.Forms.Label();
            this.visibilityTimeFlippedPairText = new System.Windows.Forms.TextBox();
            this.allowMultipleCardsToBeFlippedCheckbox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 687);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.saveSettingsBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 11;
            // 
            // saveSettingsBtn
            // 
            this.saveSettingsBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.saveSettingsBtn.FlatAppearance.BorderSize = 0;
            this.saveSettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettingsBtn.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveSettingsBtn.ForeColor = System.Drawing.Color.White;
            this.saveSettingsBtn.Location = new System.Drawing.Point(14, 51);
            this.saveSettingsBtn.Name = "saveSettingsBtn";
            this.saveSettingsBtn.Size = new System.Drawing.Size(760, 50);
            this.saveSettingsBtn.TabIndex = 8;
            this.saveSettingsBtn.Text = "Save";
            this.saveSettingsBtn.UseVisualStyleBackColor = false;
            this.saveSettingsBtn.Click += new System.EventHandler(this.saveSettingsBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Po, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.levelLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.boardSizeSelect, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.initialvisibilityLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.initialVisibilityTimeText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flippedPairLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.visibilityTimeFlippedPairText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.allowMultipleCardsToBeFlippedCheckbox, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 200);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // Po
            // 
            this.Po.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Po.AutoSize = true;
            this.Po.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Po.Location = new System.Drawing.Point(57, 166);
            this.Po.Name = "Po";
            this.Po.Size = new System.Drawing.Size(285, 18);
            this.Po.TabIndex = 8;
            this.Po.Text = "Allow multiple cards to be flipped";
            // 
            // levelLabel
            // 
            this.levelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.levelLabel.Location = new System.Drawing.Point(121, 16);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(157, 18);
            this.levelLabel.TabIndex = 0;
            this.levelLabel.Text = "Level (Board size)";
            // 
            // boardSizeSelect
            // 
            this.boardSizeSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boardSizeSelect.FormattingEnabled = true;
            this.boardSizeSelect.Location = new System.Drawing.Point(487, 13);
            this.boardSizeSelect.Name = "boardSizeSelect";
            this.boardSizeSelect.Size = new System.Drawing.Size(225, 23);
            this.boardSizeSelect.TabIndex = 1;
            // 
            // initialvisibilityLabel
            // 
            this.initialvisibilityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.initialvisibilityLabel.AutoSize = true;
            this.initialvisibilityLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.initialvisibilityLabel.Location = new System.Drawing.Point(59, 66);
            this.initialvisibilityLabel.Name = "initialvisibilityLabel";
            this.initialvisibilityLabel.Size = new System.Drawing.Size(282, 18);
            this.initialvisibilityLabel.TabIndex = 2;
            this.initialvisibilityLabel.Text = "Initial visibility time (in seconds)";
            // 
            // initialVisibilityTimeText
            // 
            this.initialVisibilityTimeText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.initialVisibilityTimeText.Location = new System.Drawing.Point(487, 63);
            this.initialVisibilityTimeText.Name = "initialVisibilityTimeText";
            this.initialVisibilityTimeText.Size = new System.Drawing.Size(225, 23);
            this.initialVisibilityTimeText.TabIndex = 3;
            this.initialVisibilityTimeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flippedPairLabel
            // 
            this.flippedPairLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flippedPairLabel.AutoSize = true;
            this.flippedPairLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flippedPairLabel.Location = new System.Drawing.Point(14, 116);
            this.flippedPairLabel.Name = "flippedPairLabel";
            this.flippedPairLabel.Size = new System.Drawing.Size(372, 18);
            this.flippedPairLabel.TabIndex = 6;
            this.flippedPairLabel.Text = "Visibility time for a flipped pair (in seconds)";
            // 
            // visibilityTimeFlippedPairText
            // 
            this.visibilityTimeFlippedPairText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.visibilityTimeFlippedPairText.Location = new System.Drawing.Point(487, 113);
            this.visibilityTimeFlippedPairText.Name = "visibilityTimeFlippedPairText";
            this.visibilityTimeFlippedPairText.Size = new System.Drawing.Size(225, 23);
            this.visibilityTimeFlippedPairText.TabIndex = 7;
            this.visibilityTimeFlippedPairText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // allowMultipleCardsToBeFlippedCheckbox
            // 
            this.allowMultipleCardsToBeFlippedCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allowMultipleCardsToBeFlippedCheckbox.AutoSize = true;
            this.allowMultipleCardsToBeFlippedCheckbox.Location = new System.Drawing.Point(572, 165);
            this.allowMultipleCardsToBeFlippedCheckbox.Name = "allowMultipleCardsToBeFlippedCheckbox";
            this.allowMultipleCardsToBeFlippedCheckbox.Size = new System.Drawing.Size(56, 19);
            this.allowMultipleCardsToBeFlippedCheckbox.TabIndex = 11;
            this.allowMultipleCardsToBeFlippedCheckbox.Text = "Allow";
            this.allowMultipleCardsToBeFlippedCheckbox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 750);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.TextBox visibilityTimeFlippedPairText;
        private System.Windows.Forms.Label flippedPairLabel;
        private System.Windows.Forms.TextBox initialVisibilityTimeText;
        private System.Windows.Forms.Label initialvisibilityLabel;
        private System.Windows.Forms.ComboBox boardSizeSelect;
        private System.Windows.Forms.Button saveSettingsBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Po;
        private System.Windows.Forms.CheckBox allowMultipleCardsToBeFlippedCheckbox;
        private System.Windows.Forms.Panel panel2;
    }
}