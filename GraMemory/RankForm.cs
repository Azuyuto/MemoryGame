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
    public partial class RankForm : Form
    {
        public RankForm()
        {
            InitializeComponent();
            var ranks = RankUtils.GetRanks();
            for (int i = 0; i < ranks.Count - 1; i++)
            {
                rankListPanel.RowStyles.Add(new RowStyle());
            }
            foreach (RowStyle style in rankListPanel.RowStyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Height = 30;
            }
            rankListPanel.Height = 30 * ranks.Count;
            foreach (var rank in ranks)
            {
                AddNewLabel(rank.UserName);
                AddNewLabel(rank.Score.ToString());
                AddNewLabel(String.Format(@"{0}:{1}", (rank.TimeInSeconds / 60).ToString().PadLeft(2, '0'), (rank.TimeInSeconds % 60).ToString().PadLeft(2, '0')));
            }
        }

        private void AddNewLabel(string value)
        {
            var entity = new Label()
            {
                Text = value,
                Font = new Font("Showcard Gothic", 11),
                Anchor = AnchorStyles.None,
                Dock = DockStyle.None,
                AutoSize = true
            };
            rankListPanel.Controls.Add(entity);
        }
    }
}
