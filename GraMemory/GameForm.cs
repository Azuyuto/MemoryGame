using GraMemory.Model;
using GraMemory.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraMemory
{
    public partial class GameForm : Form
    {
        static GameForm instance;

        public static GameForm Instance
        {
            get
            {
                if (instance == null)
                    return new GameForm();

                return instance;
            }
        }

        Random random = new Random();

        public GameForm()
        {
            InitializeComponent();
            gamePanel.ColumnCount = ((int)Math.Sqrt(Program.countCards));
            gamePanel.RowCount = ((int)Math.Sqrt(Program.countCards));
            for (int i = 0; i < ((int)Math.Sqrt(Program.countCards)) - 1; i++)
            {
                gamePanel.ColumnStyles.Add(new ColumnStyle());
                gamePanel.RowStyles.Add(new RowStyle());
            }
            foreach (ColumnStyle style in gamePanel.ColumnStyles)
            {
                style.SizeType = SizeType.Percent;
                style.Width = 100 / ((int)Math.Sqrt(Program.countCards));
            }
            foreach (RowStyle style in gamePanel.RowStyles)
            {
                style.SizeType = SizeType.Percent;
                style.Height = 100 / ((int)Math.Sqrt(Program.countCards));
            }
            var championList = ChampionResources.ResourceManager
                       .GetResourceSet(CultureInfo.CurrentCulture, true, true)
                       .Cast<DictionaryEntry>()
                       .Where(x => x.Value.GetType() == typeof(Bitmap))
                       .Select(x => new ChampionIcon() { Name = x.Key.ToString(), Image = (Bitmap)x.Value })
                       .ToList();
            var picturBoxes = new List<PictureBox>();
            for (int r = 0; r < Program.countCards; r+=2)
            {
                var rand = random.Next(0, championList.Count() - 1);
                for(int c = 0; c< 2; c++)
                {
                    var entity = new PictureBox()
                    {
                        Tag = championList[rand],
                        Image = championList[rand].Image,
                        Name = championList[rand].Name,
                        Size = new Size(240, 240),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Anchor = AnchorStyles.None
                    };
                    entity.Click += championPicture_Click;
                    picturBoxes.Add(entity);
                }
                championList.RemoveAt(rand);
            }
            picturBoxes.OrderBy(a => random.Next()).ToList().ForEach(a => gamePanel.Controls.Add(a));
            StartGame();
        }

        public async void StartGame()
        {
            LayoutForm.Instance.StopGameTimer();
            LayoutForm.Instance.StartInitialVisibilityTimer();
            await Task.Delay(Program.initialVisibilityTime * 1000);
            LayoutForm.Instance.StopInitialVisibilityTimer();
            HideChampions();
            LayoutForm.Instance.StartGameTimer();
        }

        private void HideChampions()
        {
            for(int i=0;i<gamePanel.Controls.Count;i++)
            {
                (gamePanel.Controls[i] as PictureBox).Image = Resources.emptyCard;
                (gamePanel.Controls[i] as PictureBox).Name = "Empty";
            }
        }

        private static bool CanFlipped = true;
        private PictureBox FirstCard { get; set; }
        private PictureBox SecondCard { get; set; }

        private void championPicture_Click(object sender, EventArgs e)
        {
            if((sender as PictureBox).Name == "Empty" && CanFlipped)
            {
                if (FirstCard != null)
                {
                    SecondCard = (sender as PictureBox);
                    SecondCard.Image = (SecondCard.Tag as ChampionIcon).Image;
                    SecondCard.Name = (SecondCard.Tag as ChampionIcon).Name;
                    CheckTheCards(FirstCard, SecondCard);
                    FirstCard = null;
                    SecondCard = null;
                }
                else
                {
                    FirstCard = (sender as PictureBox);
                    FirstCard.Image = (FirstCard.Tag as ChampionIcon).Image;
                    FirstCard.Name = (FirstCard.Tag as ChampionIcon).Name;
                }
            }
        }

        private async void CheckTheCards(PictureBox firstCard, PictureBox secondCard)
        {
            if(Program.allowMultipleCardsToBeFlipped == false)
            {
                CanFlipped = false;
            }
            await Task.Delay(Program.visibilityTimeFlippedPair * 1000);
            if(firstCard.Name == secondCard.Name)
            {
                firstCard.Image = null;
                firstCard.Name = null;
                secondCard.Image = null;
                secondCard.Name = null;
                LayoutForm.Instance.AddFindedCards();
                CheckEndGame();
            }
            else
            {
                LayoutForm.Instance.AddMissesFinded();
                firstCard.Image = Resources.emptyCard;
                firstCard.Name = "Empty";
                secondCard.Image = Resources.emptyCard;
                secondCard.Name = "Empty";
            }
            CanFlipped = true;
        }

        private void CheckEndGame()
        {
            if(Program.countCards == LayoutForm.Instance.GetFindedCards())
            {
                LayoutForm.Instance.EndGame();
            }
        }
    }
}
