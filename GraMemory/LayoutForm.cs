using GraMemory.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace GraMemory
{
    public partial class LayoutForm : Form
    {
        static LayoutForm instance;

        private System.Timers.Timer gameTimer { get; set; }
        private System.Timers.Timer initialVisibilityTimer { get; set; }
        private int Minutes { get; set; }
        private int Seconds { get; set; }
        private int InitialSeconds { get; set; }
        private int FindedCards { get; set; }
        private int MissesFinded { get; set; }

        public static LayoutForm Instance
        {
            get
            {
                if(instance == null)
                    return new LayoutForm();

                return instance;
            }
        }

        public LayoutForm()
        {
            InitializeComponent();
            instance = this;
            stopGameBtn.Tag = true;
            openChildForm(new UserForm());
        }

        public void StartGameTimer()
        {
            Seconds = 0;
            Minutes = 0;
            SetGameTimeLabel();
            gameTimer.Stop();
            gameTimer.Start();
            ShowGameAttributePanel();
        }

        private void ShowGameAttributePanel()
        {
            visibilityPanel.Visible = true;
            visibilitySaveBtn.Visible = true;
            visibilityTimeBox.Text = Program.visibilityTimeFlippedPair.ToString();
            visibilityTimeBox.Visible = true;
            visibilityTimeLabel.Visible = true;
            centerLine.Visible = true;
            endGameBtn.Visible = true;
            stopGameBtn.Visible = true;
            timer.Visible = true;
        }

        private void HideGameAttributePanel()
        {
            visibilityPanel.Visible = false;
            visibilitySaveBtn.Visible = false;
            visibilityTimeBox.Visible = false;
            visibilityTimeLabel.Visible = false;
            centerLine.Visible = false;
            endGameBtn.Visible = false;
            stopGameBtn.Visible = false;
            timer.Visible = false;
        }

        private void ShowGamePanel()
        {
            settingsBtn.Visible = true;
            newGameBtn.Visible = true;
        }

        private void HideGamePanel()
        {
            settingsBtn.Visible = false;
            newGameBtn.Visible = false;
        }

        public void StartInitialVisibilityTimer()
        {
            preTimer.Visible = true;
            HideGamePanel();
            InitialSeconds = 0;
            SetInitialVisibilityTimeLabel();
            initialVisibilityTimer.Stop();
            initialVisibilityTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameTimer = new System.Timers.Timer();
            gameTimer.Interval = 1000;
            gameTimer.Elapsed += new ElapsedEventHandler(OnGameTimeEvent);

            initialVisibilityTimer = new System.Timers.Timer();
            initialVisibilityTimer.Interval = 1000;
            initialVisibilityTimer.Elapsed += new ElapsedEventHandler(OnInitialVisibilityTimeEvent);
        }

        private void OnGameTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() => {
                Seconds += 1;
                if(Seconds == 69)
                {
                    Seconds = 0;
                    Minutes += 1;
                }
                SetGameTimeLabel();
            }));
        }

        private void SetGameTimeLabel()
        {
            timer.Text = String.Format("Time: {0}:{1}", Minutes.ToString().PadLeft(2, '0'), Seconds.ToString().PadLeft(2, '0'));
        }

        private void OnInitialVisibilityTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() => {
                InitialSeconds += 1;
                SetInitialVisibilityTimeLabel();
            }));
        }

        private void SetInitialVisibilityTimeLabel()
        {
            preTimer.Text = String.Format("Time to start: {0}", Program.initialVisibilityTime - InitialSeconds);
        }

        public void StopGameTimer()
        {
            gameTimer.Stop();
        }

        public void StopInitialVisibilityTimer()
        {
            initialVisibilityTimer.Stop();
            preTimer.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void StartGame()
        {
            username.Text = Program.userName;
            FindedCards = 0;
            MissesFinded = 0;
            openChildForm(new GameForm());
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new SettingsForm());
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void visibilitySaveBtn_Click(object sender, EventArgs e)
        {
            Program.visibilityTimeFlippedPair = int.Parse(visibilityTimeBox.Text);
        }

        private void stopGameBtn_Click(object sender, EventArgs e)
        {
            if((bool)stopGameBtn.Tag)
            {
                gameTimer.Stop();
                stopGameBtn.Text = "Resume game";
                stopGameBtn.Tag = false;
            }
            else
            {
                gameTimer.Start();
                stopGameBtn.Text = "Stop game";
                stopGameBtn.Tag = true;
            }
        }

        public void EndGame()
        {
            HideGameAttributePanel();
            ShowGamePanel();
            var score = FindedCards * (int)Math.Sqrt(Program.countCards);
            score -= MissesFinded * Program.visibilityTimeFlippedPair;
            score -= Program.initialVisibilityTime;
            RankUtils.AddNewEntry(new Rank()
            {
                UserName = Program.userName,
                Score = score,
                TimeInSeconds = Minutes * 60 + Seconds
            });
            openChildForm(new UserForm());
            showRank();
        }

        private void endGameBtn_Click(object sender, EventArgs e)
        {
            EndGame();
        }

        private void username_Click(object sender, EventArgs e)
        {
            if(!preTimer.Visible)
                EndGame();
        }

        private void showRankBtn_Click(object sender, EventArgs e)
        {
            showRank();
        }

        private void showRank()
        {
            using (RankForm form = new RankForm())
            {
                form.ShowDialog(this);
            }
        }

        public int GetFindedCards()
        {
            return FindedCards;
        }

        public void AddFindedCards()
        {
            FindedCards += 2;
        }

        public void AddMissesFinded()
        {
            MissesFinded ++;
        }
    }
}
