using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GraMemory
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            usernameBox.Text = Program.userName;
        }

        private void saveSettingsBtn_Click(object sender, EventArgs e)
        {
            Program.userName = usernameBox.Text;
            LayoutForm.Instance.StartGame();
        }
    }
}
