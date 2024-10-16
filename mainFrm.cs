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
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            InitializeComponent();
        }
        public Form FormToShowOnClosing { get; set; }
        private void mainFrm_Load(object sender, EventArgs e)
        {

        }

        private void tempbtnExitMain_Click(object sender, EventArgs e)
        {
            this.Close();
            if (this.FormToShowOnClosing != null)
            {
                this.FormToShowOnClosing.Show();
            }
        }
    }
}
