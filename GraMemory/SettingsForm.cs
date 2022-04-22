using GraMemory.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GraMemory
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            var list = new ComboboxItem[6];
            list[0] = (new ComboboxItem() { Text = "Debil (2x2)", Value = 4 });
            list[1] = (new ComboboxItem() { Text = "Start (4x4)", Value = 16 });
            list[2] = (new ComboboxItem() { Text = "Easy (6x6)", Value = 36 });
            list[3] = (new ComboboxItem() { Text = "Medium (8x8)", Value = 64 });
            list[4] = (new ComboboxItem() { Text = "Hard (10x10)", Value = 100 });
            list[5] = (new ComboboxItem() { Text = "Very Hard (12x12)", Value = 144 });
            boardSizeSelect.Items.AddRange(list);
            for(int i=0;i<6;i++)
            {
                if (list[i].Value == Program.countCards)
                    boardSizeSelect.SelectedIndex = i;
            }
            initialVisibilityTimeText.Text = Program.initialVisibilityTime.ToString();
            visibilityTimeFlippedPairText.Text = Program.visibilityTimeFlippedPair.ToString();
            allowMultipleCardsToBeFlippedCheckbox.Checked = Program.allowMultipleCardsToBeFlipped;
        }

        private void saveSettingsBtn_Click(object sender, EventArgs e)
        {
            Program.countCards = (boardSizeSelect.SelectedItem as ComboboxItem).Value;
            Program.initialVisibilityTime = int.Parse(initialVisibilityTimeText.Text);
            Program.visibilityTimeFlippedPair = int.Parse(visibilityTimeFlippedPairText.Text);
            Program.allowMultipleCardsToBeFlipped = allowMultipleCardsToBeFlippedCheckbox.Checked;
        }
    }
}
