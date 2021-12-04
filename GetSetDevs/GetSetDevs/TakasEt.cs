using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetSetDevs
{
    public partial class TakasEt : Form
    {
        public TakasEt()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
        }

        private void TakasEt_Load(object sender, EventArgs e)
        {

        }

      

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
