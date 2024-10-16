using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public Form FormToShowOnClosing { get; set; }
        private void loginButton_Click(object sender, EventArgs e)
        {
            var Form1 = new mainFrm();
            Form1.FormToShowOnClosing = this;
            Form1.Show();
            this.Hide();
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
