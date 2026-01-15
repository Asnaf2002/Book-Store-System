using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_front
{
    public partial class Form1 : Form
    {
        private int startpos;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            Myprogress.Value = startpos;
            Percentagelbl.Text = startpos + "%";
            if (Myprogress.Value == 50)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                login log = new login();
                log.Show();
                this.Hide();
            }
        }

        private void Myprogress_Click(object sender, EventArgs e)
        {

        }

        private void Percentagelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
