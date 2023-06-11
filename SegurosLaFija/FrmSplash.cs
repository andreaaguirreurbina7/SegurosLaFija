using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegurosLaFija
{
    public partial class FrmSplash : Form
    {
        int Tiempo = 0;

        public FrmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Tiempo<4000)
            {
                Tiempo += 40;
                progressBar1.Value += 1;
         
            }
            else 
            { 
                this.Close();
                timer1.Stop();
            }
            


        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {

            timer1.Interval = 10;
            timer1.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
